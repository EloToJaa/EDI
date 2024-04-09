using HtmlAgilityPack;
using System.Text.Json;

namespace Edi.Download;

public class Downloader
{
    public List<MessageSegment> DownloadMessageSpecification(string version, string messageName, string schemaName = "edifact")
    {
        string url = @$"https://www.stylusstudio.com/{schemaName}/{version}/{messageName}.htm";

        var web = new HtmlWeb();
        var doc = web.Load(url);

        var messages = new List<MessageSegment>();

        var trNodes = doc.DocumentNode.SelectNodes("//body//table//table[@border='0']//tr");

        foreach (var trNode in trNodes)
        {
            var trDoc = new HtmlDocument();
            trDoc.LoadHtml(trNode.InnerHtml);
            var nodes = trDoc.DocumentNode.SelectNodes("//td[1]/span | //td[1]/a");

            var data = nodes
                .Select(n => Tuple.Create(
                    n.InnerText.Trim().Replace("&nbsp;", " ").Replace("Segment Group ", "SG"),
                    n.InnerText.ToCharArray().Where(c => c == '─').Count())
                )
                .ToArray();

            if (data is null) continue;

            int depth = data.Max(d => d.Item2);
            string text = data.Where(d => d.Item2 == 0).First().Item1;

            var countNode = trDoc.DocumentNode.SelectSingleNode("//td[2]");
            int count = 1;
            if (countNode is not null)
            {
                var countText = countNode.InnerText.Trim();
                string newCountText = countText.Replace("&nbsp;", " ").Replace("×", "").Trim();
                count = int.Parse(newCountText);
            }

            var mandatoryNode = trDoc.DocumentNode.SelectSingleNode("//td[3]");
            bool mandatory = false;
            if (mandatoryNode is not null)
            {
                var mandatoryText = mandatoryNode.InnerText.Trim();
                mandatory = mandatoryText == "(M)";
            }

            messages.Add(new MessageSegment
            {
                Depth = depth,
                SegmentName = text,
                MaxCount = count,
                Mandatory = mandatory,
            });
        }

        return messages;
    }

    public List<string> DownloadAllMessages(string version, string schemaName = "edifact")
    {
        string url = @$"https://www.stylusstudio.com/{schemaName}/{version}/messages.htm";

        var web = new HtmlWeb();
        var doc = web.Load(url);

        var trNodes = doc.DocumentNode.SelectNodes("//body//table//table[@border='1'][1]//tr");

        if (trNodes is null) return new List<string>();

        var messageNames = new List<string>();

        foreach(var trNode in trNodes)
        {
            var trDoc = new HtmlDocument();
            trDoc.LoadHtml(trNode.InnerHtml);
            var node = trDoc.DocumentNode.SelectSingleNode("//td/a[1]");
            string messageName = node.InnerText.Trim();
            messageNames.Add(messageName);
        }

        return messageNames;
    }

    public Dictionary<string, List<string>> DownloadAllVersions(string schemaName = "edifact")
    {
        var messageDictionary = new Dictionary<string, List<string>>();

        for(int i = 93; i <= 104; i++)
        {
            string year = (i % 100).ToString().PadLeft(2, '0');

            for(int j = 0; j <= 3; j++)
            {
                char revision = (char)('A' + j);
                string version = $"D{year}{revision}";
                var messages = DownloadAllMessages(version, schemaName);

                if(messages.Count == 0) continue;

                messageDictionary.Add(version, messages);
            }
        }

        return messageDictionary;
    }

    public void Download()
    {
        var versions = DownloadAllVersions();

        foreach (var (version, messages) in versions)
        {
            if(version is null || messages is null) continue;

            Console.WriteLine($"Downloading version {version}");

            var messageSchema = new MessageSchema();

            foreach (var message in messages)
            {
                var specification = DownloadMessageSpecification(version, message);

                if(specification is null) continue;

                messageSchema.Messages.Add(message, specification);
            }

            string json = JsonSerializer.Serialize(messageSchema, new JsonSerializerOptions
            {
                WriteIndented = true,
            });

            string dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "schemas", version);

            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            string filePath = Path.Combine(dirPath, "schema.json");

            File.WriteAllText(filePath, json);
        }
    }
}
