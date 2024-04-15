using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// COPINO
/// </summary>
[EdiMessage]
public class COPINO : IMessage
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
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<COPINO_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public COPINO_SG2? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<COPINO_SG3>? SG3M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<COPINO_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<COPINO_SG6>? SG6M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public CNT? ControlTotalC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class COPINO_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM")]
public class COPINO_SG2 : TDT, ISegmentGroup
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
public class COPINO_SG3 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<COPINO_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class COPINO_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("GID", "HAN", "TMP", "RNG", "SGP", "DGS")]
public class COPINO_SG5 : GID, ISegmentGroup
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public List<TMP>? TemperatureC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public List<RNG>? RangeDetailsC { get; set; }

	/// <summary>
	/// Split goods placement
	/// </summary>
	public List<SGP>? SplitGoodsPlacementC { get; set; }

	/// <summary>
	/// Dangerous goods
	/// </summary>
	public List<DGS>? DangerousGoodsC { get; set; }
}

[EdiSegmentGroup("EQD", "RFF", "EQN", "MEA", "DIM", "SEL", "EQA", "HAN", "TDT", "NAD")]
public class COPINO_SG6 : EQD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Attached equipment
	/// </summary>
	public EQA? AttachedEquipmentC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<COPINO_SG7>? SG7C { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM")]
public class COPINO_SG7 : TDT, ISegmentGroup
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