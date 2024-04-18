using Edi.Contracts.InterchangeSegments;
using Edi.Contracts.Interfaces;

namespace Edi.Contracts.Interchanges;

public class Interchange<T>
    where T : IMessage
{
    public required UNB InterchangeHeader { get; set; }
    public required List<T> Messages { get; set; }
    public required UNZ InterchangeTrailer { get; set; }
}
