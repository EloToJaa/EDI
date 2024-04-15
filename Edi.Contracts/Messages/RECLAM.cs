using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// RECLAM
/// </summary>
[EdiMessage]
public class RECLAM : IMessage
{
	/// <summary>
	/// Message header
	/// </summary>
	public UNH? MessageHeaderM { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<RECLAM_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<RECLAM_SG2>? SG2M { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<RECLAM_SG3>? SG3C { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<RECLAM_SG4>? SG4C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<RECLAM_SG8>? SG8C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("GIS", "FTX")]
public class RECLAM_SG1 : GIS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("NAD", "PCD", "CTA", "COM", "RFF", "GIS", "FTX")]
public class RECLAM_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "COM", "FTX")]
public class RECLAM_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("GIS", "RFF", "LOC", "DTM", "FTX", "PCD", "CUX", "NAD")]
public class RECLAM_SG4 : GIS, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<RECLAM_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<RECLAM_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("CUX", "GIS", "FTX", "MOA", "PCD")]
public class RECLAM_SG5 : CUX, ISegmentGroup
{
	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<RECLAM_SG6>? SG6M { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsM { get; set; }
}

[EdiSegmentGroup("MOA", "GIS", "CUX", "FTX")]
public class RECLAM_SG6 : MOA, ISegmentGroup
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorM { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("NAD", "PCD")]
public class RECLAM_SG7 : NAD, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("CUX", "MOA")]
public class RECLAM_SG8 : CUX, ISegmentGroup
{
	/// <summary>
	/// SG9
	/// </summary>
	public List<RECLAM_SG9>? SG9M { get; set; }

}

[EdiSegmentGroup("MOA", "PCD", "CUX", "FTX", "RFF", "GIS")]
public class RECLAM_SG9 : MOA, ISegmentGroup
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<RECLAM_SG10>? SG10C { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "COM", "FTX")]
public class RECLAM_SG10 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}