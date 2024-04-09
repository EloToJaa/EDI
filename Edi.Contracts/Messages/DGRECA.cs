using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DGRECA
/// </summary>
[EdiMessage]
public class DGRECA
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
	/// SG1
	/// </summary>
	public List<DGRECA_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public DGRECA_SG2? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public DGRECA_SG3? SG3M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<DGRECA_SG5>? SG5M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class DGRECA_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "LOC", "RFF", "MEA")]
public class DGRECA_SG2 : TDT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationM { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class DGRECA_SG3 : NAD
{
	/// <summary>
	/// SG4
	/// </summary>
	public DGRECA_SG4? SG4C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class DGRECA_SG4 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "MEA", "LOC", "SGP")]
public class DGRECA_SG5 : DGS
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextM { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsM { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Split goods placement
	/// </summary>
	public List<SGP>? SplitGoodsPlacementC { get; set; }
}