using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// SSRECH
/// </summary>
[EdiMessage]
public class SSRECH
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
	public DTM? DateTimePeriod1C { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorM { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public SSRECH_SG1? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<SSRECH_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<SSRECH_SG3>? SG3M { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<SSRECH_SG5>? SG5M { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<SSRECH_SG8>? SG8C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public SSRECH_SG9? SG9C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class SSRECH_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PNA", "ADR", "GIR")]
public class SSRECH_SG2 : PNA
{
	/// <summary>
	/// Address
	/// </summary>
	public ADR? AddressC { get; set; }

	/// <summary>
	/// Related identification numbers
	/// </summary>
	public GIR? RelatedIdentificationNumbersC { get; set; }
}

[EdiSegmentGroup("IND", "DTM", "COT", "EMP")]
public class SSRECH_SG3 : IND
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Contribution details
	/// </summary>
	public List<COT>? ContributionDetailsM { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public SSRECH_SG4? SG4C { get; set; }

}

[EdiSegmentGroup("EMP", "PNA", "ADR")]
public class SSRECH_SG4 : EMP
{
	/// <summary>
	/// Party name
	/// </summary>
	public PNA? PartyNameC { get; set; }

	/// <summary>
	/// Address
	/// </summary>
	public ADR? AddressC { get; set; }
}

[EdiSegmentGroup("PNA", "NAT", "DOC", "ADR", "ATT", "DTM", "PDI")]
public class SSRECH_SG5 : PNA
{
	/// <summary>
	/// Nationality
	/// </summary>
	public NAT? NationalityC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public DOC? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// Address
	/// </summary>
	public List<ADR>? AddressC { get; set; }

	/// <summary>
	/// Attribute
	/// </summary>
	public List<ATT>? AttributeC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<SSRECH_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<SSRECH_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("DTM", "ADR")]
public class SSRECH_SG6 : DTM
{
	/// <summary>
	/// Address
	/// </summary>
	public ADR? AddressC { get; set; }
}

[EdiSegmentGroup("PDI", "DTM")]
public class SSRECH_SG7 : PDI
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("COT", "CNT")]
public class SSRECH_SG8 : COT
{
	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalM { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class SSRECH_SG9 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}