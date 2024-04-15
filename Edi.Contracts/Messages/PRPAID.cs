using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// PRPAID
/// </summary>
[EdiMessage]
public class PRPAID : IMessage
{
	/// <summary>
	/// Message header
	/// </summary>
	public UNH? MessageHeaderM { get; set; }

	/// <summary>
	/// Beginning of message
	/// </summary>
	public BGM? BeginningOfMessageC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorM { get; set; }

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
	public List<PRPAID_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<PRPAID_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<PRPAID_SG6>? SG6C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM", "RFF")]
public class PRPAID_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("DOC", "GIS", "DTM", "NAD", "MOA", "RFF", "ICD", "ATT", "CUX")]
public class PRPAID_SG2 : DOC, ISegmentGroup
{
	/// <summary>
	/// SG3
	/// </summary>
	public PRPAID_SG3? SG3C { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<PRPAID_SG4>? SG4M { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceM { get; set; }

	/// <summary>
	/// Insurance cover description
	/// </summary>
	public ICD? InsuranceCoverDescriptionC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<PRPAID_SG5>? SG5C { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class PRPAID_SG3 : GIS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("MOA", "DTM", "PCD")]
public class PRPAID_SG4 : MOA, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("ATT", "PCD")]
public class PRPAID_SG5 : ATT, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "GIS", "DTM", "RFF", "ATT", "ICD", "CUX")]
public class PRPAID_SG6 : MOA, ISegmentGroup
{
	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Attribute
	/// </summary>
	public ATT? AttributeC { get; set; }

	/// <summary>
	/// Insurance cover description
	/// </summary>
	public ICD? InsuranceCoverDescriptionC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }
}