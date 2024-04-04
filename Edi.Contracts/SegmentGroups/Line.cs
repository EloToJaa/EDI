using indice.Edi.Serialization;

namespace Edi.Contracts.SegmentGroups;

[EdiSegmentGroup("LIN", SequenceEnd = "UNS")]
public class Line
{
    [EdiValue("9(6)", Path = "LIN/0")]
    public int? LineItemNumber { get; set; }

    [EdiValue("X(3)", Path = "LIN/1")]
    public string? CodedActionRequest { get; set; }

    [EdiValue("X(35)", Path = "LIN/2/0")]
    public string? ItemNumber { get; set; }

    [EdiValue("X(3)", Path = "LIN/2/1")]
    public string? CodedItemNumberType { get; set; }

    [EdiValue("X(3)", Path = "LIN/2/2")]
    public string? ListQualifierCode { get; set; }

    [EdiValue("X(3)", Path = "LIN/2/3")]
    public string? ResponsibleAgencyCode { get; set; }
}
