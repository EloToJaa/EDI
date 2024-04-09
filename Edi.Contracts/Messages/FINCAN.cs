using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// FINCAN
/// </summary>
[EdiMessage]
public class FINCAN
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
	public DTM? DateTimePeriod1M { get; set; }

	/// <summary>
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<FINCAN_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<FINCAN_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<FINCAN_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<FINCAN_SG4>? SG4M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<FINCAN_SG6>? SG6C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class FINCAN_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("FII", "CTA", "COM")]
public class FINCAN_SG2 : FII
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
public class FINCAN_SG3 : NAD
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

[EdiSegmentGroup("LIN", "RFF")]
public class FINCAN_SG4 : LIN
{
	/// <summary>
	/// SG5
	/// </summary>
	public List<FINCAN_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class FINCAN_SG5 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class FINCAN_SG6 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}