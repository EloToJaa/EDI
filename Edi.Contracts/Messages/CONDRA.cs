using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CONDRA
/// </summary>
[EdiMessage]
public class CONDRA : IMessage
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
	public List<DTM>? DateTimePeriodM { get; set; }

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
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CONDRA_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CONDRA_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CONDRA_SG5>? SG5C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DOC", "DTM", "FTX")]
public class CONDRA_SG1 : RFF, ISegmentGroup
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

[EdiSegmentGroup("NAD", "LOC", "FTX", "INP", "RCS", "RFF", "CTA")]
public class CONDRA_SG2 : NAD, ISegmentGroup
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
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }

	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public List<RCS>? RequirementsAndConditionsC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<CONDRA_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CONDRA_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class CONDRA_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM", "LOC")]
public class CONDRA_SG4 : CTA, ISegmentGroup
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

[EdiSegmentGroup("EFI", "CED", "RFF", "DTM", "QTY", "BII")]
public class CONDRA_SG5 : EFI, ISegmentGroup
{
	/// <summary>
	/// Computer environment details
	/// </summary>
	public List<CED>? ComputerEnvironmentDetailsM { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CONDRA_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("BII", "GIS", "DTM", "IMD", "QTY", "CTA", "AUT", "AGR", "INP", "RCS", "LOC", "DIM", "MEA", "RFF")]
public class CONDRA_SG6 : BII, ISegmentGroup
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
	/// Item description
	/// </summary>
	public IMD? ItemDescriptionC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Authentication result
	/// </summary>
	public List<AUT>? AuthenticationResultC { get; set; }

	/// <summary>
	/// Agreement identification
	/// </summary>
	public List<AGR>? AgreementIdentificationC { get; set; }

	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }

	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public List<RCS>? RequirementsAndConditionsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CONDRA_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("RFF", "DOC", "SEQ")]
public class CONDRA_SG7 : RFF, ISegmentGroup
{
	/// <summary>
	/// SG8
	/// </summary>
	public CONDRA_SG8? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<CONDRA_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM")]
public class CONDRA_SG8 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("SEQ", "BII", "RFF", "GIS", "DTM", "IMD")]
public class CONDRA_SG9 : SEQ, ISegmentGroup
{
	/// <summary>
	/// Structure identification
	/// </summary>
	public BII? StructureIdentificationM { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public IMD? ItemDescriptionC { get; set; }
}