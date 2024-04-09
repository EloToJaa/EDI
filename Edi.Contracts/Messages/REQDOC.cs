using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// REQDOC
/// </summary>
[EdiMessage]
public class REQDOC
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
	/// Document/message details
	/// </summary>
	public DOC? DocumentMessageDetailsM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<REQDOC_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<REQDOC_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<REQDOC_SG4>? SG4M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class REQDOC_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "CTA")]
public class REQDOC_SG2 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<REQDOC_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class REQDOC_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("LIN", "GIS", "DTM", "PIA", "IMD", "MEA", "RFF", "NAD")]
public class REQDOC_SG4 : LIN
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<REQDOC_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<REQDOC_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class REQDOC_SG5 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "CTA")]
public class REQDOC_SG6 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<REQDOC_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class REQDOC_SG7 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}