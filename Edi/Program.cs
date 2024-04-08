using Edi.Contracts.Interchanges;
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
            //GenerateCode();
        }

        private static void CheckParse()
        {
            string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "edi");
            string filePath = Path.Combine(dirPath, "INVOIC_a2i24021713091266429e1.edi.c2e");

            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(INVOIC);
            using var stream = new StreamReader(filePath);
            interchange = new EdiSerializer().Deserialize<INVOIC>(stream, grammar);

            string json = JsonSerializer.Serialize(interchange, new JsonSerializerOptions
            {
                WriteIndented = true,
            });

            File.WriteAllText(Path.Combine(dirPath, "out.json"), json);
        }

        private static void GenerateCode()
        {
            string schemaDirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "schemas");
            string schemaFilePath = Path.Combine(schemaDirPath, "D97A", "RSSBus_D97A.json");
            string schemaContents = File.ReadAllText(schemaFilePath);
            var schema = JsonSerializer.Deserialize<Schema>(schemaContents);

            if (schema is null) return;

            var generator = new GeneratorService();

            string dirPath = @"C:\Users\l.budziak\Documents\Projects\Edi\Edi.Contracts";
            string namespaceName = "Edi.Contracts";

            string segmentsDir = Path.Combine(dirPath, "Segments");
            if (!Directory.Exists(segmentsDir))
                Directory.CreateDirectory(segmentsDir);

            foreach (var (segmentName, segment) in schema.Segments)
            {
                string code = generator.GenerateClassForSegment(segmentName, segment, namespaceName);
                File.WriteAllText(Path.Combine(segmentsDir, $"{segmentName}.cs"), code);
            }

            string qualifiersDir = Path.Combine(dirPath, "Qualifiers");
            if (!Directory.Exists(qualifiersDir))
                Directory.CreateDirectory(qualifiersDir);

            foreach (var (qualifierName, qualifier) in schema.Qualifiers)
            {
                string code = generator.GenerateClassForQualifier(qualifierName, qualifier, namespaceName);
                File.WriteAllText(Path.Combine(qualifiersDir, $"{generator.ConvertToPascalCase(qualifierName)}.cs"), code);
            }
        }
    }
}
