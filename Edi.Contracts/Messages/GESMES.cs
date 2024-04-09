using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// GESMES
/// </summary>
[EdiMessage]
public class GESMES
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
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<GESMES_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<GESMES_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<GESMES_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<GESMES_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<GESMES_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<GESMES_SG11>? SG11C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("FNT", "FTX")]
public class GESMES_SG1 : FNT
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("NAD", "IDE", "CTA")]
public class GESMES_SG2 : NAD
{
	/// <summary>
	/// Identity
	/// </summary>
	public IDE? IdentityC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<GESMES_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class GESMES_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("VLI", "DTM", "FTX", "IDE", "GIR", "CDV")]
public class GESMES_SG4 : VLI
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Identity
	/// </summary>
	public List<IDE>? IdentityC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<GESMES_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<GESMES_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("GIR", "DTM")]
public class GESMES_SG5 : GIR
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CDV", "FTX", "IDE")]
public class GESMES_SG6 : CDV
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Identity
	/// </summary>
	public List<IDE>? IdentityC { get; set; }
}

[EdiSegmentGroup("STC", "FTX", "IDE")]
public class GESMES_SG7 : STC
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Identity
	/// </summary>
	public List<IDE>? IdentityC { get; set; }
}

[EdiSegmentGroup("ASI", "GIS", "FTX", "IDE", "SCD")]
public class GESMES_SG8 : ASI
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Identity
	/// </summary>
	public List<IDE>? IdentityC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<GESMES_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("SCD", "ATT", "IDE")]
public class GESMES_SG9 : SCD
{
	/// <summary>
	/// Attribute
	/// </summary>
	public List<ATT>? AttributeC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<GESMES_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("IDE", "ATT", "DTM")]
public class GESMES_SG10 : IDE
{
	/// <summary>
	/// Attribute
	/// </summary>
	public List<ATT>? AttributeC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DSI", "STS", "DTM", "FTX", "GIR", "ARR", "IDE", "NAD", "FNS", "FNT")]
public class GESMES_SG11 : DSI
{
	/// <summary>
	/// Status
	/// </summary>
	public List<STS>? StatusC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }

	/// <summary>
	/// Array information
	/// </summary>
	public List<ARR>? ArrayInformationC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<GESMES_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<GESMES_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<GESMES_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<GESMES_SG20>? SG20C { get; set; }

}

[EdiSegmentGroup("IDE", "GIS", "DTM", "CDV", "SCD")]
public class GESMES_SG12 : IDE
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<GESMES_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<GESMES_SG14>? SG14C { get; set; }

}

[EdiSegmentGroup("CDV", "FTX")]
public class GESMES_SG13 : CDV
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("SCD", "ATT", "DTM", "CDV")]
public class GESMES_SG14 : SCD
{
	/// <summary>
	/// Attribute
	/// </summary>
	public List<ATT>? AttributeC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<GESMES_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("CDV", "FTX")]
public class GESMES_SG15 : CDV
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("NAD", "IDE", "CTA")]
public class GESMES_SG16 : NAD
{
	/// <summary>
	/// Identity
	/// </summary>
	public IDE? IdentityC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<GESMES_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class GESMES_SG17 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("FNS", "REL")]
public class GESMES_SG18 : FNS
{
	/// <summary>
	/// SG19
	/// </summary>
	public List<GESMES_SG19>? SG19C { get; set; }

}

[EdiSegmentGroup("REL", "ARR", "IDE")]
public class GESMES_SG19 : REL
{
	/// <summary>
	/// Array information
	/// </summary>
	public ARR? ArrayInformationC { get; set; }

	/// <summary>
	/// Identity
	/// </summary>
	public List<IDE>? IdentityC { get; set; }
}

[EdiSegmentGroup("FNT", "FTX")]
public class GESMES_SG20 : FNT
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}