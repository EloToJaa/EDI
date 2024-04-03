using Edi.Contracts.Interchanges;
using indice.Edi;
using System.Text.Json;

namespace Edi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "edi");
            string filePath = Path.Combine(dirPath, "INVOIC_a2i24021713091266429e1.edi.c2e");

            var grammar = EdiGrammar.NewEdiFact();
            var interchange = default(INVOIC);

            using var stream = new StreamReader(filePath);
            interchange = new EdiSerializer().Deserialize<INVOIC>(stream, grammar);

            Console.WriteLine(JsonSerializer.Serialize(interchange, new JsonSerializerOptions
            {
                WriteIndented = true,
            }));
            Console.ReadKey();
        }
    }
}
