using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// MOVINS
/// </summary>
[EdiMessage]
public class MOVINS
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
	public DTM? DateTimePeriod1M { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<MOVINS_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<MOVINS_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<MOVINS_SG4>? SG4M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<MOVINS_SG5>? SG5M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class MOVINS_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class MOVINS_SG2 : NAD
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<MOVINS_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class MOVINS_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM", "RFF", "FTX")]
public class MOVINS_SG4 : TDT
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("HAN", "LOC")]
public class MOVINS_SG5 : HAN
{
	/// <summary>
	/// SG6
	/// </summary>
	public List<MOVINS_SG6>? SG6M { get; set; }

}

[EdiSegmentGroup("LOC", "RFF", "FTX", "MEA", "DIM", "LOC", "NAD", "TMP", "EQD", "EQA", "GID", "RFF")]
public class MOVINS_SG6 : LOC
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceM { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentification1C { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressM { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public MOVINS_SG7? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<MOVINS_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<MOVINS_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<MOVINS_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<MOVINS_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("TMP", "RNG")]
public class MOVINS_SG7 : TMP
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("EQD", "EQN")]
public class MOVINS_SG8 : EQD
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("EQA", "EQN")]
public class MOVINS_SG9 : EQA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("GID", "GDS")]
public class MOVINS_SG10 : GID
{
	/// <summary>
	/// Nature of cargo
	/// </summary>
	public GDS? NatureOfCargoC { get; set; }
}

[EdiSegmentGroup("RFF", "DGS")]
public class MOVINS_SG11 : RFF
{
	/// <summary>
	/// SG12
	/// </summary>
	public List<MOVINS_SG12>? SG12M { get; set; }

}

[EdiSegmentGroup("DGS", "FTX")]
public class MOVINS_SG12 : DGS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}