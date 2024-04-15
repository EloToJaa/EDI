using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// COHAOR
/// </summary>
[EdiMessage]
public class COHAOR : IMessage
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
	public List<COHAOR_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<COHAOR_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<COHAOR_SG4>? SG4M { get; set; }

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
public class COHAOR_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class COHAOR_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<COHAOR_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class COHAOR_SG3 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("EQD", "RFF", "DTM", "LOC", "FTX", "GOR", "HAN", "TDT", "NAD")]
public class COHAOR_SG4 : EQD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Governmental requirements
	/// </summary>
	public List<GOR>? GovernmentalRequirementsC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<COHAOR_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<COHAOR_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("TDT", "LOC", "DTM")]
public class COHAOR_SG5 : TDT, ISegmentGroup
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
public class COHAOR_SG6 : NAD, ISegmentGroup
{
	/// <summary>
	/// Contact information
	/// </summary>
	public List<CTA>? ContactInformationC { get; set; }
}