using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CODENO
/// </summary>
[EdiMessage]
public class CODENO : IMessage
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
	/// SG1
	/// </summary>
	public List<CODENO_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public CODENO_SG2? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<CODENO_SG3>? SG3M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CODENO_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CODENO_SG7>? SG7M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public CNT? ControlTotalC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class CODENO_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM")]
public class CODENO_SG2 : TDT, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class CODENO_SG3 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<CODENO_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class CODENO_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("GID", "DOC", "SGP")]
public class CODENO_SG5 : GID, ISegmentGroup
{
	/// <summary>
	/// SG6
	/// </summary>
	public List<CODENO_SG6>? SG6M { get; set; }

	/// <summary>
	/// Split goods placement
	/// </summary>
	public List<SGP>? SplitGoodsPlacementM { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class CODENO_SG6 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }
}

[EdiSegmentGroup("EQD", "RFF", "NAD")]
public class CODENO_SG7 : EQD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }
}