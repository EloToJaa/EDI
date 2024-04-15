using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CALINF
/// </summary>
[EdiMessage]
public class CALINF : IMessage
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
	/// SG1
	/// </summary>
	public List<CALINF_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CALINF_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<CALINF_SG3>? SG3M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public CALINF_SG5? SG5M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CALINF_SG6>? SG6C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("FTX", "MEA", "EQN")]
public class CALINF_SG1 : FTX, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class CALINF_SG2 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class CALINF_SG3 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<CALINF_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class CALINF_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "RFF", "LOC", "DTM", "DIM", "FTX")]
public class CALINF_SG5 : TDT, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public DIM? DimensionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("QTY", "FTX")]
public class CALINF_SG6 : QTY, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}