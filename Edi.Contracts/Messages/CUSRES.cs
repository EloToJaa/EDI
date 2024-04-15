using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CUSRES
/// </summary>
[EdiMessage]
public class CUSRES : IMessage
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
	/// Details of transport
	/// </summary>
	public List<TDT>? DetailsOfTransportC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Equipment details
	/// </summary>
	public List<EQD>? EquipmentDetailsC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CUSRES_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<CUSRES_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CUSRES_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CUSRES_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CUSRES_SG6>? SG6C { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<CUSRES_SG13>? SG13C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class CUSRES_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<CUSRES_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class CUSRES_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "LOC")]
public class CUSRES_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("ERP", "RFF", "ERC", "FTX")]
public class CUSRES_SG4 : ERP, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Application error information
	/// </summary>
	public List<ERC>? ApplicationErrorInformationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "GIS")]
public class CUSRES_SG5 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("DOC", "PAC", "RFF", "PCI", "FTX", "TDT", "LOC", "DTM", "GIS", "MEA", "EQD", "NAD", "MOA", "CST", "ERP")]
public class CUSRES_SG6 : DOC, ISegmentGroup
{
	/// <summary>
	/// Package
	/// </summary>
	public List<PAC>? PackageC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Details of transport
	/// </summary>
	public List<TDT>? DetailsOfTransportC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Equipment details
	/// </summary>
	public List<EQD>? EquipmentDetailsC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CUSRES_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<CUSRES_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<CUSRES_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<CUSRES_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("NAD", "CTA")]
public class CUSRES_SG7 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG8
	/// </summary>
	public List<CUSRES_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class CUSRES_SG8 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("MOA", "CUX")]
public class CUSRES_SG9 : MOA, ISegmentGroup
{
	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }
}

[EdiSegmentGroup("CST", "FTX", "TAX")]
public class CUSRES_SG10 : CST, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<CUSRES_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("TAX", "MOA", "GIS", "MEA", "RFF")]
public class CUSRES_SG11 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("ERP", "RFF", "ERC", "FTX")]
public class CUSRES_SG12 : ERP, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Application error information
	/// </summary>
	public List<ERC>? ApplicationErrorInformationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class CUSRES_SG13 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}