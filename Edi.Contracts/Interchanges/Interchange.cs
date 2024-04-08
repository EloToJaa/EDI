using Edi.Contracts.InterchangeSegments;

namespace Edi.Contracts.Interchanges;

public class Interchange
{
    public UNB? InterchangeHeader { get; set; }
    public UNZ? InterchangeTrailer { get; set; }
}
