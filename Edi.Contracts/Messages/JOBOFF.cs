using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// JOBOFF
/// </summary>
[EdiMessage]
public class JOBOFF
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
	public List<JOBOFF_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<JOBOFF_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<JOBOFF_SG4>? SG4C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<JOBOFF_SG5>? SG5M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("PNA", "ADR", "LOC", "DTM", "CTA")]
public class JOBOFF_SG1 : PNA
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
	public List<JOBOFF_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class JOBOFF_SG2 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class JOBOFF_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class JOBOFF_SG4 : GIS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("RFF", "RNG", "DTM", "QTY", "PNA", "GIS", "RFF", "RCS", "EMP", "SAL", "PNA")]
public class JOBOFF_SG5 : RFF
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public JOBOFF_SG6? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<JOBOFF_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<JOBOFF_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public JOBOFF_SG9? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public JOBOFF_SG10? SG10M { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public JOBOFF_SG13? SG13C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<JOBOFF_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("PNA", "DTM", "LOC", "NAT", "PDI", "DOC")]
public class JOBOFF_SG6 : PNA
{
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
public class JOBOFF_SG7 : GIS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class JOBOFF_SG8 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RCS", "RFF", "DTM", "FTX")]
public class JOBOFF_SG9 : RCS
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

[EdiSegmentGroup("EMP", "LOC", "ATT", "LAN")]
public class JOBOFF_SG10 : EMP
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<JOBOFF_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<JOBOFF_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("ATT", "FTX", "PTY")]
public class JOBOFF_SG11 : ATT
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
public class JOBOFF_SG12 : LAN
{
	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("SAL", "FTX", "DTM", "ATT", "GIS", "MOA")]
public class JOBOFF_SG13 : SAL
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
	public List<JOBOFF_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<JOBOFF_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<JOBOFF_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("ATT", "FTX")]
public class JOBOFF_SG14 : ATT
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class JOBOFF_SG15 : GIS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG", "FTX")]
public class JOBOFF_SG16 : MOA
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

[EdiSegmentGroup("PNA", "ADR", "GIS", "LOC", "FTX", "DTM", "CTA")]
public class JOBOFF_SG17 : PNA
{
	/// <summary>
	/// Address
	/// </summary>
	public ADR? AddressC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<JOBOFF_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<JOBOFF_SG19>? SG19C { get; set; }

}

[EdiSegmentGroup("DTM", "FTX")]
public class JOBOFF_SG18 : DTM
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class JOBOFF_SG19 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}