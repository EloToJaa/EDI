using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// GENRAL
/// </summary>
[EdiMessage]
public class GENRAL : IMessage
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
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<GENRAL_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<GENRAL_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<GENRAL_SG5>? SG5C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class GENRAL_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class GENRAL_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<GENRAL_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<GENRAL_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class GENRAL_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class GENRAL_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("FTX", "NAD")]
public class GENRAL_SG5 : FTX, ISegmentGroup
{
	/// <summary>
	/// SG6
	/// </summary>
	public List<GENRAL_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class GENRAL_SG6 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<GENRAL_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<GENRAL_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class GENRAL_SG7 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class GENRAL_SG8 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}