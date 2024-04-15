using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// SSREGW
/// </summary>
[EdiMessage]
public class SSREGW : IMessage
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
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorM { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public SSREGW_SG1? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<SSREGW_SG2>? SG2M { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public SSREGW_SG5? SG5C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class SSREGW_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PNA", "GIR", "NAT", "DOC", "ADR", "ATT", "DTM", "PDI")]
public class SSREGW_SG2 : PNA, ISegmentGroup
{
	/// <summary>
	/// Related identification numbers
	/// </summary>
	public GIR? RelatedIdentificationNumbersC { get; set; }

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
	/// SG3
	/// </summary>
	public List<SSREGW_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public SSREGW_SG4? SG4C { get; set; }

}

[EdiSegmentGroup("DTM", "ADR")]
public class SSREGW_SG3 : DTM, ISegmentGroup
{
	/// <summary>
	/// Address
	/// </summary>
	public ADR? AddressC { get; set; }
}

[EdiSegmentGroup("PDI", "DTM")]
public class SSREGW_SG4 : PDI, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class SSREGW_SG5 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}