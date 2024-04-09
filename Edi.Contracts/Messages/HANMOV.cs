using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// HANMOV
/// </summary>
[EdiMessage]
public class HANMOV
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
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructions1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<HANMOV_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<HANMOV_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<HANMOV_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<HANMOV_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<HANMOV_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<HANMOV_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<HANMOV_SG16>? SG16C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("TCC", "LOC", "FTX", "CUX")]
public class HANMOV_SG1 : TCC
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class HANMOV_SG2 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "DOC", "RFF", "CTA")]
public class HANMOV_SG3 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<HANMOV_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<HANMOV_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class HANMOV_SG4 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class HANMOV_SG5 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "LOC", "RFF")]
public class HANMOV_SG6 : TDT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "HAN", "TCC", "NAD", "MEA", "QTY", "GIN", "GIR", "DTM", "FTX", "RFF", "LOC", "PAC")]
public class HANMOV_SG7 : LIN
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
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Transport charge/rate calculations
	/// </summary>
	public List<TCC>? TransportChargeRateCalculationsC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<HANMOV_SG8>? SG8C { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

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
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<HANMOV_SG10>? SG10C { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<HANMOV_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("NAD", "CTA")]
public class HANMOV_SG8 : NAD
{
	/// <summary>
	/// SG9
	/// </summary>
	public HANMOV_SG9? SG9C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class HANMOV_SG9 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class HANMOV_SG10 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAC", "MEA", "QTY", "PCI")]
public class HANMOV_SG11 : PAC
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
	/// SG12
	/// </summary>
	public List<HANMOV_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("PCI", "GIN")]
public class HANMOV_SG12 : PCI
{
	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }
}

[EdiSegmentGroup("GID", "HAN", "CST", "TMP", "RNG", "LOC", "MOA", "PIA", "FTX", "NAD", "MEA", "DIM", "RFF", "PCI", "DOC", "SGP", "TCC", "DGS")]
public class HANMOV_SG13 : GID
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public HAN? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Customs status of goods
	/// </summary>
	public CST? CustomsStatusOfGoodsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public TMP? TemperatureC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<HANMOV_SG14>? SG14C { get; set; }

	/// <summary>
	/// Split goods placement
	/// </summary>
	public List<SGP>? SplitGoodsPlacementC { get; set; }

	/// <summary>
	/// Transport charge/rate calculations
	/// </summary>
	public List<TCC>? TransportChargeRateCalculationsC { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<HANMOV_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM")]
public class HANMOV_SG14 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "MEA")]
public class HANMOV_SG15 : DGS
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("EQD", "EQN", "SEL", "EQA")]
public class HANMOV_SG16 : EQD
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public SEL? SealNumberC { get; set; }

	/// <summary>
	/// Attached equipment
	/// </summary>
	public List<EQA>? AttachedEquipmentC { get; set; }
}