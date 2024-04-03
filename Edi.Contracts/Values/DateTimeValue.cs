using indice.Edi.Serialization;
using System.Globalization;

namespace Edi.Contracts.Values;

[EdiElement]
public class DateTimeValue
{
    [EdiValue("9(6)", Path = "*/*/0")]
    public int Date { get; set; }

    [EdiValue("9(4)", Path = "*/*/1")]
    public int Time { get; set; }

    public DateTime DateTime => DateTime.ParseExact($"{Date}:{Time}", "ddMMyy:HHmm", CultureInfo.InvariantCulture);
}
