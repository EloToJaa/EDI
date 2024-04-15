using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CONQVA
/// </summary>
[EdiMessage]
public class CONQVA : IMessage
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
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CONQVA_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CONQVA_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CONQVA_SG6>? SG6C { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class CONQVA_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FII", "RFF", "DOC", "CTA")]
public class CONQVA_SG2 : NAD, ISegmentGroup
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
	public List<CONQVA_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CONQVA_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CONQVA_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class CONQVA_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class CONQVA_SG4 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class CONQVA_SG5 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("BII", "RCS", "QTY", "PRI", "LIN", "TAX")]
public class CONQVA_SG6 : BII, ISegmentGroup
{
	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public RCS? RequirementsAndConditionsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityM { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CONQVA_SG7>? SG7M { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<CONQVA_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("LIN", "IMD")]
public class CONQVA_SG7 : LIN, ISegmentGroup
{
	/// <summary>
	/// SG8
	/// </summary>
	public List<CONQVA_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("IMD", "RFF", "GIS")]
public class CONQVA_SG8 : IMD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class CONQVA_SG9 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}