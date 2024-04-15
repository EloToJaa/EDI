using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFTMBF
/// </summary>
[EdiMessage]
public class IFTMBF : IMessage
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
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }

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
	public List<IFTMBF_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<IFTMBF_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<IFTMBF_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<IFTMBF_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<IFTMBF_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<IFTMBF_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<IFTMBF_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<IFTMBF_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG32
	/// </summary>
	public List<IFTMBF_SG32>? SG32C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class IFTMBF_SG1 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class IFTMBF_SG2 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMBF_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GOR", "FTX", "DOC")]
public class IFTMBF_SG4 : GOR, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<IFTMBF_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM")]
public class IFTMBF_SG5 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TCC", "LOC", "FTX", "CUX", "PRI", "EQN", "PCD", "MOA", "QTY")]
public class IFTMBF_SG6 : TCC, ISegmentGroup
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
public class IFTMBF_SG7 : TDT, ISegmentGroup
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
	/// SG8
	/// </summary>
	public List<IFTMBF_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<IFTMBF_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class IFTMBF_SG8 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMBF_SG9 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "CTA", "DOC", "RFF", "CPI", "TSR")]
public class IFTMBF_SG10 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<IFTMBF_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<IFTMBF_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<IFTMBF_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<IFTMBF_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<IFTMBF_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTMBF_SG11 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class IFTMBF_SG12 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMBF_SG13 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CPI", "RFF", "CUX", "LOC", "MOA")]
public class IFTMBF_SG14 : CPI, ISegmentGroup
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
public class IFTMBF_SG15 : TSR, ISegmentGroup
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

[EdiSegmentGroup("GID", "HAN", "TMP", "RNG", "TMD", "LOC", "MOA", "PIA", "FTX", "NAD", "GDS", "MEA", "DIM", "RFF", "PCI", "DOC", "TPL", "SGP", "DGS")]
public class IFTMBF_SG16 : GID, ISegmentGroup
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
	/// SG17
	/// </summary>
	public List<IFTMBF_SG17>? SG17C { get; set; }

	/// <summary>
	/// Nature of cargo
	/// </summary>
	public List<GDS>? NatureOfCargoC { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<IFTMBF_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<IFTMBF_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<IFTMBF_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<IFTMBF_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<IFTMBF_SG22>? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<IFTMBF_SG23>? SG23C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<IFTMBF_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<IFTMBF_SG27>? SG27C { get; set; }

}

[EdiSegmentGroup("NAD", "DTM")]
public class IFTMBF_SG17 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMBF_SG18 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DIM", "EQN")]
public class IFTMBF_SG19 : DIM, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMBF_SG20 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIN")]
public class IFTMBF_SG21 : PCI, ISegmentGroup
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
public class IFTMBF_SG22 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TPL", "MEA")]
public class IFTMBF_SG23 : TPL, ISegmentGroup
{
	/// <summary>
	/// SG24
	/// </summary>
	public List<IFTMBF_SG24>? SG24C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMBF_SG24 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class IFTMBF_SG25 : SGP, ISegmentGroup
{
	/// <summary>
	/// SG26
	/// </summary>
	public List<IFTMBF_SG26>? SG26C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMBF_SG26 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "CTA", "MEA", "SGP")]
public class IFTMBF_SG27 : DGS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<IFTMBF_SG28>? SG28C { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<IFTMBF_SG29>? SG29C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<IFTMBF_SG30>? SG30C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTMBF_SG28 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMBF_SG29 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class IFTMBF_SG30 : SGP, ISegmentGroup
{
	/// <summary>
	/// SG31
	/// </summary>
	public List<IFTMBF_SG31>? SG31C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMBF_SG31 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("EQD", "EQN", "TMD", "MEA", "DIM", "TPL", "HAN", "TMP", "FTX", "NAD")]
public class IFTMBF_SG32 : EQD, ISegmentGroup
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
	/// SG33
	/// </summary>
	public List<IFTMBF_SG33>? SG33C { get; set; }

}

[EdiSegmentGroup("NAD", "DTM", "CTA")]
public class IFTMBF_SG33 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG34
	/// </summary>
	public List<IFTMBF_SG34>? SG34C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTMBF_SG34 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}