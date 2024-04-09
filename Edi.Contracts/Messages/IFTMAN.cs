using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFTMAN
/// </summary>
[EdiMessage]
public class IFTMAN
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
	/// Contact information
	/// </summary>
	public CTA? ContactInformation1C { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContact1C { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirements1C { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? Currencies1C { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmount1C { get; set; }

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
	public List<IFTMAN_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<IFTMAN_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<IFTMAN_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<IFTMAN_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<IFTMAN_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<IFTMAN_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<IFTMAN_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<IFTMAN_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<IFTMAN_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG35
	/// </summary>
	public List<IFTMAN_SG35>? SG35C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class IFTMAN_SG1 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class IFTMAN_SG2 : TOD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMAN_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GOR", "DTM", "LOC", "SEL", "FTX", "DOC")]
public class IFTMAN_SG4 : GOR
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
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<IFTMAN_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM")]
public class IFTMAN_SG5 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CPI", "RFF", "CUX", "LOC", "MOA")]
public class IFTMAN_SG6 : CPI
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TCC", "LOC", "FTX", "CUX", "PRI", "EQN", "PCD", "MOA", "QTY")]
public class IFTMAN_SG7 : TCC
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }

	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "TSR", "LOC", "RFF")]
public class IFTMAN_SG8 : TDT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<IFTMAN_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<IFTMAN_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class IFTMAN_SG9 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMAN_SG10 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "MOA", "CTA", "DOC", "TCC", "RFF", "CPI", "TSR")]
public class IFTMAN_SG11 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<IFTMAN_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<IFTMAN_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<IFTMAN_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<IFTMAN_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<IFTMAN_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<IFTMAN_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTMAN_SG12 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class IFTMAN_SG13 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TCC", "PRI", "EQN", "PCD", "MOA", "QTY")]
public class IFTMAN_SG14 : TCC
{
	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }

	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMAN_SG15 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CPI", "RFF", "CUX", "LOC", "MOA")]
public class IFTMAN_SG16 : CPI
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TSR", "RFF", "LOC", "TPL", "FTX")]
public class IFTMAN_SG17 : TSR
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Transport placement
	/// </summary>
	public TPL? TransportPlacementC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("GID", "HAN", "TMP", "RNG", "TMD", "LOC", "MOA", "PIA", "FTX", "NAD", "GDS", "MEA", "DIM", "RFF", "PCI", "DOC", "TPL", "SGP", "TCC", "DGS")]
public class IFTMAN_SG18 : GID
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public HAN? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public TMP? TemperatureC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Transport movement details
	/// </summary>
	public TMD? TransportMovementDetailsC { get; set; }

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
	/// SG19
	/// </summary>
	public List<IFTMAN_SG19>? SG19C { get; set; }

	/// <summary>
	/// Nature of cargo
	/// </summary>
	public List<GDS>? NatureOfCargoC { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<IFTMAN_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<IFTMAN_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<IFTMAN_SG22>? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<IFTMAN_SG23>? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<IFTMAN_SG24>? SG24C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<IFTMAN_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<IFTMAN_SG27>? SG27C { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<IFTMAN_SG29>? SG29C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<IFTMAN_SG30>? SG30C { get; set; }

}

[EdiSegmentGroup("NAD", "DTM")]
public class IFTMAN_SG19 : NAD
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMAN_SG20 : MEA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DIM", "EQN")]
public class IFTMAN_SG21 : DIM
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMAN_SG22 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIN")]
public class IFTMAN_SG23 : PCI
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class IFTMAN_SG24 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TPL", "MEA")]
public class IFTMAN_SG25 : TPL
{
	/// <summary>
	/// SG26
	/// </summary>
	public List<IFTMAN_SG26>? SG26C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMAN_SG26 : MEA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class IFTMAN_SG27 : SGP
{
	/// <summary>
	/// SG28
	/// </summary>
	public List<IFTMAN_SG28>? SG28C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMAN_SG28 : MEA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("TCC", "CUX", "PRI", "EQN", "PCD", "MOA", "QTY", "LOC")]
public class IFTMAN_SG29 : TCC
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }

	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "CTA", "MEA", "SGP")]
public class IFTMAN_SG30 : DGS
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<IFTMAN_SG31>? SG31C { get; set; }

	/// <summary>
	/// SG32
	/// </summary>
	public List<IFTMAN_SG32>? SG32C { get; set; }

	/// <summary>
	/// SG33
	/// </summary>
	public List<IFTMAN_SG33>? SG33C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTMAN_SG31 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMAN_SG32 : MEA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class IFTMAN_SG33 : SGP
{
	/// <summary>
	/// SG34
	/// </summary>
	public List<IFTMAN_SG34>? SG34C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMAN_SG34 : MEA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("EQD", "EQN", "TMD", "MEA", "DIM", "SEL", "TPL", "HAN", "TMP", "FTX", "TCC", "NAD", "EQA")]
public class IFTMAN_SG35 : EQD
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Transport movement details
	/// </summary>
	public TMD? TransportMovementDetailsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Transport placement
	/// </summary>
	public List<TPL>? TransportPlacementC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public HAN? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public TMP? TemperatureC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG36
	/// </summary>
	public List<IFTMAN_SG36>? SG36C { get; set; }

	/// <summary>
	/// SG37
	/// </summary>
	public List<IFTMAN_SG37>? SG37C { get; set; }

	/// <summary>
	/// SG38
	/// </summary>
	public List<IFTMAN_SG38>? SG38C { get; set; }

}

[EdiSegmentGroup("TCC", "PRI", "EQN", "PCD", "MOA", "QTY")]
public class IFTMAN_SG36 : TCC
{
	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }

	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }
}

[EdiSegmentGroup("NAD", "DTM")]
public class IFTMAN_SG37 : NAD
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQA", "EQN")]
public class IFTMAN_SG38 : EQA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}