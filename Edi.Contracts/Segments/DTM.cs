using indice.Edi.Serialization;
using System.Globalization;

namespace Edi.Contracts.Segments;

[EdiSegment, EdiPath("DTM/0")]
public class DTM
{
    [EdiValue("9(3)", Path = "DTM/0/0")]
    public int DateTimePeriodQualifier { get; set; }

    [EdiValue("X(35)", Path = "DTM/0/1", Format = "yyyyMMdd")]
    public string? DateTimeText { get; set; }

    [EdiValue("9(3)", Path = "DTM/0/2")]
    public int DateTimeFormatCode { get; set; }

    public DateTime? DateTime
    {
        get
        {
            if (DateTimeText is null) return null;
            string dateFormat = DateTimeFormatCode switch
            {
                102 => "yyyyMMdd",
                _ => "yyyyMMddHHmm"
            };
            return System.DateTime.ParseExact(DateTimeText, dateFormat, CultureInfo.InvariantCulture);
        }
    }
}
