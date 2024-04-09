using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// ITRRPT
/// </summary>
[EdiMessage]
public class ITRRPT
{
	/// <summary>
	/// Message header
	/// </summary>
	public UNH? MessageHeaderM { get; set; }

	/// <summary>
	/// Beginning of message
	/// </summary>
	public BGM? BeginningOfMessageM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? Measurements1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<ITRRPT_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<ITRRPT_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<ITRRPT_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<ITRRPT_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<ITRRPT_SG9>? SG9M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public CNT? ControlTotalC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class ITRRPT_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class ITRRPT_SG2 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<ITRRPT_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<ITRRPT_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class ITRRPT_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class ITRRPT_SG4 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "PCD", "LOC")]
public class ITRRPT_SG5 : TDT
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<ITRRPT_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class ITRRPT_SG6 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQD", "MEA", "SEL", "EQA", "PCD", "HAN")]
public class ITRRPT_SG7 : EQD
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Attached equipment
	/// </summary>
	public List<EQA>? AttachedEquipmentC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<ITRRPT_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("HAN", "FTX")]
public class ITRRPT_SG8 : HAN
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("GIS", "CDI", "DTM", "ALI", "MEA", "MOA", "RFF", "NAD", "TOD", "CPS")]
public class ITRRPT_SG9 : GIS
{
	/// <summary>
	/// Physical or logical state
	/// </summary>
	public CDI? PhysicalOrLogicalStateC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<ITRRPT_SG10>? SG10M { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<ITRRPT_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<ITRRPT_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<ITRRPT_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class ITRRPT_SG10 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class ITRRPT_SG11 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<ITRRPT_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<ITRRPT_SG13>? SG13C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class ITRRPT_SG12 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class ITRRPT_SG13 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC", "FTX")]
public class ITRRPT_SG14 : TOD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("CPS", "FTX", "PAC", "LIN")]
public class ITRRPT_SG15 : CPS
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<ITRRPT_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public ITRRPT_SG20? SG20C { get; set; }

}

[EdiSegmentGroup("PAC", "MEA", "QTY", "HAN", "PCI")]
public class ITRRPT_SG16 : PAC
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<ITRRPT_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<ITRRPT_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("HAN", "FTX")]
public class ITRRPT_SG17 : HAN
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("PCI", "RFF", "CDI", "DTM", "GIN")]
public class ITRRPT_SG18 : PCI
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Physical or logical state
	/// </summary>
	public CDI? PhysicalOrLogicalStateC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<ITRRPT_SG19>? SG19C { get; set; }

}

[EdiSegmentGroup("GIN", "CDI", "DLM")]
public class ITRRPT_SG19 : GIN
{
	/// <summary>
	/// Physical or logical state
	/// </summary>
	public CDI? PhysicalOrLogicalStateC { get; set; }

	/// <summary>
	/// Delivery limitations
	/// </summary>
	public List<DLM>? DeliveryLimitationsC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "MEA", "CDI", "QTY", "ALI", "GIN", "GIR", "DTM", "MOA", "FTX", "RFF", "DGS", "PCI")]
public class ITRRPT_SG20 : LIN
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Physical or logical state
	/// </summary>
	public CDI? PhysicalOrLogicalStateC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<ITRRPT_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<ITRRPT_SG22>? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<ITRRPT_SG23>? SG23C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class ITRRPT_SG21 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DGS", "QTY", "FTX")]
public class ITRRPT_SG22 : DGS
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("PCI", "CDI", "DTM", "QTY", "MEA", "GIN", "HAN")]
public class ITRRPT_SG23 : PCI
{
	/// <summary>
	/// Physical or logical state
	/// </summary>
	public CDI? PhysicalOrLogicalStateC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<ITRRPT_SG24>? SG24C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<ITRRPT_SG25>? SG25C { get; set; }

}

[EdiSegmentGroup("GIN", "CDI", "DLM")]
public class ITRRPT_SG24 : GIN
{
	/// <summary>
	/// Physical or logical state
	/// </summary>
	public CDI? PhysicalOrLogicalStateC { get; set; }

	/// <summary>
	/// Delivery limitations
	/// </summary>
	public List<DLM>? DeliveryLimitationsC { get; set; }
}

[EdiSegmentGroup("HAN", "FTX", "GIN")]
public class ITRRPT_SG25 : HAN
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }
}