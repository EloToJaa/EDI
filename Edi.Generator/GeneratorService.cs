using Diacritics.Extensions;
using System.Text;
using System.Text.RegularExpressions;

namespace Edi.Generator;

public class GeneratorService
{
    public string GenerateClassForSegment(Schema schema, string segmentName, string namespaceName)
    {
        string className = ConvertToPascalCase(segmentName);
        var sb = new StringBuilder();

        sb.Append("using indice.Edi.Serialization;\n\n");
        sb.AppendFormat("namespace {0}.Segments;\n\n", namespaceName);
        sb.AppendFormat("public class {0}\n", segmentName);
        sb.Append("{\n");

        var segment = schema.Segments[segmentName];
        for(int i = 0; i < segment.Elements.Count; i++)
        {
            var element = segment.Elements[i];
            if(element.Components is null)
            {
                if (element.Desc is null) continue;
                sb.Append($"\t[EdiValue(\"{ConvertDataType(element.DataType, element.MaxLength)}\", Path = \"{segmentName}/{i}/0\")]\n");
                sb.Append($"\tpublic {ConvertVariableType(element.DataType)} {ConvertToPascalCase(element.Desc)} {{ get; set; }}\n\n");
            }
        }
        sb.Append("}");

        return sb.ToString();
    }

    private string ConvertDataType(string? inputDataType, int? maxLength)
    {
        if (maxLength is null) maxLength = 35;
        if (inputDataType is null) inputDataType = "AN";
        string dataType = inputDataType switch
        {
            "AN" => "X",
            "N" => "9",
            _ => "X"
        };
        return $"{dataType}({maxLength})";
    }

    private string ConvertVariableType(string? inputDataType)
    {
        if (inputDataType is null) return "string?";
        return inputDataType switch
        {
            "AN" => "string?",
            "N" => "int?",
            _ => "string?"
        };
    }

    private string[] CleanupString(string input)
    {
        string cleanInput = input.ToLower().RemoveDiacritics();
        string removedChars = Regex.Replace(cleanInput, "[^a-z0-9 ]", "");
        return removedChars.Split(" ");
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
