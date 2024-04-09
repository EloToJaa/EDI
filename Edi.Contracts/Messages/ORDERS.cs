using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// ORDERS
/// </summary>
[EdiMessage]
public class ORDERS
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
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructions1C { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformation1C { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescription1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<ORDERS_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<ORDERS_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<ORDERS_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<ORDERS_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<ORDERS_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<ORDERS_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<ORDERS_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<ORDERS_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<ORDERS_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<ORDERS_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<ORDERS_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<ORDERS_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<ORDERS_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<ORDERS_SG26>? SG26C { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<ORDERS_SG28>? SG28C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmount1C { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG60
	/// </summary>
	public List<ORDERS_SG60>? SG60C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class ORDERS_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FII", "RFF", "DOC", "CTA")]
public class ORDERS_SG2 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<ORDERS_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<ORDERS_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<ORDERS_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class ORDERS_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class ORDERS_SG4 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class ORDERS_SG5 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class ORDERS_SG6 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("CUX", "PCD", "DTM")]
public class ORDERS_SG7 : CUX
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAT", "DTM", "PCD", "MOA")]
public class ORDERS_SG8 : PAT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<ORDERS_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("MOA", "GIR")]
public class ORDERS_SG9 : MOA
{
	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC")]
public class ORDERS_SG10 : TDT
{
	/// <summary>
	/// SG11
	/// </summary>
	public List<ORDERS_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class ORDERS_SG11 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class ORDERS_SG12 : TOD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("PAC", "MEA", "PCI")]
public class ORDERS_SG13 : PAC
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<ORDERS_SG14>? SG14C { get; set; }

}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIN")]
public class ORDERS_SG14 : PCI
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }
}

[EdiSegmentGroup("EQD", "HAN", "MEA", "FTX")]
public class ORDERS_SG15 : EQD
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("SCC", "FTX", "RFF", "QTY")]
public class ORDERS_SG16 : SCC
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<ORDERS_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("QTY", "DTM")]
public class ORDERS_SG17 : QTY
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("APR", "DTM", "RNG")]
public class ORDERS_SG18 : APR
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "DTM", "QTY", "PCD", "MOA", "RTE", "TAX")]
public class ORDERS_SG19 : ALC
{
	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public ORDERS_SG20? SG20C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public ORDERS_SG21? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<ORDERS_SG22>? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public ORDERS_SG23? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<ORDERS_SG24>? SG24C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class ORDERS_SG20 : QTY
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class ORDERS_SG21 : PCD
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class ORDERS_SG22 : MOA
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class ORDERS_SG23 : RTE
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA")]
public class ORDERS_SG24 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("RCS", "RFF", "DTM", "FTX")]
public class ORDERS_SG25 : RCS
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "CTA")]
public class ORDERS_SG26 : DGS
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<ORDERS_SG27>? SG27C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class ORDERS_SG27 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "MEA", "QTY", "PCD", "ALI", "DTM", "MOA", "GIN", "GIR", "QVR", "DOC", "PAI", "FTX", "CCI", "PAT", "PRI", "RFF", "PAC", "LOC", "TAX", "NAD", "ALC", "TDT", "TOD", "EQD", "SCC", "RCS", "STG", "DGS")]
public class ORDERS_SG28 : LIN
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
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }

	/// <summary>
	/// Quantity variances
	/// </summary>
	public QVR? QuantityVariancesC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<ORDERS_SG29>? SG29C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<ORDERS_SG30>? SG30C { get; set; }

	/// <summary>
	/// SG32
	/// </summary>
	public List<ORDERS_SG32>? SG32C { get; set; }

	/// <summary>
	/// SG33
	/// </summary>
	public List<ORDERS_SG33>? SG33C { get; set; }

	/// <summary>
	/// SG34
	/// </summary>
	public List<ORDERS_SG34>? SG34C { get; set; }

	/// <summary>
	/// SG37
	/// </summary>
	public List<ORDERS_SG37>? SG37C { get; set; }

	/// <summary>
	/// SG38
	/// </summary>
	public List<ORDERS_SG38>? SG38C { get; set; }

	/// <summary>
	/// SG39
	/// </summary>
	public List<ORDERS_SG39>? SG39C { get; set; }

	/// <summary>
	/// SG43
	/// </summary>
	public List<ORDERS_SG43>? SG43C { get; set; }

	/// <summary>
	/// SG49
	/// </summary>
	public List<ORDERS_SG49>? SG49C { get; set; }

	/// <summary>
	/// SG51
	/// </summary>
	public List<ORDERS_SG51>? SG51C { get; set; }

	/// <summary>
	/// SG52
	/// </summary>
	public List<ORDERS_SG52>? SG52C { get; set; }

	/// <summary>
	/// SG53
	/// </summary>
	public List<ORDERS_SG53>? SG53C { get; set; }

	/// <summary>
	/// SG55
	/// </summary>
	public List<ORDERS_SG55>? SG55C { get; set; }

	/// <summary>
	/// SG56
	/// </summary>
	public List<ORDERS_SG56>? SG56C { get; set; }

	/// <summary>
	/// SG58
	/// </summary>
	public List<ORDERS_SG58>? SG58C { get; set; }

}

