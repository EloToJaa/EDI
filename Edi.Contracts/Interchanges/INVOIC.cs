using Edi.Contracts.Messages;

namespace Edi.Contracts.Interchanges;

public class INVOIC : Interchange
{
    public Invoice? Invoice { get; set; }
}
