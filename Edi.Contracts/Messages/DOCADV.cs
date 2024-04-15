using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DOCADV
/// </summary>
[EdiMessage]
public class DOCADV : IMessage
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
	/// Reference
	/// </summary>
	public RFF? ReferenceM { get; set; }

	/// <summary>
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionM { get; set; }

	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<DOCADV_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<DOCADV_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public DOCADV_SG3? SG3M { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<DOCADV_SG4>? SG4M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<DOCADV_SG6>? SG6M { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public DOCADV_SG7? SG7M { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<DOCADV_SG8>? SG8M { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public DOCADV_SG9? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public DOCADV_SG10? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<DOCADV_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<DOCADV_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<DOCADV_SG15>? SG15M { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<DOCADV_SG16>? SG16M { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public DOCADV_SG19? SG19C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("FII", "RFF", "CTA", "COM")]
public class DOCADV_SG1 : FII, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("NAD", "RFF", "CTA", "COM")]
public class DOCADV_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DTM", "LOC")]
public class DOCADV_SG3 : DTM, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("MOA", "ALC")]
public class DOCADV_SG4 : MOA, ISegmentGroup
{
	/// <summary>
	/// SG5
	/// </summary>
	public DOCADV_SG5? SG5C { get; set; }

}

[EdiSegmentGroup("ALC", "PCD")]
public class DOCADV_SG5 : ALC, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class DOCADV_SG6 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAI", "LOC")]
public class DOCADV_SG7 : PAI, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("PAT", "FII", "DTM", "MOA", "PCD", "FTX")]
public class DOCADV_SG8 : PAT, ISegmentGroup
{
	/// <summary>
	/// Financial institution information
	/// </summary>
	public FII? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class DOCADV_SG9 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("TSR", "LOC")]
public class DOCADV_SG10 : TSR, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("INP", "FTX", "DTM")]
public class DOCADV_SG11 : INP, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("FCA", "MOA", "ALC")]
public class DOCADV_SG12 : FCA, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<DOCADV_SG13>? SG13C { get; set; }

}

[EdiSegmentGroup("ALC", "PCD", "MOA", "DTM", "TAX")]
public class DOCADV_SG13 : ALC, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<DOCADV_SG14>? SG14C { get; set; }

}

[EdiSegmentGroup("TAX", "MOA", "DTM")]
public class DOCADV_SG14 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "FTX")]
public class DOCADV_SG15 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("DOC", "MOA", "PCD", "LOC", "FTX", "ALI")]
public class DOCADV_SG16 : DOC, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<DOCADV_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("ALI", "NAD")]
public class DOCADV_SG17 : ALI, ISegmentGroup
{
	/// <summary>
	/// SG18
	/// </summary>
	public List<DOCADV_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class DOCADV_SG18 : NAD, ISegmentGroup
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class DOCADV_SG19 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}