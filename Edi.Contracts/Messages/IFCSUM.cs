using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFCSUM
/// </summary>
[EdiMessage]
public class IFCSUM : IMessage
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
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<IFCSUM_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<IFCSUM_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<IFCSUM_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<IFCSUM_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<IFCSUM_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<IFCSUM_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<IFCSUM_SG19>? SG19C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFCSUM_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GOR", "DTM", "LOC", "SEL", "FTX", "DOC")]
public class IFCSUM_SG2 : GOR, ISegmentGroup
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
	/// SG3
	/// </summary>
	public List<IFCSUM_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM")]
public class IFCSUM_SG3 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "RFF")]
public class IFCSUM_SG4 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG5
	/// </summary>
	public List<IFCSUM_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<IFCSUM_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFCSUM_SG5 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFCSUM_SG6 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TCC", "PRI", "EQN", "PCD", "MOA", "QTY", "LOC")]
public class IFCSUM_SG7 : TCC, ISegmentGroup
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

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("TDT", "TSR", "LOC", "DTM", "SEL", "FTX", "MEA", "DIM", "CTA", "NAD")]
public class IFCSUM_SG8 : TDT, ISegmentGroup
{
	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<IFCSUM_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<IFCSUM_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<IFCSUM_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<IFCSUM_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFCSUM_SG9 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DIM", "EQN")]
public class IFCSUM_SG10 : DIM, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class IFCSUM_SG11 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "CTA", "DOC", "TCC", "RFF")]
public class IFCSUM_SG12 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<IFCSUM_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<IFCSUM_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<IFCSUM_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<IFCSUM_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFCSUM_SG13 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class IFCSUM_SG14 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TCC", "PRI", "EQN", "PCD", "MOA", "QTY")]
public class IFCSUM_SG15 : TCC, ISegmentGroup
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
public class IFCSUM_SG16 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQD", "EQN", "TPL", "TMD", "MEA", "DIM", "SEL", "NAD", "LOC", "HAN", "TMP", "FTX", "EQA")]
public class IFCSUM_SG17 : EQD, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Transport placement
	/// </summary>
	public TPL? TransportPlacementC { get; set; }

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
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

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
	/// SG18
	/// </summary>
	public List<IFCSUM_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("EQA", "EQN")]
