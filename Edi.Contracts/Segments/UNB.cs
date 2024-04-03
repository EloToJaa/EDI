using Edi.Contracts.Values;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

[EdiSegment, EdiPath("UNB")]
public class UNB
{
    [EdiPath("UNB/0")]
    public Syntax? Syntax { get; set; }

    [EdiPath("UNB/1")]
    public Manufacturer? Sender { get; set; }

    [EdiPath("UNB/2")]
    public Manufacturer? Recipient { get; set; }

    [EdiPath("UNB/3")]
    public DateTimeValue? DateOfPreparation { get; set; }

    [EdiValue("X(14)", Path = "UNB/4")]
    public string? InterchangeControlReference { get; set; }

    [EdiValue("X(14)", Path = "UNB/5")]
    public string? RecipientPassword { get; set; }

    [EdiValue("X(14)", Path = "UNB/6")]
    public string? ApplicationReference { get; set; }
}
