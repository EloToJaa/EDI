using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// COARRI
/// </summary>
[EdiMessage]
public class COARRI : IMessage
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
	public List<COARRI_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public COARRI_SG2? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<COARRI_SG3>? SG3M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<COARRI_SG5>? SG5M { get; set; }

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
public class COARRI_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "RFF", "LOC", "DTM")]
public class COARRI_SG2 : TDT, ISegmentGroup
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
}

[EdiSegmentGroup("NAD", "CTA")]
public class COARRI_SG3 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<COARRI_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class COARRI_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("EQD", "RFF", "GDS", "TMD", "DTM", "LOC", "MEA", "DIM", "TMP", "RNG", "SEL", "FTX", "DGS", "EQA", "PIA", "HAN", "DAM", "TDT", "NAD")]
public class COARRI_SG5 : EQD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Nature of cargo
	/// </summary>
	public List<GDS>? NatureOfCargoC { get; set; }

	/// <summary>
	/// Transport movement details
	/// </summary>
	public List<TMD>? TransportMovementDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public List<TMP>? TemperatureC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public List<RNG>? RangeDetailsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Dangerous goods
	/// </summary>
	public List<DGS>? DangerousGoodsC { get; set; }

	/// <summary>
	/// Attached equipment
	/// </summary>
	public List<EQA>? AttachedEquipmentC { get; set; }

	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<COARRI_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public COARRI_SG7? SG7C { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }
}

[EdiSegmentGroup("DAM", "COD")]
public class COARRI_SG6 : DAM, ISegmentGroup
{
	/// <summary>
	/// Component details
	/// </summary>
	public COD? ComponentDetailsC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM")]
public class COARRI_SG7 : TDT, ISegmentGroup
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