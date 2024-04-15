using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CONRPW
/// </summary>
[EdiMessage]
public class CONRPW : IMessage
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
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CONRPW_SG1>? SG1M { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationM { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextM { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// Authentication result
	/// </summary>
	public AUT? AuthenticationResultC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class CONRPW_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<CONRPW_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class CONRPW_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}