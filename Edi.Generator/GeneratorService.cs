using Diacritics.Extensions;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Edi.Generator;

public class GeneratorService
{
    public string GenerateClassForSegment(string segmentName, Segment segment, string namespaceName)
    {
        var elementClassesCode = new Dictionary<string, string>();
        var sb = new StringBuilder();

        sb.Append("using System.Collections.Generic;\n");
        sb.Append($"using {namespaceName}.Qualifiers;\n");
        sb.Append("using indice.Edi.Serialization;\n\n");

        sb.Append($"namespace {namespaceName}.Segments;\n\n");

        sb.Append("/// <summary>\n");
        sb.Append($"/// {segment.Purpose}\n");
        sb.Append("/// </summary>\n");
        sb.Append($"[EdiSegment, EdiPath(\"{segmentName}\")]\n");
        sb.Append($"public class {segmentName}\n");
        sb.Append("{\n");

        var occurences = CountOccurences(segment.Elements.Select(e => ConvertToPascalCase(e.Desc!)).ToList());
        var numbers = new Dictionary<string, int>();

        for (int i = 0; i < segment.Elements.Count; i++)
        {
            var element = segment.Elements[i];
            if (element is null || element.Desc is null) continue;

            string variableName = ConvertToPascalCase(element.Desc);
            if (occurences[variableName] > 1)
            {
                if (numbers.ContainsKey(variableName)) numbers[variableName]++;
                else numbers.Add(variableName, 1);

                variableName += numbers[variableName];
            }

            string description;
            if(element.Components is null)
            {
                description = element.Definition is null ? element.Desc : element.Definition;

                sb.Append("\t/// <summary>\n");
                sb.Append($"\t/// {description}\n");
                sb.Append("\t/// </summary>\n");
                sb.Append($"\t[EdiValue(\"{ConvertDataType(element.DataType, element.QualifierRef, element.MaxLength)}\", Path = \"{segmentName}/{i}\", Mandatory = {element.Required.ToString().ToLower()})]\n");
                sb.Append($"\tpublic {ConvertVariableType(element.DataType, element.QualifierRef)} {variableName} {{ get; set; }}\n\n");
                continue;
            }

            string? elementCode = GenerateClassForElement(segmentName, element);
            if(elementCode is null) continue;

            string className = $"{segmentName}_{ConvertToPascalCase(element.Desc)}";
            elementClassesCode[className] = elementCode;

            description = element.Definition is null ? element.Desc : element.Definition;

            sb.Append("\t/// <summary>\n");
            sb.Append($"\t/// {description}\n");
            sb.Append("\t/// </summary>\n");
            sb.Append($"\t[EdiPath(\"{segmentName}/{i}\")]\n");
            sb.Append($"\tpublic {segmentName}_{ConvertToPascalCase(element.Desc)}? {variableName} {{ get; set; }}\n");
            if (i < segment.Elements.Count - 1) sb.Append("\n");
        }
        sb.Append("}");

        foreach (var (_, elementCode) in elementClassesCode)
        {
            sb.Append("\n\n");
            sb.Append(elementCode);
        }

        return sb.ToString();
    }

    private string? GenerateClassForElement(string segmentName, Element? element)
    {
        if (element is null || element.Desc is null || element.Components is null) return null;
        string className = $"{segmentName}_{ConvertToPascalCase(element.Desc)}";

        var occurences = CountOccurences(element.Components.Select(e => ConvertToPascalCase(e.Desc!)).ToList());
        var numbers = new Dictionary<string, int>();
        var sb = new StringBuilder();

        string description = element.Definition is null ? element.Desc : element.Definition;

        sb.Append("/// <summary>\n");
        sb.Append($"/// {description}\n");
        sb.Append("/// </summary>\n");
        sb.Append("[EdiElement]\n");
        sb.Append($"public class {className}\n");
        sb.Append("{\n");

        for (int i = 0; i < element.Components.Count; i++)
        {
            var component = element.Components[i];
            if (component.Desc is null) continue;

            description = component.Definition is null ? component.Desc : component.Definition;
            string variableName = ConvertToPascalCase(component.Desc);
            if (occurences[variableName] > 1)
            {
                if (numbers.ContainsKey(variableName)) numbers[variableName]++;
                else numbers.Add(variableName, 1);

                variableName += numbers[variableName];
            }

            sb.Append("\t/// <summary>\n");
            sb.Append($"\t/// {description}\n");
            sb.Append("\t/// </summary>\n");
            sb.Append($"\t[EdiValue(\"{ConvertDataType(component.DataType, component.QualifierRef, component.MaxLength)}\", Path = \"{segmentName}/*/{i}\", Mandatory = {component.Required.ToString().ToLower()})]\n");
            sb.Append($"\tpublic {ConvertVariableType(component.DataType, component.QualifierRef)} {variableName} {{ get; set; }}\n");
            if(i < element.Components.Count - 1) sb.Append("\n");
        }

        sb.Append("}");

        return sb.ToString();
    }

