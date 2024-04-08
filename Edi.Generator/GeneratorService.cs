using Diacritics.Extensions;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

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

        var occurences = CountOccurences(segment.Elements);
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

        var occurences = CountOccurences(element.Components);
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

    private Dictionary<string, int> CountOccurences(List<Element> elements)
    {
        var occurences = new Dictionary<string, int>();

        foreach (var element in elements)
        {
            if (element.Desc is null) continue;
            string key = ConvertToPascalCase(element.Desc);
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
