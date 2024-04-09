using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// REQOTE
/// </summary>
[EdiMessage]
public class REQOTE
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
	public IMD? ItemDescription1C { get; set; }

	/// <summary>
	/// Information required
	/// </summary>
	public List<IRQ>? InformationRequiredC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<REQOTE_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public REQOTE_SG2? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<REQOTE_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<REQOTE_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<REQOTE_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<REQOTE_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<REQOTE_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<REQOTE_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<REQOTE_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public REQOTE_SG10? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<REQOTE_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<REQOTE_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<REQOTE_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<REQOTE_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<REQOTE_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<REQOTE_SG27>? SG27M { get; set; }

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
	/// SG56
	/// </summary>
	public List<REQOTE_SG56>? SG56C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class REQOTE_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "FTX")]
public class REQOTE_SG2 : AJT
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class REQOTE_SG3 : TAX
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

[EdiSegmentGroup("CUX", "DTM")]
public class REQOTE_SG4 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAT", "DTM", "PCD", "MOA")]
public class REQOTE_SG5 : PAT
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

[EdiSegmentGroup("TOD", "LOC")]
public class REQOTE_SG6 : TOD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("EQD", "HAN", "MEA", "FTX")]
public class REQOTE_SG7 : EQD
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

[EdiSegmentGroup("RCS", "RFF", "DTM", "FTX")]
public class REQOTE_SG8 : RCS
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

[EdiSegmentGroup("APR", "PRI", "QTY", "DTM", "MOA", "RNG")]
public class REQOTE_SG9 : APR
{
	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public List<RNG>? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("DLM", "MOA", "DTM")]
public class REQOTE_SG10 : DLM
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FII", "RFF", "DOC", "CTA")]
public class REQOTE_SG11 : NAD
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
	/// SG12
	/// </summary>
	public List<REQOTE_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<REQOTE_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<REQOTE_SG14>? SG14C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class REQOTE_SG12 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class REQOTE_SG13 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class REQOTE_SG14 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "QTY", "LOC")]
public class REQOTE_SG15 : TDT
{
	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<REQOTE_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class REQOTE_SG16 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAC", "MEA", "PCI")]
public class REQOTE_SG17 : PAC
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<REQOTE_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIN")]
public class REQOTE_SG18 : PCI
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

[EdiSegmentGroup("SCC", "FTX", "QTY")]
public class REQOTE_SG19 : SCC
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<REQOTE_SG20>? SG20C { get; set; }

}

[EdiSegmentGroup("QTY", "DTM")]
public class REQOTE_SG20 : QTY
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "QTY", "PCD", "MOA", "RTE", "TAX")]
public class REQOTE_SG21 : ALC
{
	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public REQOTE_SG22? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public REQOTE_SG23? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<REQOTE_SG24>? SG24C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public REQOTE_SG25? SG25C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<REQOTE_SG26>? SG26C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class REQOTE_SG22 : QTY
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class REQOTE_SG23 : PCD
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class REQOTE_SG24 : MOA
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class REQOTE_SG25 : RTE
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA")]
public class REQOTE_SG26 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "MEA", "QTY", "PCD", "ALI", "DTM", "GIN", "GIR", "QVR", "FTX", "PAI", "DOC", "CCI", "MOA", "AJT", "PRI", "RFF", "LOC", "TAX", "TOD", "EQD", "RCS", "PAT", "PAC", "NAD", "ALC", "TDT", "SCC")]
public class REQOTE_SG27 : LIN
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
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

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
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructionsC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public DOC? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<REQOTE_SG28>? SG28C { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<REQOTE_SG29>? SG29C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public REQOTE_SG30? SG30C { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<REQOTE_SG31>? SG31C { get; set; }

	/// <summary>
	/// SG32
	/// </summary>
	public List<REQOTE_SG32>? SG32C { get; set; }

	/// <summary>
	/// SG33
	/// </summary>
	public List<REQOTE_SG33>? SG33C { get; set; }

	/// <summary>
	/// SG34
	/// </summary>
	public List<REQOTE_SG34>? SG34C { get; set; }

	/// <summary>
	/// SG35
	/// </summary>
	public List<REQOTE_SG35>? SG35C { get; set; }

	/// <summary>
	/// SG36
	/// </summary>
	public List<REQOTE_SG36>? SG36C { get; set; }

	/// <summary>
	/// SG37
	/// </summary>
	public List<REQOTE_SG37>? SG37C { get; set; }

	/// <summary>
	/// SG38
	/// </summary>
	public List<REQOTE_SG38>? SG38C { get; set; }

	/// <summary>
	/// SG39
	/// </summary>
	public List<REQOTE_SG39>? SG39C { get; set; }

	/// <summary>
	/// SG42
	/// </summary>
	public List<REQOTE_SG42>? SG42C { get; set; }

	/// <summary>
	/// SG46
	/// </summary>
	public List<REQOTE_SG46>? SG46C { get; set; }

	/// <summary>
	/// SG52
	/// </summary>
	public List<REQOTE_SG52>? SG52C { get; set; }

	/// <summary>
	/// SG54
	/// </summary>
	public List<REQOTE_SG54>? SG54C { get; set; }

}

[EdiSegmentGroup("CCI", "CAV", "MEA")]
public class REQOTE_SG28 : CCI
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

[EdiSegmentGroup("MOA", "QTY", "IMD", "CUX", "DTM")]
public class REQOTE_SG29 : MOA
{
	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public IMD? ItemDescriptionC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "FTX")]