    private Dictionary<string, int> CountOccurences(List<string> elements)
    {
        var occurences = new Dictionary<string, int>();

        foreach (var key in elements)
        {
            if (key is null) continue;
            if (occurences.ContainsKey(key)) occurences[key]++;
            else occurences.Add(key, 1);
        }

        return occurences;
    }

    public string GenerateClassForQualifier(string qualifierName, Dictionary<string, string> qualifier, string namespaceName)
    {
        var sb = new StringBuilder();

        string className = ConvertToPascalCase(qualifierName);

        sb.Append("using System.Collections.Generic;\n");
        sb.Append("using System.Text.Json.Serialization;\n\n");

        sb.Append($"namespace {namespaceName}.Qualifiers;\n\n");

        sb.Append("/// <summary>\n");
        sb.Append($"/// {qualifierName}\n");
        sb.Append("/// </summary>\n");
        sb.Append($"public class {className}\n");
        sb.Append("{\n");

        sb.Append("\t/// <summary>\n");
        sb.Append("\t/// String assign converter\n");
        sb.Append("\t/// </summary>\n");
        sb.Append($"\tpublic static implicit operator {className}(string s) => new {className} {{ Code = s }};\n\n");

        sb.Append("\t/// <summary>\n");
        sb.Append("\t/// Code of the value\n");
        sb.Append("\t/// </summary>\n");
        sb.Append("\tpublic string? Code { get; set; }\n\n");

        sb.Append("\t/// <summary>\n");
        sb.Append("\t/// Value converted from code\n");
        sb.Append("\t/// </summary>\n");
        sb.Append("\tpublic string? Value => Code is null ? null : (Qualifiers.ContainsKey(Code) ? Qualifiers[Code] : null);\n\n");

        sb.Append("\t/// <summary>\n");
        sb.Append("\t/// All possible values\n");
        sb.Append("\t/// </summary>\n");
        sb.Append("\t[JsonIgnore]\n");
        sb.Append("\tpublic Dictionary<string, string> Qualifiers => new Dictionary<string, string>\n");
        sb.Append("\t{\n");

        foreach(var (code, value) in qualifier)
        {
            sb.Append($"\t\t{{ \"{code}\", \"{value}\" }},\n");
        }

        sb.Append("\t};\n");
        sb.Append("}");

        return sb.ToString();
    }

    public void Generate(string version = "D97A")
    {
        string schemaDirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "schemas");
        string schemaFilePath = Path.Combine(schemaDirPath, version, $"RSSBus_{version}.json");
        string schemaContents = File.ReadAllText(schemaFilePath);
        var schema = JsonSerializer.Deserialize<Schema>(schemaContents);

        if (schema is null) return;

        string messageSchemaFilePath = Path.Combine(schemaDirPath, version, $"schema.json");
        string messageSchemaContents = File.ReadAllText(messageSchemaFilePath);
        var messageSchema = JsonSerializer.Deserialize<MessageSchema>(messageSchemaContents);

        if (messageSchema is null) return;

        string dirPath = Path.Combine(GetSolutionDir(), "Edi.Contracts");
        string namespaceName = "Edi.Contracts";

        //string segmentsDir = Path.Combine(dirPath, "Segments");
        //if (!Directory.Exists(segmentsDir))
        //    Directory.CreateDirectory(segmentsDir);

        //foreach (var (segmentName, segment) in schema.Segments)
        //{
        //    string code = GenerateClassForSegment(segmentName, segment, namespaceName);
        //    File.WriteAllText(Path.Combine(segmentsDir, $"{segmentName}.cs"), code);
        //}

        //string qualifiersDir = Path.Combine(dirPath, "Qualifiers");
        //if (!Directory.Exists(qualifiersDir))
        //    Directory.CreateDirectory(qualifiersDir);

        //foreach (var (qualifierName, qualifier) in schema.Qualifiers)
        //{
        //    string code = GenerateClassForQualifier(qualifierName, qualifier, namespaceName);
        //    File.WriteAllText(Path.Combine(qualifiersDir, $"{ConvertToPascalCase(qualifierName)}.cs"), code);
        //}

