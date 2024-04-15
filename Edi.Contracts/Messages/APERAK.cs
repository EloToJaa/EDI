using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// APERAK
/// </summary>
[EdiMessage]
public class APERAK : IMessage
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
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<APERAK_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<APERAK_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<APERAK_SG3>? SG3C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class APERAK_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class APERAK_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// Contact information
	/// </summary>
	public List<CTA>? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("ERC", "FTX", "RFF")]
public class APERAK_SG3 : ERC, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public APERAK_SG4? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "FTX")]
public class APERAK_SG4 : RFF, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}