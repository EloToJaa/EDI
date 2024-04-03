using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

[EdiSegment, EdiPath("BGM")]
public class BGM
{
    [EdiValue("X(3)", Path = "BGM/0")]
    public string? DocumentNameCode { get; set; }

    [EdiValue("X(35)", Path = "BGM/1")]
    public string? DocumentMessageNumber { get; set; }
}
