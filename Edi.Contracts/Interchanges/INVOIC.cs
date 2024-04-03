using Edi.Contracts.Segments;

namespace Edi.Contracts.Interchanges;

public class INVOIC
{
    public UNB? InterchangeHeader { get; set; }
    public UNH? MessageHeader { get; set; }
}
