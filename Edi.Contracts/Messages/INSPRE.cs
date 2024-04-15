using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// INSPRE
/// </summary>
[EdiMessage]
public class INSPRE : IMessage
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
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<INSPRE_SG1>? SG1M { get; set; }

	/// <summary>
	/// Insurance cover description
	/// </summary>
	public ICD? InsuranceCoverDescriptionC { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<INSPRE_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<INSPRE_SG3>? SG3M { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountM { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<INSPRE_SG9>? SG9C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("ATT", "PCD")]
public class INSPRE_SG1 : ATT, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("NAD", "ATT", "CTA", "COM", "RFF")]
public class INSPRE_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// Attribute
	/// </summary>
	public ATT? AttributeC { get; set; }

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

[EdiSegmentGroup("DTM", "ICD", "CUX")]
public class INSPRE_SG3 : DTM, ISegmentGroup
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<INSPRE_SG4>? SG4M { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesM { get; set; }
}

[EdiSegmentGroup("ICD", "FTX", "RFF", "MOA")]
public class INSPRE_SG4 : ICD, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<INSPRE_SG5>? SG5M { get; set; }

}

[EdiSegmentGroup("MOA", "DTM", "IND", "ATT", "TAX")]
public class INSPRE_SG5 : MOA, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<INSPRE_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<INSPRE_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public INSPRE_SG8? SG8C { get; set; }

}

[EdiSegmentGroup("IND", "DTM")]
public class INSPRE_SG6 : IND, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("ATT", "PCD")]
public class INSPRE_SG7 : ATT, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "PCD")]
public class INSPRE_SG8 : TAX, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("DTM", "MOA")]
public class INSPRE_SG9 : DTM, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountM { get; set; }
}