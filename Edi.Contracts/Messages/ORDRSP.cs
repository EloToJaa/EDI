using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// ORDRSP
/// </summary>
[EdiMessage]
public class ORDRSP : IMessage
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
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructionsC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public IMD? ItemDescriptionC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<ORDRSP_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public ORDRSP_SG2? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<ORDRSP_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<ORDRSP_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<ORDRSP_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<ORDRSP_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<ORDRSP_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<ORDRSP_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<ORDRSP_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<ORDRSP_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<ORDRSP_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<ORDRSP_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<ORDRSP_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<ORDRSP_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<ORDRSP_SG26>? SG26C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG56
	/// </summary>
	public List<ORDRSP_SG56>? SG56C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class ORDRSP_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "FTX")]
public class ORDRSP_SG2 : AJT, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FII", "RFF", "DOC", "CTA")]
public class ORDRSP_SG3 : NAD, ISegmentGroup
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
	/// SG4
	/// </summary>
	public List<ORDRSP_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<ORDRSP_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<ORDRSP_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class ORDRSP_SG4 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class ORDRSP_SG5 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class ORDRSP_SG6 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class ORDRSP_SG7 : TAX, ISegmentGroup
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
public class ORDRSP_SG8 : CUX, ISegmentGroup
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
public class ORDRSP_SG9 : PAT, ISegmentGroup
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
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC")]
public class ORDRSP_SG10 : TDT, ISegmentGroup
{
	/// <summary>
	/// SG11
	/// </summary>
	public List<ORDRSP_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class ORDRSP_SG11 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class ORDRSP_SG12 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("PAC", "MEA", "PCI")]
public class ORDRSP_SG13 : PAC, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<ORDRSP_SG14>? SG14C { get; set; }

}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIN")]
public class ORDRSP_SG14 : PCI, ISegmentGroup
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
public class ORDRSP_SG15 : EQD, ISegmentGroup
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
public class ORDRSP_SG16 : SCC, ISegmentGroup
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
	public List<ORDRSP_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("QTY", "DTM")]
public class ORDRSP_SG17 : QTY, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("APR", "DTM", "RNG")]
public class ORDRSP_SG18 : APR, ISegmentGroup
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
public class ORDRSP_SG19 : ALC, ISegmentGroup
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
	public ORDRSP_SG20? SG20C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public ORDRSP_SG21? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<ORDRSP_SG22>? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public ORDRSP_SG23? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<ORDRSP_SG24>? SG24C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class ORDRSP_SG20 : QTY, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class ORDRSP_SG21 : PCD, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class ORDRSP_SG22 : MOA, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class ORDRSP_SG23 : RTE, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA")]
public class ORDRSP_SG24 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("RCS", "RFF", "DTM", "FTX")]
public class ORDRSP_SG25 : RCS, ISegmentGroup
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

[EdiSegmentGroup("LIN", "PIA", "IMD", "MEA", "QTY", "PCD", "ALI", "DTM", "MOA", "GIN", "GIR", "QVR", "DOC", "PAI", "FTX", "CCI", "PAT", "AJT", "PRI", "RFF", "PAC", "LOC", "TAX", "NAD", "ALC", "TDT", "TOD", "EQD", "SCC", "RCS", "STG")]
public class ORDRSP_SG26 : LIN, ISegmentGroup
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
	/// SG27
	/// </summary>
	public List<ORDRSP_SG27>? SG27C { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<ORDRSP_SG28>? SG28C { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public ORDRSP_SG29? SG29C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<ORDRSP_SG30>? SG30C { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<ORDRSP_SG31>? SG31C { get; set; }

	/// <summary>
	/// SG32
	/// </summary>
	public List<ORDRSP_SG32>? SG32C { get; set; }

	/// <summary>
	/// SG35
	/// </summary>
	public List<ORDRSP_SG35>? SG35C { get; set; }

	/// <summary>
	/// SG36
	/// </summary>
	public List<ORDRSP_SG36>? SG36C { get; set; }

	/// <summary>
	/// SG37
	/// </summary>
	public List<ORDRSP_SG37>? SG37C { get; set; }

	/// <summary>
	/// SG41
	/// </summary>
	public List<ORDRSP_SG41>? SG41C { get; set; }

	/// <summary>
	/// SG47
	/// </summary>
	public List<ORDRSP_SG47>? SG47C { get; set; }

	/// <summary>
	/// SG49
	/// </summary>
	public List<ORDRSP_SG49>? SG49C { get; set; }

	/// <summary>
	/// SG50
	/// </summary>
	public List<ORDRSP_SG50>? SG50C { get; set; }

	/// <summary>
	/// SG51
	/// </summary>
	public List<ORDRSP_SG51>? SG51C { get; set; }

	/// <summary>
	/// SG53
	/// </summary>
	public List<ORDRSP_SG53>? SG53C { get; set; }

	/// <summary>
	/// SG54
	/// </summary>
	public List<ORDRSP_SG54>? SG54C { get; set; }

}

[EdiSegmentGroup("CCI", "CAV", "MEA")]
public class ORDRSP_SG27 : CCI, ISegmentGroup
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
public class ORDRSP_SG28 : PAT, ISegmentGroup
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
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("AJT", "FTX")]
public class ORDRSP_SG29 : AJT, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("PRI", "CUX", "APR", "RNG", "DTM")]
public class ORDRSP_SG30 : PRI, ISegmentGroup
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
public class ORDRSP_SG31 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAC", "MEA", "QTY", "DTM", "RFF", "PCI")]
public class ORDRSP_SG32 : PAC, ISegmentGroup
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
	/// SG33
	/// </summary>
	public ORDRSP_SG33? SG33C { get; set; }

	/// <summary>
	/// SG34
	/// </summary>
	public List<ORDRSP_SG34>? SG34C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class ORDRSP_SG33 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIN")]
