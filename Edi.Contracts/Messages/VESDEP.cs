using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// VESDEP
/// </summary>
[EdiMessage]
public class VESDEP
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
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<VESDEP_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<VESDEP_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public VESDEP_SG4? SG4M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<VESDEP_SG5>? SG5C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class VESDEP_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class VESDEP_SG2 : NAD
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<VESDEP_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class VESDEP_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "RFF", "LOC", "DTM", "MEA")]
public class VESDEP_SG4 : TDT
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("QTY", "FTX")]
public class VESDEP_SG5 : QTY
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}