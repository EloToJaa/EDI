using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// COMDIS
/// </summary>
[EdiMessage]
public class COMDIS : IMessage
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
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<COMDIS_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<COMDIS_SG2>? SG2C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class COMDIS_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM", "MOA", "AJT", "INP", "DLI")]
public class COMDIS_SG2 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<COMDIS_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<COMDIS_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<COMDIS_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("AJT", "FTX")]
public class COMDIS_SG3 : AJT, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("INP", "FTX")]
public class COMDIS_SG4 : INP, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("DLI", "MOA", "AJT")]
public class COMDIS_SG5 : DLI, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<COMDIS_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("AJT", "FTX")]
public class COMDIS_SG6 : AJT, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}