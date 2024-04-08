using Edi.Contracts.SegmentGroups;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

[EdiMessage]
public class Invoice
{
    public UNH? MessageHeader { get; set; }
    public BGM? BeginningOfMessage { get; set; }

    [EdiCondition("137", Path = "DTM/0/0")]
    public DTM? DocumentDateTime { get; set; }

    [EdiCondition("IV", Path = "RFF/0/0")]
    public RFF? InvoiceNumber { get; set; }

    [EdiCondition("DQ", Path = "RFF/0/0")]
    public RFF? DeliveryNoteNumber { get; set; }

    [EdiCondition("VN", Path = "RFF/0/0")]
    public Order? VendorOrder { get; set; }

    [EdiCondition("ON", Path = "RFF/0/0")]
    public Order? PurchaseOrder { get; set; }

    [EdiCondition("SE", Path = "NAD/0/0")]
    public Address? Seller { get; set; }

    [EdiCondition("IV", Path = "NAD/0/0")]
    public Address? Invoicee { get; set; }

    [EdiCondition("DP", Path = "NAD/0/0")]
    public Address? DeliveryParty { get; set; }

    public CUX? Currency { get; set; }

    public List<PriceLine> PriceLines { get; set; } = new List<PriceLine>();

    public UNS? Separator { get; set; }

    [EdiCondition("79", Path = "MOA/0/0")]
    public MonetaryAmount? TotalLineItemsAmount { get; set; }

    [EdiCondition("86", Path = "MOA/0/0")]
    public MonetaryAmount? MessageTotalMonetaryAmount { get; set; }

    [EdiCondition("176", Path = "MOA/0/0")]
    public MonetaryAmount? MessageTotalDutyTaxFeeAmount { get; set; }

    public UNT? MessageTrailer { get; set; }
}
