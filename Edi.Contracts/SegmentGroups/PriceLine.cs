using Edi.Contracts.Qualifiers;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.SegmentGroups;

[EdiSegmentGroup("LIN", SequenceEnd = "UNS")]
public class PriceLine : LIN
{
    public PIA? ProductId { get; set; }
    public IMD? ItemDescription { get; set; }
    public QTY? InvoicedQuantity { get; set; }
    public ALI? AdditionalInformation { get; set; }
    public MOA? MoneteryAmount { get; set; }
    public PRI? CalculationGross { get; set; }

    [EdiCondition("LI", Path = "RFF/0/0")]
    public RFF? LineItem { get; set; }

    [EdiCondition("DQ", Path = "RFF/0/0")]
    public RFF? DeliveryNoteNumber { get; set; }

    [EdiCondition("VN", Path = "RFF/0/0")]
    public RFF? VendorOrder { get; set; }

    [EdiCondition("ON", Path = "RFF/0/0")]
    public RFF? PurchaseOrder { get; set; }
}