public class IFCSUM_SG18 : EQA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("CNI", "SGP", "TPL", "CTA", "COM", "DTM", "CNT", "TSR", "CUX", "MOA", "FTX", "LOC", "TOD", "RFF", "GOR", "CPI", "TCC", "TDT", "NAD", "GID", "EQD")]
public class IFCSUM_SG19 : CNI, ISegmentGroup
{
	/// <summary>
	/// SG20
	/// </summary>
	public List<IFCSUM_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<IFCSUM_SG22>? SG22C { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<IFCSUM_SG24>? SG24C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<IFCSUM_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<IFCSUM_SG26>? SG26C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<IFCSUM_SG27>? SG27C { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<IFCSUM_SG29>? SG29C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<IFCSUM_SG30>? SG30C { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<IFCSUM_SG31>? SG31C { get; set; }

	/// <summary>
	/// SG34
	/// </summary>
	public List<IFCSUM_SG34>? SG34C { get; set; }

	/// <summary>
	/// SG41
	/// </summary>
	public List<IFCSUM_SG41>? SG41C { get; set; }

	/// <summary>
	/// SG60
	/// </summary>
	public List<IFCSUM_SG60>? SG60C { get; set; }

}

[EdiSegmentGroup("SGP", "MEA")]
public class IFCSUM_SG20 : SGP, ISegmentGroup
{
	/// <summary>
	/// SG21
	/// </summary>
	public List<IFCSUM_SG21>? SG21C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFCSUM_SG21 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("TPL", "MEA")]
public class IFCSUM_SG22 : TPL, ISegmentGroup
{
	/// <summary>
	/// SG23
	/// </summary>
	public List<IFCSUM_SG23>? SG23C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFCSUM_SG23 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class IFCSUM_SG24 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class IFCSUM_SG25 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFCSUM_SG26 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GOR", "DTM", "LOC", "SEL", "FTX", "DOC")]
public class IFCSUM_SG27 : GOR, ISegmentGroup
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
	/// SG28
	/// </summary>
	public List<IFCSUM_SG28>? SG28C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM")]
public class IFCSUM_SG28 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CPI", "RFF", "CUX", "LOC", "MOA")]
public class IFCSUM_SG29 : CPI, ISegmentGroup
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
public class IFCSUM_SG30 : TCC, ISegmentGroup
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
public class IFCSUM_SG31 : TDT, ISegmentGroup
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
	/// SG32
	/// </summary>
	public List<IFCSUM_SG32>? SG32C { get; set; }

	/// <summary>
	/// SG33
	/// </summary>
	public List<IFCSUM_SG33>? SG33C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class IFCSUM_SG32 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFCSUM_SG33 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "MOA", "CTA", "DOC", "TCC", "RFF", "CPI", "TSR")]
public class IFCSUM_SG34 : NAD, ISegmentGroup
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
	/// SG35
	/// </summary>
	public List<IFCSUM_SG35>? SG35C { get; set; }

	/// <summary>
	/// SG36
	/// </summary>
	public List<IFCSUM_SG36>? SG36C { get; set; }

	/// <summary>
	/// SG37
	/// </summary>
	public List<IFCSUM_SG37>? SG37C { get; set; }

	/// <summary>
	/// SG38
	/// </summary>
	public List<IFCSUM_SG38>? SG38C { get; set; }

	/// <summary>
	/// SG39
	/// </summary>
	public List<IFCSUM_SG39>? SG39C { get; set; }

	/// <summary>
	/// SG40
	/// </summary>
	public List<IFCSUM_SG40>? SG40C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFCSUM_SG35 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class IFCSUM_SG36 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TCC", "PRI", "EQN", "PCD", "MOA", "QTY")]
public class IFCSUM_SG37 : TCC, ISegmentGroup
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
public class IFCSUM_SG38 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CPI", "RFF", "CUX", "LOC", "MOA")]
public class IFCSUM_SG39 : CPI, ISegmentGroup
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
public class IFCSUM_SG40 : TSR, ISegmentGroup
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

[EdiSegmentGroup("GID", "HAN", "TMP", "RNG", "TMD", "LOC", "MOA", "PIA", "GIN", "FTX", "NAD", "GDS", "MEA", "DIM", "RFF", "PCI", "DOC", "GOR", "TPL", "SGP", "TCC", "DGS")]
public class IFCSUM_SG41 : GID, ISegmentGroup
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
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG42
	/// </summary>
	public List<IFCSUM_SG42>? SG42C { get; set; }

	/// <summary>
	/// Nature of cargo
	/// </summary>
	public List<GDS>? NatureOfCargoC { get; set; }

	/// <summary>
	/// SG43
	/// </summary>
	public List<IFCSUM_SG43>? SG43C { get; set; }

	/// <summary>
	/// SG44
	/// </summary>
	public List<IFCSUM_SG44>? SG44C { get; set; }

	/// <summary>
	/// SG45
	/// </summary>
	public List<IFCSUM_SG45>? SG45C { get; set; }

	/// <summary>
	/// SG46
	/// </summary>
	public List<IFCSUM_SG46>? SG46C { get; set; }

	/// <summary>
	/// SG47
	/// </summary>
	public List<IFCSUM_SG47>? SG47C { get; set; }

	/// <summary>
	/// SG48
	/// </summary>
	public List<IFCSUM_SG48>? SG48C { get; set; }

	/// <summary>
	/// SG50
	/// </summary>
	public List<IFCSUM_SG50>? SG50C { get; set; }

	/// <summary>
	/// SG52
	/// </summary>
	public List<IFCSUM_SG52>? SG52C { get; set; }

	/// <summary>
	/// SG54
	/// </summary>
	public List<IFCSUM_SG54>? SG54C { get; set; }

	/// <summary>
	/// SG55
	/// </summary>
	public List<IFCSUM_SG55>? SG55C { get; set; }

}

[EdiSegmentGroup("NAD", "DTM")]
public class IFCSUM_SG42 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MEA", "EQN")]
public class IFCSUM_SG43 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DIM", "EQN")]
public class IFCSUM_SG44 : DIM, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFCSUM_SG45 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIN")]
public class IFCSUM_SG46 : PCI, ISegmentGroup
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
public class IFCSUM_SG47 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GOR", "DTM", "LOC", "SEL", "FTX", "DOC")]
public class IFCSUM_SG48 : GOR, ISegmentGroup
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
	/// SG49
	/// </summary>
	public List<IFCSUM_SG49>? SG49C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM")]
public class IFCSUM_SG49 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TPL", "MEA")]
public class IFCSUM_SG50 : TPL, ISegmentGroup
{
	/// <summary>
	/// SG51
	/// </summary>
	public List<IFCSUM_SG51>? SG51C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFCSUM_SG51 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("SGP", "SEQ", "MEA")]
public class IFCSUM_SG52 : SGP, ISegmentGroup
{
	/// <summary>
	/// Sequence details
	/// </summary>
	public SEQ? SequenceDetailsC { get; set; }

	/// <summary>
	/// SG53
	/// </summary>
	public List<IFCSUM_SG53>? SG53C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFCSUM_SG53 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("TCC", "CUX", "PRI", "EQN", "PCD", "MOA", "QTY", "LOC")]
public class IFCSUM_SG54 : TCC, ISegmentGroup
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
public class IFCSUM_SG55 : DGS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG56
	/// </summary>
	public List<IFCSUM_SG56>? SG56C { get; set; }

	/// <summary>
	/// SG57
	/// </summary>
	public List<IFCSUM_SG57>? SG57C { get; set; }

	/// <summary>
	/// SG58
	/// </summary>
	public List<IFCSUM_SG58>? SG58C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFCSUM_SG56 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("MEA", "EQN")]
public class IFCSUM_SG57 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class IFCSUM_SG58 : SGP, ISegmentGroup
{
	/// <summary>
	/// SG59
	/// </summary>
	public List<IFCSUM_SG59>? SG59C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFCSUM_SG59 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("EQD", "EQN", "TMD", "MEA", "DIM", "SEL", "TPL", "HAN", "TMP", "FTX", "TCC", "NAD", "EQA")]
public class IFCSUM_SG60 : EQD, ISegmentGroup
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
	/// SG61
	/// </summary>
	public List<IFCSUM_SG61>? SG61C { get; set; }

	/// <summary>
	/// SG62
	/// </summary>
	public List<IFCSUM_SG62>? SG62C { get; set; }

	/// <summary>
	/// SG63
	/// </summary>
	public List<IFCSUM_SG63>? SG63C { get; set; }

}

[EdiSegmentGroup("TCC", "PRI", "EQN", "PCD", "MOA", "QTY")]
public class IFCSUM_SG61 : TCC, ISegmentGroup
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
public class IFCSUM_SG62 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQA", "EQN")]
public class IFCSUM_SG63 : EQA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}