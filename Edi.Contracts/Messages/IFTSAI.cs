using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFTSAI
/// </summary>
[EdiMessage]
public class IFTSAI : IMessage
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
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<IFTSAI_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<IFTSAI_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<IFTSAI_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<IFTSAI_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<IFTSAI_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<IFTSAI_SG8>? SG8C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTSAI_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class IFTSAI_SG2 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQD", "EQN", "MEA", "DIM", "FTX")]
public class IFTSAI_SG3 : EQD, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public List<EQN>? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "TSR", "RFF", "FTX", "EQD", "QTY", "MEA", "LOC")]
public class IFTSAI_SG4 : TDT, ISegmentGroup
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
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Equipment details
	/// </summary>
	public List<EQD>? EquipmentDetailsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<IFTSAI_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM", "RFF")]
public class IFTSAI_SG5 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "CTA")]
public class IFTSAI_SG6 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<IFTSAI_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTSAI_SG7 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("GID", "HAN", "FTX", "GDS", "MEA", "DIM", "DGS")]
public class IFTSAI_SG8 : GID, ISegmentGroup
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<IFTSAI_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<IFTSAI_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<IFTSAI_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<IFTSAI_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("GDS", "FTX")]
public class IFTSAI_SG9 : GDS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTSAI_SG10 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public List<EQN>? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DIM", "EQN")]
public class IFTSAI_SG11 : DIM, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public List<EQN>? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX")]
public class IFTSAI_SG12 : DGS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}