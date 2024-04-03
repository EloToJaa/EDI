using indice.Edi.Serialization;

namespace Edi.Contracts.Values;

[EdiElement]
public class Manufacturer
{
    [EdiValue("X(35)", Path = "*/*/0")]
    public string? Identifier { get; set; }

    [EdiValue("X(4)", Path = "*/*/1")]
    public string? CodeQualifier { get; set; }
}
