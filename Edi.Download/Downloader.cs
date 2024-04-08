using HtmlAgilityPack;

namespace Edi.Download;

public class Downloader
{
    public void DownloadMessageSpecification()
    {
        string url = @"https://www.stylusstudio.com/edifact/D97A/INVOIC.htm";

        HtmlWeb web = new HtmlWeb();
        var doc = web.Load(url);

        //var trNodes = doc.DocumentNode.SelectNodes("//body//table//table[@border='0']//tr/td[1]/a | //body//table//table[@border='0']//tr/td[1]/span");
        var trNodes = doc.DocumentNode.SelectNodes("//body//table//table[@border='0']//tr");

        foreach (var trNode in trNodes)
        {
            var nodes = trNode.SelectNodes("//td[1]/span | //td[1]/a");

            foreach(var node in nodes)
            {
                Console.WriteLine(trNode.InnerText);
                Console.WriteLine(trNode.InnerText.ToCharArray().Where(c => c == '─').Count());
            }

        }
    }
}
