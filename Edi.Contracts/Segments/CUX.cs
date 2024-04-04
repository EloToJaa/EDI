using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

[EdiSegment, EdiPath("CUX")]
public class CUX
{
    [EdiValue("X(3)", Path = "CUX/0/0")]
    public string? CurrencyDetailsQualifier { get; set; }

    [EdiValue("X(3)", Path = "CUX/0/1")]
    public string? CurrencyCoded { get; set; }

    [EdiValue("X(3)", Path = "CUX/0/2")]
    public string? CurrencyQualifier { get; set; }
}
