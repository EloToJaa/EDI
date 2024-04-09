using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DOCAPP
/// </summary>
[EdiMessage]
public class DOCAPP
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
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstruction1M { get; set; }

	/// <summary>
	/// Financial charges allocation
	/// </summary>
	public List<FCA>? FinancialChargesAllocationM { get; set; }

	/// <summary>
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? Reference1C { get; set; }

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
	public List<DOCAPP_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<DOCAPP_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public DOCAPP_SG3? SG3M { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<DOCAPP_SG4>? SG4M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<DOCAPP_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public DOCAPP_SG7? SG7M { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<DOCAPP_SG8>? SG8M { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public DOCAPP_SG9? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public DOCAPP_SG10? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<DOCAPP_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<DOCAPP_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<DOCAPP_SG13>? SG13M { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<DOCAPP_SG14>? SG14M { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public DOCAPP_SG17? SG17C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("FII", "RFF", "CTA", "COM")]
public class DOCAPP_SG1 : FII
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
public class DOCAPP_SG2 : NAD
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
public class DOCAPP_SG3 : DTM
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("MOA", "ALC")]
public class DOCAPP_SG4 : MOA
{
	/// <summary>
	/// SG5
	/// </summary>
	public DOCAPP_SG5? SG5C { get; set; }

}

[EdiSegmentGroup("ALC", "PCD")]
public class DOCAPP_SG5 : ALC
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class DOCAPP_SG6 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAI", "LOC")]
public class DOCAPP_SG7 : PAI
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("PAT", "FII", "DTM", "MOA", "PCD", "FTX")]
public class DOCAPP_SG8 : PAT
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
public class DOCAPP_SG9 : TOD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("TSR", "LOC")]
public class DOCAPP_SG10 : TSR
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("INP", "FTX", "DTM")]
public class DOCAPP_SG11 : INP
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
public class DOCAPP_SG12 : GIS
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

[EdiSegmentGroup("RFF", "DTM", "FTX")]
public class DOCAPP_SG13 : RFF
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
public class DOCAPP_SG14 : DOC
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
	/// SG15
	/// </summary>
	public List<DOCAPP_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("ALI", "NAD")]
public class DOCAPP_SG15 : ALI
{
	/// <summary>
	/// SG16
	/// </summary>
	public List<DOCAPP_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class DOCAPP_SG16 : NAD
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
public class DOCAPP_SG17 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}