public class ORDRSP_SG34 : PCI, ISegmentGroup
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
public class ORDRSP_SG35 : LOC, ISegmentGroup
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
public class ORDRSP_SG36 : TAX, ISegmentGroup
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
public class ORDRSP_SG37 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG38
	/// </summary>
	public List<ORDRSP_SG38>? SG38C { get; set; }

	/// <summary>
	/// SG39
	/// </summary>
	public List<ORDRSP_SG39>? SG39C { get; set; }

	/// <summary>
	/// SG40
	/// </summary>
	public List<ORDRSP_SG40>? SG40C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class ORDRSP_SG38 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class ORDRSP_SG39 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class ORDRSP_SG40 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "DTM", "QTY", "PCD", "MOA", "RTE", "TAX")]
public class ORDRSP_SG41 : ALC, ISegmentGroup
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
	/// SG42
	/// </summary>
	public ORDRSP_SG42? SG42C { get; set; }

	/// <summary>
	/// SG43
	/// </summary>
	public ORDRSP_SG43? SG43C { get; set; }

	/// <summary>
	/// SG44
	/// </summary>
	public List<ORDRSP_SG44>? SG44C { get; set; }

	/// <summary>
	/// SG45
	/// </summary>
	public ORDRSP_SG45? SG45C { get; set; }

	/// <summary>
	/// SG46
	/// </summary>
	public List<ORDRSP_SG46>? SG46C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class ORDRSP_SG42 : QTY, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class ORDRSP_SG43 : PCD, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class ORDRSP_SG44 : MOA, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class ORDRSP_SG45 : RTE, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA")]
public class ORDRSP_SG46 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC")]
public class ORDRSP_SG47 : TDT, ISegmentGroup
{
	/// <summary>
	/// SG48
	/// </summary>
	public List<ORDRSP_SG48>? SG48C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class ORDRSP_SG48 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class ORDRSP_SG49 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("EQD", "HAN", "MEA", "FTX")]
public class ORDRSP_SG50 : EQD, ISegmentGroup
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
public class ORDRSP_SG51 : SCC, ISegmentGroup
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
	/// SG52
	/// </summary>
	public List<ORDRSP_SG52>? SG52C { get; set; }

}

[EdiSegmentGroup("QTY", "DTM")]
public class ORDRSP_SG52 : QTY, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RCS", "RFF", "DTM", "FTX")]
public class ORDRSP_SG53 : RCS, ISegmentGroup
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
public class ORDRSP_SG54 : STG, ISegmentGroup
{
	/// <summary>
	/// SG55
	/// </summary>
	public List<ORDRSP_SG55>? SG55C { get; set; }

}

[EdiSegmentGroup("QTY", "MOA")]
public class ORDRSP_SG55 : QTY, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "MOA")]
public class ORDRSP_SG56 : ALC, ISegmentGroup
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