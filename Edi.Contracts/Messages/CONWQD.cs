using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CONWQD
/// </summary>
[EdiMessage]
public class CONWQD
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
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// Authentication result
	/// </summary>
	public List<AUT>? AuthenticationResultC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CONWQD_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CONWQD_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CONWQD_SG6>? SG6M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class CONWQD_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FII", "RFF", "DOC", "CTA")]
public class CONWQD_SG2 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<CONWQD_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CONWQD_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CONWQD_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class CONWQD_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class CONWQD_SG4 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class CONWQD_SG5 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("BII", "QTY", "RFF", "LIN")]
public class CONWQD_SG6 : BII
{
	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CONWQD_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<CONWQD_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("RFF", "FTX", "DTM")]
public class CONWQD_SG7 : RFF
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LIN", "GIS", "FTX", "QTY")]
public class CONWQD_SG8 : LIN
{
	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorM { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<CONWQD_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("QTY", "GIS", "RFF", "FTX")]
public class CONWQD_SG9 : QTY
{
	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}