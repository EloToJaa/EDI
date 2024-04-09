using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// BAPLTE
/// </summary>
[EdiMessage]
public class BAPLTE
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
	public List<BAPLTE_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<BAPLTE_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<BAPLTE_SG4>? SG4M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<BAPLTE_SG5>? SG5C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class BAPLTE_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class BAPLTE_SG2 : NAD
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<BAPLTE_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class BAPLTE_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM", "RFF", "FTX")]
public class BAPLTE_SG4 : TDT
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationM { get; set; }

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

[EdiSegmentGroup("LOC", "GID", "EQD")]
public class BAPLTE_SG5 : LOC
{
	/// <summary>
	/// Goods item details
	/// </summary>
	public GID? GoodsItemDetailsC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<BAPLTE_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("EQD", "EQN")]
public class BAPLTE_SG6 : EQD
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}