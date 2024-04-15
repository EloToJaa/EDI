using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CUSDEC
/// </summary>
[EdiMessage]
public class CUSDEC : IMessage
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
	/// Customs status of goods
	/// </summary>
	public CST? CustomsStatusOfGoodsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public FII? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Equipment details
	/// </summary>
	public List<EQD>? EquipmentDetailsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CUSDEC_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CUSDEC_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CUSDEC_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CUSDEC_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public CUSDEC_SG7? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<CUSDEC_SG8>? SG8C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControl1M { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<CUSDEC_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<CUSDEC_SG30>? SG30C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControl2M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG49
	/// </summary>
	public List<CUSDEC_SG49>? SG49C { get; set; }

	/// <summary>
	/// SG50
	/// </summary>
	public CUSDEC_SG50? SG50C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "PAC")]
public class CUSDEC_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CUSDEC_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("PAC", "PCI")]
public class CUSDEC_SG2 : PAC, ISegmentGroup
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<CUSDEC_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("PCI", "FTX")]
public class CUSDEC_SG3 : PCI, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("TDT", "TPL")]
public class CUSDEC_SG4 : TDT, ISegmentGroup
{
	/// <summary>
	/// Transport placement
	/// </summary>
	public TPL? TransportPlacementC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM", "LOC")]
public class CUSDEC_SG5 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("NAD", "RFF", "CTA", "COM")]
public class CUSDEC_SG6 : NAD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC", "FTX")]
public class CUSDEC_SG7 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("MOA", "CUX")]
public class CUSDEC_SG8 : MOA, ISegmentGroup
{
	/// <summary>
	/// SG9
	/// </summary>
	public CUSDEC_SG9? SG9C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class CUSDEC_SG9 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DMS", "DTM", "MEA", "MOA", "TOD", "NAD", "PAC", "PAT", "ALC", "LIN")]
public class CUSDEC_SG10 : DMS, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<CUSDEC_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public CUSDEC_SG13? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<CUSDEC_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<CUSDEC_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<CUSDEC_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<CUSDEC_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<CUSDEC_SG21>? SG21C { get; set; }

}

[EdiSegmentGroup("MOA", "CUX")]
public class CUSDEC_SG11 : MOA, ISegmentGroup
{
	/// <summary>
	/// SG12
	/// </summary>
	public CUSDEC_SG12? SG12C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class CUSDEC_SG12 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC", "FTX")]
public class CUSDEC_SG13 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("NAD", "DOC")]
public class CUSDEC_SG14 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG15
	/// </summary>
	public List<CUSDEC_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM", "LOC")]
public class CUSDEC_SG15 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("PAC", "PCI")]
public class CUSDEC_SG16 : PAC, ISegmentGroup
{
	/// <summary>
	/// SG17
	/// </summary>
	public List<CUSDEC_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("PCI", "FTX", "RFF")]
public class CUSDEC_SG17 : PCI, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }
}

[EdiSegmentGroup("PAT", "MOA", "PCD", "FTX")]
public class CUSDEC_SG18 : PAT, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("ALC", "RTE", "MOA", "PCD", "QTY", "CUX")]
public class CUSDEC_SG19 : ALC, ISegmentGroup
{
	/// <summary>
	/// Rate details
	/// </summary>
	public RTE? RateDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public CUSDEC_SG20? SG20C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class CUSDEC_SG20 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "QTY", "PRI", "PCD", "MEA", "QVR", "MOA", "NAD", "GIR", "DOC", "ALC", "TOD", "PAT", "IMD", "PAC")]
public class CUSDEC_SG21 : LIN, ISegmentGroup
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public PIA? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public List<PRI>? PriceDetailsC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Quantity variances
	/// </summary>
	public List<QVR>? QuantityVariancesC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<CUSDEC_SG22>? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<CUSDEC_SG23>? SG23C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public CUSDEC_SG25? SG25C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<CUSDEC_SG26>? SG26C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<CUSDEC_SG27>? SG27C { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<CUSDEC_SG28>? SG28C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM")]
public class CUSDEC_SG22 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("ALC", "RTE", "MOA", "PCD", "QTY", "CUX")]
public class CUSDEC_SG23 : ALC, ISegmentGroup
{
	/// <summary>
	/// Rate details
	/// </summary>
	public RTE? RateDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public CUSDEC_SG24? SG24C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class CUSDEC_SG24 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class CUSDEC_SG25 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("PAT", "MOA", "PCD", "FTX")]
