using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// REBORD
/// </summary>
[EdiMessage]
public class REBORD : IMessage
{
	/// <summary>
	/// Message header
	/// </summary>
	public UNH? MessageHeaderM { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorM { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<REBORD_SG1>? SG1M { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<REBORD_SG2>? SG2M { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<REBORD_SG7>? SG7C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM", "RFF")]
public class REBORD_SG1 : NAD, ISegmentGroup
{
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
}

[EdiSegmentGroup("ARD", "CUX", "GIS", "LOC", "DTM", "FTX", "RFF", "REL")]
public class REBORD_SG2 : ARD, ISegmentGroup
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesM { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceM { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<REBORD_SG3>? SG3M { get; set; }

}

[EdiSegmentGroup("REL", "RFF", "GIS", "LOC", "NAD", "DTM", "FTX", "PCD", "MOA")]
public class REBORD_SG3 : REL, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<REBORD_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<REBORD_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("PCD", "NAD")]
public class REBORD_SG4 : PCD, ISegmentGroup
{
	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }
}

[EdiSegmentGroup("MOA", "GIS", "PCD", "DTM", "RFF", "CUX")]
public class REBORD_SG5 : MOA, ISegmentGroup
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<REBORD_SG6>? SG6C { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "COM")]
public class REBORD_SG6 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("MOA", "RFF", "PCD")]
public class REBORD_SG7 : MOA, ISegmentGroup
{
	/// <summary>
	/// SG8
	/// </summary>
	public List<REBORD_SG8>? SG8C { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "COM")]
public class REBORD_SG8 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }
}