using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// REPREM
/// </summary>
[EdiMessage]
public class REPREM
{
	/// <summary>
	/// Message header
	/// </summary>
	public UNH? MessageHeaderM { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicator1M { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<REPREM_SG1>? SG1M { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<REPREM_SG2>? SG2M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM", "RFF")]
public class REPREM_SG1 : NAD
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("REL", "RFF", "GIS", "CUX", "DTM", "QTY", "LOC", "PCD", "FTX", "ARD")]
public class REPREM_SG2 : REL
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<REPREM_SG3>? SG3M { get; set; }

}

[EdiSegmentGroup("ARD", "MOA")]
public class REPREM_SG3 : ARD
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<REPREM_SG4>? SG4M { get; set; }

}

[EdiSegmentGroup("MOA", "GIS", "PCD", "FTX", "DTM", "RFF", "CUX")]
public class REPREM_SG4 : MOA
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<REPREM_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public REPREM_SG6? SG6C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM", "COM", "FTX")]
public class REPREM_SG5 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("CUX", "MOA", "AJT")]
public class REPREM_SG6 : CUX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Adjustment details
	/// </summary>
	public AJT? AdjustmentDetailsM { get; set; }
}