[EdiSegmentGroup("CCI", "CAV", "MEA")]
public class ORDERS_SG29 : CCI
{
	/// <summary>
	/// Characteristic value
	/// </summary>
	public List<CAV>? CharacteristicValueC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("PAT", "DTM", "PCD", "MOA")]
public class ORDERS_SG30 : PAT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<ORDERS_SG31>? SG31C { get; set; }

}

[EdiSegmentGroup("MOA", "GIR")]
public class ORDERS_SG31 : MOA
{
	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }
}

[EdiSegmentGroup("PRI", "CUX", "APR", "RNG", "DTM")]
public class ORDERS_SG32 : PRI
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Additional price information
	/// </summary>
	public APR? AdditionalPriceInformationC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class ORDERS_SG33 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAC", "MEA", "QTY", "DTM", "RFF", "PCI")]
public class ORDERS_SG34 : PAC
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
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG35
	/// </summary>
	public ORDERS_SG35? SG35C { get; set; }

	/// <summary>
	/// SG36
	/// </summary>
	public List<ORDERS_SG36>? SG36C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class ORDERS_SG35 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIN")]
public class ORDERS_SG36 : PCI
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }
}

[EdiSegmentGroup("LOC", "QTY", "PCD", "DTM")]
public class ORDERS_SG37 : LOC
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class ORDERS_SG38 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "DOC", "CTA")]
public class ORDERS_SG39 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG40
	/// </summary>
	public List<ORDERS_SG40>? SG40C { get; set; }

	/// <summary>
	/// SG41
	/// </summary>
	public List<ORDERS_SG41>? SG41C { get; set; }

	/// <summary>
	/// SG42
	/// </summary>
	public List<ORDERS_SG42>? SG42C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class ORDERS_SG40 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class ORDERS_SG41 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class ORDERS_SG42 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "DTM", "QTY", "PCD", "MOA", "RTE", "TAX")]
public class ORDERS_SG43 : ALC
{
	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG44
	/// </summary>
	public ORDERS_SG44? SG44C { get; set; }

	/// <summary>
	/// SG45
	/// </summary>
	public ORDERS_SG45? SG45C { get; set; }

	/// <summary>
	/// SG46
	/// </summary>
	public List<ORDERS_SG46>? SG46C { get; set; }

	/// <summary>
	/// SG47
	/// </summary>
	public ORDERS_SG47? SG47C { get; set; }

	/// <summary>
	/// SG48
	/// </summary>
	public List<ORDERS_SG48>? SG48C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class ORDERS_SG44 : QTY
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class ORDERS_SG45 : PCD
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class ORDERS_SG46 : MOA
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class ORDERS_SG47 : RTE
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA")]
public class ORDERS_SG48 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC")]
public class ORDERS_SG49 : TDT
{
	/// <summary>
	/// SG50
	/// </summary>
	public List<ORDERS_SG50>? SG50C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class ORDERS_SG50 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class ORDERS_SG51 : TOD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("EQD", "HAN", "MEA", "FTX")]
public class ORDERS_SG52 : EQD
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("SCC", "FTX", "RFF", "QTY")]
public class ORDERS_SG53 : SCC
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG54
	/// </summary>
	public List<ORDERS_SG54>? SG54C { get; set; }

}

[EdiSegmentGroup("QTY", "DTM")]
public class ORDERS_SG54 : QTY
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RCS", "RFF", "DTM", "FTX")]
public class ORDERS_SG55 : RCS
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("STG", "QTY")]
public class ORDERS_SG56 : STG
{
	/// <summary>
	/// SG57
	/// </summary>
	public List<ORDERS_SG57>? SG57C { get; set; }

}

[EdiSegmentGroup("QTY", "MOA")]
public class ORDERS_SG57 : QTY
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "CTA")]
public class ORDERS_SG58 : DGS
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG59
	/// </summary>
	public List<ORDERS_SG59>? SG59C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class ORDERS_SG59 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "MOA")]
public class ORDERS_SG60 : ALC
{
	/// <summary>
	/// Additional information
	/// </summary>
	public ALI? AdditionalInformationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountM { get; set; }
}