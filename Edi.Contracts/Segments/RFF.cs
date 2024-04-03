using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

[EdiSegment, EdiElement, EdiPath("RFF/0")]
public class RFF
{
    [EdiValue("X(3)", Path = "RFF/0/0")]
    public string? ReferenceQualifier { get; set; }

    [EdiValue("X(35)", Path = "RFF/0/1")]
    public string? ReferenceNumber { get; set; }
}
