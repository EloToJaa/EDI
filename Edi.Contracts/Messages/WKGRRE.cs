using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// WKGRRE
/// </summary>
[EdiMessage]
public class WKGRRE : IMessage
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
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<WKGRRE_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<WKGRRE_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<WKGRRE_SG4>? SG4C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<WKGRRE_SG5>? SG5M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("PNA", "ADR", "LOC", "DTM", "CTA")]
public class WKGRRE_SG1 : PNA, ISegmentGroup
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
	public List<WKGRRE_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class WKGRRE_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class WKGRRE_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class WKGRRE_SG4 : GIS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "PNA", "FTX", "GIS", "RFF", "EMP", "SAL", "PNA")]
public class WKGRRE_SG5 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public WKGRRE_SG6? SG6C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<WKGRRE_SG7>? SG7M { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<WKGRRE_SG8>? SG8M { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public WKGRRE_SG9? SG9M { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<WKGRRE_SG11>? SG11M { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<WKGRRE_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("PNA", "ADR", "DTM", "LOC", "NAT", "PDI", "DOC")]
public class WKGRRE_SG6 : PNA, ISegmentGroup
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
	public LOC? PlaceLocationIdentificationC { get; set; }

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
public class WKGRRE_SG7 : GIS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class WKGRRE_SG8 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EMP", "LOC", "ATT")]
public class WKGRRE_SG9 : EMP, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationM { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<WKGRRE_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("ATT", "FTX")]
public class WKGRRE_SG10 : ATT, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("SAL", "FTX", "DTM", "ATT", "GIS", "MOA")]
public class WKGRRE_SG11 : SAL, ISegmentGroup
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
	/// SG12
	/// </summary>
	public List<WKGRRE_SG12>? SG12M { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<WKGRRE_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<WKGRRE_SG14>? SG14M { get; set; }

}

[EdiSegmentGroup("ATT", "FTX")]
public class WKGRRE_SG12 : ATT, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class WKGRRE_SG13 : GIS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG", "FTX")]
public class WKGRRE_SG14 : MOA, ISegmentGroup
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

[EdiSegmentGroup("PNA", "ADR", "LOC", "DTM", "FTX", "CTA")]
public class WKGRRE_SG15 : PNA, ISegmentGroup
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
	/// SG16
	/// </summary>
	public List<WKGRRE_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class WKGRRE_SG16 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}