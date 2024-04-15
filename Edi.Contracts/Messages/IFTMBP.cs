using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFTMBP
/// </summary>
[EdiMessage]
public class IFTMBP : IMessage
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
	public List<IFTMBP_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<IFTMBP_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<IFTMBP_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<IFTMBP_SG5>? SG5M { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<IFTMBP_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<IFTMBP_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<IFTMBP_SG29>? SG29C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class IFTMBP_SG1 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMBP_SG2 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GOR", "FTX", "DOC")]
public class IFTMBP_SG3 : GOR, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<IFTMBP_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM")]
public class IFTMBP_SG4 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "TSR", "LOC", "RFF")]
public class IFTMBP_SG5 : TDT, ISegmentGroup
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
	/// SG6
	/// </summary>
	public List<IFTMBP_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<IFTMBP_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class IFTMBP_SG6 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMBP_SG7 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "CTA", "DOC", "RFF", "CPI", "TSR")]
public class IFTMBP_SG8 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<IFTMBP_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<IFTMBP_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<IFTMBP_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<IFTMBP_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<IFTMBP_SG13>? SG13C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTMBP_SG9 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class IFTMBP_SG10 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMBP_SG11 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CPI", "RFF", "CUX", "LOC", "MOA")]
public class IFTMBP_SG12 : CPI, ISegmentGroup
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
public class IFTMBP_SG13 : TSR, ISegmentGroup
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

[EdiSegmentGroup("GID", "HAN", "TMP", "RNG", "TMD", "LOC", "FTX", "NAD", "GDS", "MEA", "DIM", "RFF", "DOC", "TPL", "SGP", "DGS")]
public class IFTMBP_SG14 : GID, ISegmentGroup
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
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<IFTMBP_SG15>? SG15C { get; set; }

	/// <summary>
	/// Nature of cargo
	/// </summary>
	public List<GDS>? NatureOfCargoC { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<IFTMBP_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<IFTMBP_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<IFTMBP_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<IFTMBP_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<IFTMBP_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<IFTMBP_SG22>? SG22C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<IFTMBP_SG24>? SG24C { get; set; }

}

[EdiSegmentGroup("NAD", "DTM")]
public class IFTMBP_SG15 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMBP_SG16 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DIM", "EQN")]
public class IFTMBP_SG17 : DIM, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTMBP_SG18 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class IFTMBP_SG19 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TPL", "MEA")]
public class IFTMBP_SG20 : TPL, ISegmentGroup
{
	/// <summary>
	/// SG21
	/// </summary>
	public List<IFTMBP_SG21>? SG21C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMBP_SG21 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class IFTMBP_SG22 : SGP, ISegmentGroup
{
	/// <summary>
	/// SG23
	/// </summary>
	public List<IFTMBP_SG23>? SG23C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMBP_SG23 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "CTA", "MEA", "SGP")]
public class IFTMBP_SG24 : DGS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<IFTMBP_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<IFTMBP_SG26>? SG26C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<IFTMBP_SG27>? SG27C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTMBP_SG25 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMBP_SG26 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class IFTMBP_SG27 : SGP, ISegmentGroup
{
	/// <summary>
	/// SG28
	/// </summary>
	public List<IFTMBP_SG28>? SG28C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTMBP_SG28 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("EQD", "EQN", "TMD", "MEA", "DIM", "TPL", "HAN", "TMP", "FTX", "NAD")]
public class IFTMBP_SG29 : EQD, ISegmentGroup
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
	/// SG30
	/// </summary>
	public List<IFTMBP_SG30>? SG30C { get; set; }

}

[EdiSegmentGroup("NAD", "DTM", "CTA")]
public class IFTMBP_SG30 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<IFTMBP_SG31>? SG31C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTMBP_SG31 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}