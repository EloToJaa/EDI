using Edi.Generator;
using indice.Edi;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Edi;

internal class Program
{
    static void Main(string[] args)
    {
        CheckParse();
        //GenerateCode();
    }

    private static Tuple<string, string> GetInterchangeInfo(
        string interchangeContents,
        char segmentSplit = '\'',
        char elementSplit = '+',
        char valueSplit = ':')
    {
        var segments = interchangeContents.Split(segmentSplit).Select(s => s.Trim());
        string unhSegment = segments.Where(s => s.StartsWith("UNH")).First();
        var elements = unhSegment.Split(elementSplit);
        string versionElement = elements[2];
        var values = versionElement.Split(valueSplit);

        string messageName = values[0];
        string versionNumber = values[1] + values[2];

        return Tuple.Create(messageName, versionNumber);
    }

    private static void CheckParse()
    {
        string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "edi");
        string filePath = Path.Combine(dirPath, "DESADV_a2i240217135425491a871.edi.c2e");
        string fileContents = File.ReadAllText(filePath);

        var (messageName, _) = GetInterchangeInfo(fileContents);

        var type = InterchangeFactory.CreateType(messageName);

        if (type is null) return;

        var grammar = EdiGrammar.NewEdiFact();
        using var stream = new StreamReader(filePath);

        object interchange = new EdiSerializer().Deserialize(stream, grammar, type);

        string json = JsonSerializer.Serialize(interchange, new JsonSerializerOptions
        {
            WriteIndented = true,
            //DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        });

        File.WriteAllText(Path.Combine(dirPath, "out.json"), Regex.Unescape(json));
    }

    private static void GenerateCode()
    {
        var generator = new GeneratorService();

        generator.Generate();
    }
}
