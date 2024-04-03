using Edi.Contracts.Values;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

[EdiSegment, EdiPath("UNH")]
public class UNH
{
    [EdiValue("X(14)", Path = "UNH/0")]
    public string? MessageReferenceNumber { get; set; }

    [EdiPath("UNH/1")]
    public MessageType? MessageType { get; set; }
}
