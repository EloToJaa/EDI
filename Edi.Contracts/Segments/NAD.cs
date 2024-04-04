using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

[EdiSegment, EdiPath("NAD")]
public class NAD
{
    [EdiPath("NAD/0")]
    public NADHeader? Header { get; set; }

    [EdiValue("X(3)", Path = "NAD/1/0")]
    public string? CodeListQualifier { get; set; }
}

[EdiElement]
public class NADHeader
{
    [EdiValue("X(3)", Path = "*/*/0")]
    public string? PartyQualifier { get; set; }

    [EdiValue("X(35)", Path = "*/*/1")]
    public string? PartyIdentification { get; set; }
}