public class REQOTE_SG30 : AJT
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("PRI", "APR", "RNG", "CUX", "DTM")]
public class REQOTE_SG31 : PRI
{
	/// <summary>
	/// Additional price information
	/// </summary>
	public APR? AdditionalPriceInformationC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class REQOTE_SG32 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LOC", "QTY", "DTM")]
public class REQOTE_SG33 : LOC
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class REQOTE_SG34 : TAX
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

[EdiSegmentGroup("TOD", "LOC")]
public class REQOTE_SG35 : TOD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("EQD", "HAN", "MEA", "FTX")]
public class REQOTE_SG36 : EQD
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

[EdiSegmentGroup("RCS", "RFF", "DTM", "FTX")]
public class REQOTE_SG37 : RCS
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

[EdiSegmentGroup("PAT", "DTM", "PCD", "MOA")]
public class REQOTE_SG38 : PAT
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

[EdiSegmentGroup("PAC", "MEA", "QTY", "DTM", "RFF", "PCI")]
public class REQOTE_SG39 : PAC
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
	/// SG40
	/// </summary>
	public List<REQOTE_SG40>? SG40C { get; set; }

	/// <summary>
	/// SG41
	/// </summary>
	public List<REQOTE_SG41>? SG41C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class REQOTE_SG40 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIN")]
public class REQOTE_SG41 : PCI
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

[EdiSegmentGroup("NAD", "LOC", "RFF", "DOC", "CTA")]
public class REQOTE_SG42 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG43
	/// </summary>
	public List<REQOTE_SG43>? SG43C { get; set; }

	/// <summary>
	/// SG44
	/// </summary>
	public List<REQOTE_SG44>? SG44C { get; set; }

	/// <summary>
	/// SG45
	/// </summary>
	public List<REQOTE_SG45>? SG45C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class REQOTE_SG43 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class REQOTE_SG44 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class REQOTE_SG45 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "QTY", "PCD", "MOA", "RTE", "TAX")]
public class REQOTE_SG46 : ALC
{
	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// SG47
	/// </summary>
	public REQOTE_SG47? SG47C { get; set; }

	/// <summary>
	/// SG48
	/// </summary>
	public REQOTE_SG48? SG48C { get; set; }

	/// <summary>
	/// SG49
	/// </summary>
	public List<REQOTE_SG49>? SG49C { get; set; }

	/// <summary>
	/// SG50
	/// </summary>
	public REQOTE_SG50? SG50C { get; set; }

	/// <summary>
	/// SG51
	/// </summary>
	public List<REQOTE_SG51>? SG51C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class REQOTE_SG47 : QTY
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class REQOTE_SG48 : PCD
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class REQOTE_SG49 : MOA
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class REQOTE_SG50 : RTE
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA")]
public class REQOTE_SG51 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TDT", "QTY", "LOC")]
public class REQOTE_SG52 : TDT
{
	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG53
	/// </summary>
	public List<REQOTE_SG53>? SG53C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class REQOTE_SG53 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("SCC", "FTX", "QTY")]
public class REQOTE_SG54 : SCC
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG55
	/// </summary>
	public List<REQOTE_SG55>? SG55C { get; set; }

}

[EdiSegmentGroup("QTY", "DTM")]
public class REQOTE_SG55 : QTY
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("ALC", "MOA", "ALI")]
public class REQOTE_SG56 : ALC
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountM { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public ALI? AdditionalInformationC { get; set; }
}