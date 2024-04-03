using indice.Edi.Serialization;

namespace Edi.Contracts.Values;

[EdiElement]
public class Syntax
{
    [EdiValue("X(4)", Path = "*/*/0")]
    public string? SyntaxIdentifier { get; set; }

    [EdiValue("9(1)", Path = "*/*/1")]
    public int SyntaxVersion { get; set; }
}
