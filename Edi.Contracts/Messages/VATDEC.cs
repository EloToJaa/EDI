using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// VATDEC
/// </summary>
[EdiMessage]
public class VATDEC
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
	public DTM? DateTimePeriod1C { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentification1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<VATDEC_SG1>? SG1M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public VATDEC_SG11? SG11C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "RFF", "FII", "PAI", "GIS", "LOC", "DTM")]
public class VATDEC_SG1 : NAD
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<VATDEC_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<VATDEC_SG3>? SG3C { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Payment instructions
	/// </summary>
	public List<PAI>? PaymentInstructionsC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<VATDEC_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class VATDEC_SG2 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "FTX")]
public class VATDEC_SG3 : RFF
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("DTM", "GIS", "MEA", "DMS", "LIN")]
public class VATDEC_SG4 : DTM
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<VATDEC_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<VATDEC_SG6>? SG6M { get; set; }

}

[EdiSegmentGroup("DMS", "MOA", "MEA", "PCD", "GIS")]
public class VATDEC_SG5 : DMS
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("LIN", "NAD", "GIS", "MOA")]
public class VATDEC_SG6 : LIN
{
	/// <summary>
	/// SG7
	/// </summary>
	public List<VATDEC_SG7>? SG7C { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<VATDEC_SG9>? SG9M { get; set; }

}

[EdiSegmentGroup("NAD", "CTA", "RFF", "FII")]
public class VATDEC_SG7 : NAD
{
	/// <summary>
	/// SG8
	/// </summary>
	public List<VATDEC_SG8>? SG8C { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public FII? FinancialInstitutionInformationC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class VATDEC_SG8 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("MOA", "ARD", "PCD", "GIS", "DMS")]
public class VATDEC_SG9 : MOA
{
	/// <summary>
	/// Amounts relationship details
	/// </summary>
	public ARD? AmountsRelationshipDetailsC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<VATDEC_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("DMS", "MOA", "MEA", "PCD", "GIS")]
public class VATDEC_SG10 : DMS
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorM { get; set; }
}

[EdiSegmentGroup("AUT", "DTM", "RFF")]
public class VATDEC_SG11 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }
}