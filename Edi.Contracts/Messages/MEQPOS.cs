using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// MEQPOS
/// </summary>
[EdiMessage]
public class MEQPOS
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
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentification1M { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<MEQPOS_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public MEQPOS_SG2? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<MEQPOS_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<MEQPOS_SG5>? SG5C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class MEQPOS_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM")]
public class MEQPOS_SG2 : TDT
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class MEQPOS_SG3 : NAD
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<MEQPOS_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class MEQPOS_SG4 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("EQD", "LOC", "DTM")]
public class MEQPOS_SG5 : EQD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}