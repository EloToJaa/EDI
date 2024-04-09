using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// JAPRES
/// </summary>
[EdiMessage]
public class JAPRES
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
	public List<JAPRES_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<JAPRES_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<JAPRES_SG4>? SG4C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<JAPRES_SG5>? SG5M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("PNA", "ADR", "LOC", "DTM", "CTA")]
public class JAPRES_SG1 : PNA
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
	public List<JAPRES_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class JAPRES_SG2 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class JAPRES_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class JAPRES_SG4 : GIS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "FTX", "PNA", "RFF", "GIS", "EMP", "SAL")]
public class JAPRES_SG5 : RFF
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
	/// SG6
	/// </summary>
	public JAPRES_SG6? SG6M { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<JAPRES_SG7>? SG7M { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<JAPRES_SG8>? SG8M { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<JAPRES_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public JAPRES_SG13? SG13C { get; set; }

}

[EdiSegmentGroup("PNA", "ADR", "DTM", "LOC", "NAT", "PDI", "DOC")]
public class JAPRES_SG6 : PNA
{
	/// <summary>
	/// Address
	/// </summary>
	public List<ADR>? AddressC { get; set; }

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

[EdiSegmentGroup("RFF", "DTM")]
public class JAPRES_SG7 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class JAPRES_SG8 : GIS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("EMP", "LOC", "GIS", "ATT", "LAN")]
public class JAPRES_SG9 : EMP
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<JAPRES_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<JAPRES_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<JAPRES_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("GIS", "FTX")]
public class JAPRES_SG10 : GIS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("ATT", "FTX", "PTY")]
public class JAPRES_SG11 : ATT
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
public class JAPRES_SG12 : LAN
{
	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("SAL", "FTX", "DTM", "ATT", "GIS", "MOA")]
public class JAPRES_SG13 : SAL
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<JAPRES_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<JAPRES_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<JAPRES_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("ATT", "FTX")]
public class JAPRES_SG14 : ATT
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class JAPRES_SG15 : GIS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG", "FTX")]
public class JAPRES_SG16 : MOA
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