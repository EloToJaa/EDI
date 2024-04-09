using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// JOBAPP
/// </summary>
[EdiMessage]
public class JOBAPP
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
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<JOBAPP_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<JOBAPP_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<JOBAPP_SG4>? SG4C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<JOBAPP_SG5>? SG5M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("PNA", "ADR", "LOC", "DTM", "CTA")]
public class JOBAPP_SG1 : PNA
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
	public List<JOBAPP_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class JOBAPP_SG2 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class JOBAPP_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class JOBAPP_SG4 : GIS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "PNA", "GIS", "RCS", "SAL", "EMP")]
public class JOBAPP_SG5 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public JOBAPP_SG6? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<JOBAPP_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<JOBAPP_SG8>? SG8M { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public JOBAPP_SG9? SG9C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public JOBAPP_SG13? SG13M { get; set; }

}

[EdiSegmentGroup("PNA", "DTM", "LOC", "NAT", "PDI", "DOC")]
public class JOBAPP_SG6 : PNA
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Nationality
	/// </summary>
	public List<NAT>? NationalityC { get; set; }

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
public class JOBAPP_SG7 : GIS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("RCS", "FTX")]
public class JOBAPP_SG8 : RCS
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("SAL", "FTX", "ATT", "GIS", "MOA")]
public class JOBAPP_SG9 : SAL
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<JOBAPP_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<JOBAPP_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<JOBAPP_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("ATT", "FTX")]
public class JOBAPP_SG10 : ATT
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class JOBAPP_SG11 : GIS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG", "FTX")]
public class JOBAPP_SG12 : MOA
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("EMP", "LOC", "ATT", "LAN")]
public class JOBAPP_SG13 : EMP
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<JOBAPP_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<JOBAPP_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("ATT", "FTX", "PTY")]
public class JOBAPP_SG14 : ATT
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Priority
	/// </summary>
	public PTY? PriorityC { get; set; }
}

[EdiSegmentGroup("LAN", "GIS")]
public class JOBAPP_SG15 : LAN
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }
}