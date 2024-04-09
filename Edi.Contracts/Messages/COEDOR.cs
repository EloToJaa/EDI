using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// COEDOR
/// </summary>
[EdiMessage]
public class COEDOR
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
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<COEDOR_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<COEDOR_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<COEDOR_SG4>? SG4M { get; set; }

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
public class COEDOR_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class COEDOR_SG2 : NAD
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<COEDOR_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class COEDOR_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("EQD", "RFF", "DTM", "LOC", "HAN", "DAM", "TDT")]
public class COEDOR_SG4 : EQD
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
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<COEDOR_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public COEDOR_SG6? SG6C { get; set; }

}

[EdiSegmentGroup("DAM", "COD")]
public class COEDOR_SG5 : DAM
{
	/// <summary>
	/// Component details
	/// </summary>
	public COD? ComponentDetailsC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC")]
public class COEDOR_SG6 : TDT
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}