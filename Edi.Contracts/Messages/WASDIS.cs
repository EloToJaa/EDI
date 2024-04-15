using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// WASDIS
/// </summary>
[EdiMessage]
public class WASDIS : IMessage
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
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<WASDIS_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public WASDIS_SG2? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public WASDIS_SG3? SG3M { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public WASDIS_SG4? SG4C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<WASDIS_SG6>? SG6C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class WASDIS_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM", "GOR")]
public class WASDIS_SG2 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodM { get; set; }

	/// <summary>
	/// Governmental requirements
	/// </summary>
	public GOR? GovernmentalRequirementsM { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "LOC", "RFF", "MEA")]
public class WASDIS_SG3 : TDT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodM { get; set; }

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
public class WASDIS_SG4 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG5
	/// </summary>
	public WASDIS_SG5? SG5C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class WASDIS_SG5 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DGS", "MEA", "SGP")]
public class WASDIS_SG6 : DGS, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsC { get; set; }

	/// <summary>
	/// Split goods placement
	/// </summary>
	public List<SGP>? SplitGoodsPlacementC { get; set; }
}