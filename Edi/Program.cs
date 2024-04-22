using Edi.Download;
using Edi.Generator;
using indice.Edi;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Edi;

internal class Program
{
    static void Main(string[] args)
    {
        CheckParse();
        //GenerateCode();
        //DownloadMessages();
    }

    private static void DownloadMessages()
    {
        var downloader = new Downloader();
        downloader.Download();
        //downloader.DownloadMessageSpecification("D97A", "INVOIC");
    }

    private static void CheckParse()
    {
        string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "edi");
        string filePath = Path.Combine(dirPath, "ORDRSP_00000000000163.c2e");
        string fileContents = File.ReadAllText(filePath);

        const char segmentSplit = '\'';
        const char elementSplit = '+';
        const char valueSplit = ':';

        var segments = fileContents.Split(segmentSplit).Select(s => s.Trim());
        string unhSegment = segments.Where(s => s.StartsWith("UNH")).First();
        var elements = unhSegment.Split(elementSplit);
        string versionElement = elements[2];
        var values = versionElement.Split(valueSplit);

        string messageName = values[0];
        string versionNumber = values[1] + values[2];

        var type = InterchangeFactory.CreateType(messageName);

        if (type is null) return;

        var grammar = EdiGrammar.NewEdiFact();
        using var stream = new StreamReader(filePath);

        object interchange = new EdiSerializer().Deserialize(stream, grammar, type);

        string json = JsonSerializer.Serialize(interchange, new JsonSerializerOptions
        {
            WriteIndented = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        });

        File.WriteAllText(Path.Combine(dirPath, "out.json"), Regex.Unescape(json));
    }

    private static void GenerateCode()
    {
        var generator = new GeneratorService();

        generator.Generate();
    }
}
