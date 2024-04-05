using Diacritics.Extensions;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace Edi.Generator;

public class GeneratorService
{
    public string GenerateClassForSegment(string segmentName, Segment segment, string namespaceName)
    {
        var sb = new StringBuilder();

        sb.Append("using System.Collections.Generic;\n");
        sb.Append("using indice.Edi.Serialization;\n\n");
        sb.Append($"namespace {namespaceName}.Segments;\n\n");
        sb.Append("/// <summary>\n");
        sb.Append($"/// {segment.Purpose}\n");
        sb.Append("/// </summary>\n");
        sb.Append($"[EdiSegment, EdiPath(\"{segmentName}\")]\n");
        sb.Append($"public class {segmentName}\n");
        sb.Append("{\n");

        for(int i = 0; i < segment.Elements.Count; i++)
        {
            var element = segment.Elements[i];
            if(element.Components is null)
            {
                if (element.Desc is null) continue;
                string description = element.Definition is null ? element.Desc : element.Definition;

                sb.Append("\t/// <summary>\n");
                sb.Append($"\t/// {description}\n");
                sb.Append("\t/// </summary>\n");
                sb.Append($"\t[EdiValue(\"{ConvertDataType(element.DataType, element.QualifierRef, element.MaxLength)}\", Path = \"{segmentName}/{i}/0\")]\n");
                sb.Append($"\tpublic {ConvertVariableType(element.DataType, element.QualifierRef)} {ConvertToPascalCase(element.Desc)} {{ get; set; }}\n\n");
                continue;
            }

            for(int j = 0; j < element.Components.Count; j++)
            {
                var component = element.Components[j];
                if (component.Desc is null) continue;
                string description = component.Definition is null ? component.Desc : component.Definition;

                sb.Append("\t/// <summary>\n");
                sb.Append($"\t/// {description}\n");
                sb.Append("\t/// </summary>\n");
                sb.Append($"\t[EdiValue(\"{ConvertDataType(component.DataType, component.QualifierRef, component.MaxLength)}\", Path = \"{segmentName}/{i}/{j}\")]\n");
                sb.Append($"\tpublic {ConvertVariableType(component.DataType, component.QualifierRef)} {ConvertToPascalCase(component.Desc)} {{ get; set; }}\n\n");
            }
        }
        sb.Append("}");

        return sb.ToString();
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
        sb.Append("\tpublic Dictionary<string, string> Qualifiers => new Dictionary<string, string> {\n");

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
        if (qualifierRef is not null) return "string?";
        return inputDataType switch
        {
            "AN" => "string?",
            "N" => "int?",
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
            .Select(w => char.ToUpper(w[0]) + w.Substring(1))
            .ToArray();
        return string.Join("", convertedWords);
    }
}
