using Edi.Contracts.Interchanges;
using Edi.Download;
using Edi.Generator;
using indice.Edi;
using System.Text.Json;

namespace Edi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckParse();
            GenerateCode();
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
            //string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "edi");
            //string filePath = Path.Combine(dirPath, "INVOIC_a2i24021713091266429e1.edi.c2e");

            //var grammar = EdiGrammar.NewEdiFact();
            //var interchange = default(Interchange<Edi.Contracts.Messages.INVOIC>);
            //using var stream = new StreamReader(filePath);
            //interchange = new EdiSerializer().Deserialize<Interchange<Edi.Contracts.Messages.INVOIC>>(stream, grammar);

            //string json = JsonSerializer.Serialize(interchange, new JsonSerializerOptions
            //{
            //    WriteIndented = true,
            //});

            //File.WriteAllText(Path.Combine(dirPath, "out.json"), json);
        }

        private static void GenerateCode()
        {
            var generator = new GeneratorService();

            generator.Generate();
        }
    }
}
