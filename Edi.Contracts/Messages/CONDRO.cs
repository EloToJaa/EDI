using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CONDRO
/// </summary>
[EdiMessage]
public class CONDRO
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
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// Authentication result
	/// </summary>
	public List<AUT>? AuthenticationResultC { get; set; }

	/// <summary>
	/// Agreement identification
	/// </summary>
	public List<AGR>? AgreementIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CONDRO_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CONDRO_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CONDRO_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CONDRO_SG7>? SG7C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DOC", "DTM", "FTX")]
public class CONDRO_SG1 : RFF
{
	/// <summary>
	/// Document/message details
	/// </summary>
	public DOC? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FTX", "RFF", "CTA")]
public class CONDRO_SG2 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<CONDRO_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CONDRO_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "CED", "DTM")]
public class CONDRO_SG3 : RFF
{
	/// <summary>
	/// Computer environment details
	/// </summary>
	public List<CED>? ComputerEnvironmentDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM", "LOC")]
public class CONDRO_SG4 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("DOC", "INP", "RFF", "MEA", "EFI")]
public class CONDRO_SG5 : DOC
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CONDRO_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("EFI", "CED", "DTM")]
public class CONDRO_SG6 : EFI
{
	/// <summary>
	/// Computer environment details
	/// </summary>
	public List<CED>? ComputerEnvironmentDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("BII", "GIS", "DTM", "IMD", "RFF", "QTY", "LOC")]
public class CONDRO_SG7 : BII
{
	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public IMD? ItemDescriptionC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public CONDRO_SG8? SG8C { get; set; }

}

[EdiSegmentGroup("LOC", "DIM", "QTY", "MEA")]
public class CONDRO_SG8 : LOC
{
	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsC { get; set; }
}