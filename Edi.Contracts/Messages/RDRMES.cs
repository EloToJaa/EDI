using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// RDRMES
/// </summary>
[EdiMessage]
public class RDRMES
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
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<RDRMES_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<RDRMES_SG3>? SG3M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "RFF", "FTX", "CTA")]
public class RDRMES_SG1 : NAD
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<RDRMES_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class RDRMES_SG2 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("IDE", "NAD", "SCD")]
public class RDRMES_SG3 : IDE
{
	/// <summary>
	/// SG4
	/// </summary>
	public RDRMES_SG4? SG4C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<RDRMES_SG6>? SG6M { get; set; }

}

[EdiSegmentGroup("NAD", "RFF", "FTX", "CTA")]
public class RDRMES_SG4 : NAD
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<RDRMES_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class RDRMES_SG5 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("SCD", "ARR", "RFF", "DTM", "FTX", "NAD")]
public class RDRMES_SG6 : SCD
{
	/// <summary>
	/// Array information
	/// </summary>
	public ARR? ArrayInformationC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<RDRMES_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("NAD", "RFF", "FTX", "CTA")]
public class RDRMES_SG7 : NAD
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<RDRMES_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class RDRMES_SG8 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}