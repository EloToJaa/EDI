using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// WKGRDC
/// </summary>
[EdiMessage]
public class WKGRDC : IMessage
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
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<WKGRDC_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<WKGRDC_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<WKGRDC_SG4>? SG4C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<WKGRDC_SG5>? SG5M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("PNA", "ADR", "LOC", "DTM", "CTA")]
public class WKGRDC_SG1 : PNA, ISegmentGroup
{
	/// <summary>
	/// Address
	/// </summary>
	public ADR? AddressC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<WKGRDC_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class WKGRDC_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class WKGRDC_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class WKGRDC_SG4 : GIS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "PNA", "FTX", "GIS", "RFF", "RCS", "EMP", "PNA")]
public class WKGRDC_SG5 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public WKGRDC_SG6? SG6C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextM { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<WKGRDC_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<WKGRDC_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<WKGRDC_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public WKGRDC_SG10? SG10M { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public WKGRDC_SG12? SG12C { get; set; }

}

[EdiSegmentGroup("PNA", "ADR", "DTM", "LOC", "NAT", "PDI", "DOC")]
public class WKGRDC_SG6 : PNA, ISegmentGroup
{
	/// <summary>
	/// Address
	/// </summary>
	public ADR? AddressC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Nationality
	/// </summary>
	public NAT? NationalityC { get; set; }

	/// <summary>
	/// Person demographic information
	/// </summary>
	public PDI? PersonDemographicInformationC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class WKGRDC_SG7 : GIS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class WKGRDC_SG8 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RCS", "RFF", "DTM", "FTX")]
public class WKGRDC_SG9 : RCS, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("EMP", "LOC", "ATT")]
public class WKGRDC_SG10 : EMP, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<WKGRDC_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("ATT", "FTX")]
public class WKGRDC_SG11 : ATT, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("PNA", "ADR", "LOC", "DTM", "FTX", "CTA")]
public class WKGRDC_SG12 : PNA, ISegmentGroup
{
	/// <summary>
	/// Address
	/// </summary>
	public ADR? AddressC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<WKGRDC_SG13>? SG13C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class WKGRDC_SG13 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}