public class CUSDEC_SG26 : PAT, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("IMD", "FTX")]
public class CUSDEC_SG27 : IMD, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("PAC", "PCI")]
public class CUSDEC_SG28 : PAC, ISegmentGroup
{
	/// <summary>
	/// SG29
	/// </summary>
	public List<CUSDEC_SG29>? SG29C { get; set; }

}

[EdiSegmentGroup("PCI", "FTX", "RFF")]
public class CUSDEC_SG29 : PCI, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }
}

[EdiSegmentGroup("CST", "FTX", "LOC", "DTM", "MEA", "NAD", "TDT", "PAC", "MOA", "RFF", "DOC", "TOD", "GDS", "GIS", "TAX", "QVR", "GIR")]
public class CUSDEC_SG30 : CST, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Details of transport
	/// </summary>
	public List<TDT>? DetailsOfTransportC { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<CUSDEC_SG31>? SG31C { get; set; }

	/// <summary>
	/// SG33
	/// </summary>
	public List<CUSDEC_SG33>? SG33C { get; set; }

	/// <summary>
	/// SG35
	/// </summary>
	public List<CUSDEC_SG35>? SG35C { get; set; }

	/// <summary>
	/// SG37
	/// </summary>
	public List<CUSDEC_SG37>? SG37C { get; set; }

	/// <summary>
	/// SG38
	/// </summary>
	public CUSDEC_SG38? SG38C { get; set; }

	/// <summary>
	/// SG39
	/// </summary>
	public CUSDEC_SG39? SG39C { get; set; }

	/// <summary>
	/// SG40
	/// </summary>
	public List<CUSDEC_SG40>? SG40C { get; set; }

	/// <summary>
	/// SG41
	/// </summary>
	public List<CUSDEC_SG41>? SG41C { get; set; }

	/// <summary>
	/// SG42
	/// </summary>
	public CUSDEC_SG42? SG42C { get; set; }

	/// <summary>
	/// SG44
	/// </summary>
	public List<CUSDEC_SG44>? SG44C { get; set; }

}

[EdiSegmentGroup("PAC", "PCI")]
public class CUSDEC_SG31 : PAC, ISegmentGroup
{
	/// <summary>
	/// SG32
	/// </summary>
	public List<CUSDEC_SG32>? SG32C { get; set; }

}

[EdiSegmentGroup("PCI", "FTX")]
public class CUSDEC_SG32 : PCI, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("MOA", "CUX")]
public class CUSDEC_SG33 : MOA, ISegmentGroup
{
	/// <summary>
	/// SG34
	/// </summary>
	public CUSDEC_SG34? SG34C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class CUSDEC_SG34 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "GIN", "MOA", "IMD")]
public class CUSDEC_SG35 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG36
	/// </summary>
	public CUSDEC_SG36? SG36C { get; set; }

}

[EdiSegmentGroup("IMD", "FTX")]
public class CUSDEC_SG36 : IMD, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM", "LOC", "NAD")]
public class CUSDEC_SG37 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC", "FTX")]
public class CUSDEC_SG38 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("GDS", "FTX")]
public class CUSDEC_SG39 : GDS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("GIS", "PCD", "DTM", "RFF")]
public class CUSDEC_SG40 : GIS, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "GIS")]
public class CUSDEC_SG41 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("QVR", "QTY", "RFF")]
public class CUSDEC_SG42 : QVR, ISegmentGroup
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// SG43
	/// </summary>
	public CUSDEC_SG43? SG43C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class CUSDEC_SG43 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIR", "GIS", "NAD", "MEA", "MOA", "TAX", "DOC")]
public class CUSDEC_SG44 : GIR, ISegmentGroup
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG45
	/// </summary>
	public List<CUSDEC_SG45>? SG45C { get; set; }

	/// <summary>
	/// SG47
	/// </summary>
	public List<CUSDEC_SG47>? SG47C { get; set; }

	/// <summary>
	/// SG48
	/// </summary>
	public List<CUSDEC_SG48>? SG48C { get; set; }

}

[EdiSegmentGroup("MOA", "CUX")]
public class CUSDEC_SG45 : MOA, ISegmentGroup
{
	/// <summary>
	/// SG46
	/// </summary>
	public CUSDEC_SG46? SG46C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class CUSDEC_SG46 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "GIS")]
public class CUSDEC_SG47 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM", "LOC")]
public class CUSDEC_SG48 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "GIS")]
public class CUSDEC_SG49 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class CUSDEC_SG50 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}