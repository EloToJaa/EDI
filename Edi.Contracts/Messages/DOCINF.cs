using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DOCINF
/// </summary>
[EdiMessage]
public class DOCINF : IMessage
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
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionC { get; set; }

	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<DOCINF_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<DOCINF_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public DOCINF_SG3? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<DOCINF_SG4>? SG4M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<DOCINF_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public DOCINF_SG7? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<DOCINF_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public DOCINF_SG9? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public DOCINF_SG10? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<DOCINF_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<DOCINF_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<DOCINF_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<DOCINF_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<DOCINF_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public DOCINF_SG20? SG20C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("FII", "RFF", "CTA", "COM")]
public class DOCINF_SG1 : FII, ISegmentGroup
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
public class DOCINF_SG2 : NAD, ISegmentGroup
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
public class DOCINF_SG3 : DTM, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("MOA", "ALC")]
public class DOCINF_SG4 : MOA, ISegmentGroup
{
	/// <summary>
	/// SG5
	/// </summary>
	public DOCINF_SG5? SG5C { get; set; }

}

[EdiSegmentGroup("ALC", "PCD")]
public class DOCINF_SG5 : ALC, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class DOCINF_SG6 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAI", "LOC")]
public class DOCINF_SG7 : PAI, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("PAT", "FII", "DTM", "MOA", "PCD", "FTX")]
public class DOCINF_SG8 : PAT, ISegmentGroup
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
public class DOCINF_SG9 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("TSR", "LOC")]
public class DOCINF_SG10 : TSR, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("INP", "FTX", "DTM")]
public class DOCINF_SG11 : INP, ISegmentGroup
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

[EdiSegmentGroup("GIS", "MOA", "LOC", "NAD", "RCS", "FTX")]
public class DOCINF_SG12 : GIS, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public RCS? RequirementsAndConditionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("FCA", "MOA", "ALC")]
public class DOCINF_SG13 : FCA, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<DOCINF_SG14>? SG14C { get; set; }

}

[EdiSegmentGroup("ALC", "PCD", "MOA", "DTM", "TAX")]
public class DOCINF_SG14 : ALC, ISegmentGroup
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
	/// SG15
	/// </summary>
	public List<DOCINF_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("TAX", "MOA", "DTM")]
public class DOCINF_SG15 : TAX, ISegmentGroup
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
public class DOCINF_SG16 : RFF, ISegmentGroup
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
public class DOCINF_SG17 : DOC, ISegmentGroup
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
	/// SG18
	/// </summary>
	public List<DOCINF_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("ALI", "NAD")]
public class DOCINF_SG18 : ALI, ISegmentGroup
{
	/// <summary>
	/// SG19
	/// </summary>
	public List<DOCINF_SG19>? SG19C { get; set; }

}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class DOCINF_SG19 : NAD, ISegmentGroup
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
public class DOCINF_SG20 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}