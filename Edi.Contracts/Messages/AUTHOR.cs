using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// AUTHOR
/// </summary>
[EdiMessage]
public class AUTHOR : IMessage
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
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<AUTHOR_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<AUTHOR_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<AUTHOR_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<AUTHOR_SG4>? SG4M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<AUTHOR_SG9>? SG9C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class AUTHOR_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("FII", "CTA", "COM")]
public class AUTHOR_SG2 : FII, ISegmentGroup
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

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class AUTHOR_SG3 : NAD, ISegmentGroup
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

[EdiSegmentGroup("LIN", "RFF", "SEQ", "FII", "NAD")]
public class AUTHOR_SG4 : LIN, ISegmentGroup
{
	/// <summary>
	/// SG5
	/// </summary>
	public List<AUTHOR_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<AUTHOR_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<AUTHOR_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<AUTHOR_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class AUTHOR_SG5 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("SEQ", "GIS", "DTM", "MOA", "DOC")]
public class AUTHOR_SG6 : SEQ, ISegmentGroup
{
	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }
}

[EdiSegmentGroup("FII", "CTA", "COM")]
public class AUTHOR_SG7 : FII, ISegmentGroup
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

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class AUTHOR_SG8 : NAD, ISegmentGroup
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

[EdiSegmentGroup("AUT", "DTM")]
public class AUTHOR_SG9 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}