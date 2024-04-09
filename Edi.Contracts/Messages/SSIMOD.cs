using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// SSIMOD
/// </summary>
[EdiMessage]
public class SSIMOD
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
	public SSIMOD_SG1? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<SSIMOD_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public SSIMOD_SG6? SG6C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class SSIMOD_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("IND", "FTX", "PNA")]
public class SSIMOD_SG2 : IND
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<SSIMOD_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("PNA", "ADR", "GIR", "NAT", "DOC", "ATT", "DTM", "PDI")]
public class SSIMOD_SG3 : PNA
{
	/// <summary>
	/// Address
	/// </summary>
	public List<ADR>? AddressC { get; set; }

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
	/// Attribute
	/// </summary>
	public List<ATT>? AttributeC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<SSIMOD_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public SSIMOD_SG5? SG5C { get; set; }

}

[EdiSegmentGroup("DTM", "ADR")]
public class SSIMOD_SG4 : DTM
{
	/// <summary>
	/// Address
	/// </summary>
	public ADR? AddressC { get; set; }
}

[EdiSegmentGroup("PDI", "DTM")]
public class SSIMOD_SG5 : PDI
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class SSIMOD_SG6 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}