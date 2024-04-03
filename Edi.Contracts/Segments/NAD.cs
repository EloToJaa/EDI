using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

[EdiSegment, EdiPath("NAD")]
public class NAD
{
    //public NADHeader? Header { get; set; }
    [EdiValue("X(3)", Path = "NAD/0/0")]
    public string? PartyQualifier { get; set; }

    [EdiValue("X(35)", Path = "NAD/0/1")]
    public string? PartyIdentification { get; set; }

    [EdiValue("X(3)", Path = "NAD/1/1")]
    public string? CodeListQualifier { get; set; }
}
