using Edi.Contracts.InterchangeSegments;

namespace Edi.Contracts.Interchanges;

public class Interchange<T>
{
    public required UNB InterchangeHeader { get; set; }
    public required T Invoice { get; set; }
    public required UNZ InterchangeTrailer { get; set; }
}
