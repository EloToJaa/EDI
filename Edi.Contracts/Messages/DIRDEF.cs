using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DIRDEF
/// </summary>
[EdiMessage]
public class DIRDEF
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
	/// Directory identification
	/// </summary>
	public DII? DirectoryIdentificationM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<DIRDEF_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<DIRDEF_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<DIRDEF_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<DIRDEF_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<DIRDEF_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<DIRDEF_SG9>? SG9C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class DIRDEF_SG1 : NAD
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<DIRDEF_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class DIRDEF_SG2 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("MSG", "FTX", "DTM", "SGU")]
public class DIRDEF_SG3 : MSG
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodM { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<DIRDEF_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("SGU", "FTX", "GRU")]
public class DIRDEF_SG4 : SGU
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public DIRDEF_SG5? SG5C { get; set; }

}

[EdiSegmentGroup("GRU", "FTX")]
public class DIRDEF_SG5 : GRU
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("SEG", "FTX", "ELU", "REL")]
public class DIRDEF_SG6 : SEG
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Data element usage details
	/// </summary>
	public List<ELU>? DataElementUsageDetailsC { get; set; }

	/// <summary>
	/// Relationship
	/// </summary>
	public List<REL>? RelationshipC { get; set; }
}

[EdiSegmentGroup("CMP", "FTX", "ELU")]
public class DIRDEF_SG7 : CMP
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Data element usage details
	/// </summary>
	public List<ELU>? DataElementUsageDetailsC { get; set; }
}

[EdiSegmentGroup("ELM", "FTX")]
public class DIRDEF_SG8 : ELM
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("CDS", "FTX", "CDV")]
public class DIRDEF_SG9 : CDS
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<DIRDEF_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("CDV", "FTX")]
public class DIRDEF_SG10 : CDV
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}