        string messagesDir = Path.Combine(dirPath, "Messages");
        if (!Directory.Exists(messagesDir))
            Directory.CreateDirectory(messagesDir);

        //string segmentName = "RESETT";
        //string code = GenerateClassForMessage(segmentName, messageSchema.Messages[segmentName], namespaceName);

        foreach (var (messageName, messageSegments) in messageSchema.Messages)
        {
            var disallowed = new[] { "RESREQ", "RESRSP" };
            if (disallowed.Contains(messageName)) continue;
            string code = GenerateClassForMessage(messageName, messageSegments, namespaceName);
            File.WriteAllText(Path.Combine(messagesDir, $"{messageName}.cs"), code);
        }
    }

    public string GenerateClassForMessage(string messageName, List<MessageSegment> messageSegments, string namespaceName)
    {
        var occurences = CountOccurences(messageSegments.Select(e => e.SegmentName.StartsWith("SG") ? e.SegmentName : ConvertToPascalCase(e.Description)).ToList());
        var numbers = new Dictionary<string, int>();

        var sb = new StringBuilder();

        sb.Append("using System.Collections.Generic;\n");
        sb.Append($"using {namespaceName}.Segments;\n");
        sb.Append("using indice.Edi.Serialization;\n\n");

        sb.Append($"namespace {namespaceName}.Messages;\n\n");

        sb.Append("/// <summary>\n");
        sb.Append($"/// {messageName}\n");
        sb.Append("/// </summary>\n");
        sb.Append($"[EdiMessage]\n");
        sb.Append($"public class {messageName}\n");
        sb.Append("{\n");

        for(int i = 0; i < messageSegments.Count; i++)
        {
            var segment = messageSegments[i];
            if(segment.Depth > 1) continue;
            string mandatory = segment.Mandatory ? "M" : "C";

            string segmentName = segment.SegmentName;
            string variableName;

            if(segmentName.StartsWith("SG"))
            {
                sb.Append("\t/// <summary>\n");
                sb.Append($"\t/// {segmentName}\n");
                sb.Append("\t/// </summary>\n");

                variableName = segmentName;
                if (occurences[variableName] > 1)
                {
                    if (numbers.ContainsKey(variableName)) numbers[variableName]++;
                    else numbers.Add(variableName, 1);

                    variableName += numbers[variableName];
                }

                if (segment.MaxCount > 1)
                    sb.Append($"\tpublic List<{messageName}_{segmentName}> {variableName}{mandatory} {{ get; set; }} = new List<{messageName}_{segmentName}>();\n\n");
                else
                    sb.Append($"\tpublic {messageName}_{segmentName}? {variableName}{mandatory} {{ get; set; }}\n\n");

                continue;
            }

            sb.Append("\t/// <summary>\n");
            sb.Append($"\t/// {segment.Description}\n");
            sb.Append("\t/// </summary>\n");

            variableName = ConvertToPascalCase(segment.Description);
            if (occurences[variableName] > 1)
            {
                if (numbers.ContainsKey(variableName)) numbers[variableName]++;
                else numbers.Add(variableName, 1);

                variableName += numbers[variableName];
            }

            if (segment.MaxCount > 1)
                sb.Append($"\tpublic List<{segmentName}> {variableName}{mandatory} {{ get; set; }} = new List<{segmentName}>();\n");
            else
                sb.Append($"\tpublic {segmentName}? {variableName}{mandatory} {{ get; set; }}\n");

            if(i < messageSegments.Count - 1) sb.Append("\n");
        }

        sb.Append("}");

        var segmentGroups = new Dictionary<string, List<MessageSegment>>();
        for(int i = 0; i < messageSegments.Count - 1; i++)
        {
            var segment = messageSegments[i];
            string segmentName = segment.SegmentName;

            if (!segmentName.StartsWith("SG")) continue;

            segmentGroups[segmentName] = new List<MessageSegment>();

            int depth = messageSegments[i + 1].Depth;
            if (segment.Depth >= depth) continue;

            for(int j = i + 1; j < messageSegments.Count; j++)
            {
                var currentSegment = messageSegments[j];

                if (currentSegment.Depth <= segment.Depth) break;

                if (currentSegment.Depth == depth)
                    segmentGroups[segmentName].Add(currentSegment);
            }
        }

        foreach (var (segmentGroup, messages) in segmentGroups)
        {
            sb.Append("\n\n");
            sb.Append(GenerateClassForSegmentGroup(messageName, segmentGroup, messages));
        }

        return sb.ToString();
    }

    private string GenerateClassForSegmentGroup(string messageName, string segmentGroup, List<MessageSegment> messageSegments)
    {
        var occurences = CountOccurences(messageSegments.Select(e => e.SegmentName.StartsWith("SG") ? e.SegmentName : ConvertToPascalCase(e.Description)).ToList());
        var numbers = new Dictionary<string, int>();

        var sb = new StringBuilder();

        sb.Append($"public class {messageName}_{segmentGroup}\n");
        sb.Append("{\n");

        for(int i = 0; i < messageSegments.Count; i++)
        {
            var segment = messageSegments[i];
            string segmentName = segment.SegmentName;
            string mandatory = segment.Mandatory ? "M" : "C";
            string variableName;

            if(segmentName.StartsWith("SG"))
            {
                sb.Append("\t/// <summary>\n");
                sb.Append($"\t/// {segmentName}\n");
                sb.Append("\t/// </summary>\n");

                variableName = segmentName;
                if (occurences[variableName] > 1)
                {
                    if (numbers.ContainsKey(variableName)) numbers[variableName]++;
                    else numbers.Add(variableName, 1);

                    variableName += numbers[variableName];
                }

                if (segment.MaxCount > 1)
                    sb.Append($"\tpublic List<{messageName}_{segmentName}> {variableName}{mandatory} {{ get; set; }} = new List<{messageName}_{segmentName}>();\n\n");
                else
                    sb.Append($"\tpublic {messageName}_{segmentName}? {variableName}{mandatory} {{ get; set; }}\n\n");

                continue;
            }

            sb.Append("\t/// <summary>\n");
            sb.Append($"\t/// {segment.Description}\n");
            sb.Append("\t/// </summary>\n");

            variableName = ConvertToPascalCase(segment.Description);
            if (occurences[variableName] > 1)
            {
                if (numbers.ContainsKey(variableName)) numbers[variableName]++;
                else numbers.Add(variableName, 1);

                variableName += numbers[variableName];
            }

            if (segment.MaxCount > 1)
                sb.Append($"\tpublic List<{segmentName}> {variableName}{mandatory} {{ get; set; }} = new List<{segmentName}>();\n");
            else
                sb.Append($"\tpublic {segmentName}? {variableName}{mandatory} {{ get; set; }}\n");

            if (i < messageSegments.Count - 1) sb.Append("\n");
        }

        sb.Append("}");

        return sb.ToString();
    }

    private string GetSolutionDir()
    {
        string currentDir = AppDomain.CurrentDomain.BaseDirectory;
        while (!File.Exists(Path.Combine(currentDir, "Edi.sln")))
        {
            currentDir = Directory.GetParent(currentDir)!.FullName;

            if (currentDir == null)
                throw new InvalidOperationException("Solution file not found");
        }
        return currentDir;
    }

    private string ConvertDataType(string? inputDataType, string? qualifierRef, int? maxLength)
    {
        if (maxLength is null) maxLength = 35;
        if (qualifierRef is not null) return $"X({maxLength})";
        if (inputDataType is null) inputDataType = "AN";
        string dataType = inputDataType switch
        {
            "AN" => "X",
            "N" => "9",
            _ => "X"
        };
        return $"{dataType}({maxLength})";
    }

    private string ConvertVariableType(string? inputDataType, string? qualifierRef)
    {
        if (inputDataType is null) return "string?";
        if (qualifierRef is not null) return $"{ConvertToPascalCase(qualifierRef)}?";
        return inputDataType switch
        {
            "AN" => "string?",
            "N" => "decimal?",
            _ => "string?"
        };
    }

    private string[] CleanupString(string input)
    {
        string cleanInput = input.ToLower().RemoveDiacritics().Replace('/', ' ');
        string removedChars = Regex.Replace(cleanInput, "[^a-z0-9 ]", "");
        return removedChars.Split(' ');
    }

    public string ConvertToCamelCase(string input)
    {
        if(input.Length == 0) return string.Empty;
        string pascalCase = ConvertToPascalCase(input);
        return char.ToLower(pascalCase[0]) + pascalCase.Substring(1);
    }

    public string ConvertToPascalCase(string input)
    {
        if (input.Length == 0) return string.Empty;
        string[] words = CleanupString(input);
        var convertedWords = words
            .Where(w => w.Length > 0)
            .Select(w => char.ToUpper(w[0]) + w.Substring(1))
            .ToArray();
        return string.Join("", convertedWords);
    }
}
