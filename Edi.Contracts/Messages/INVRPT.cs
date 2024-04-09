using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// INVRPT
/// </summary>
[EdiMessage]
public class INVRPT
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
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<INVRPT_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<INVRPT_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<INVRPT_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<INVRPT_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<INVRPT_SG9>? SG9C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class INVRPT_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class INVRPT_SG2 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<INVRPT_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<INVRPT_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class INVRPT_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class INVRPT_SG4 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("CUX", "DTM")]
public class INVRPT_SG5 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CPS", "PAC")]
public class INVRPT_SG6 : CPS
{
	/// <summary>
	/// SG7
	/// </summary>
	public List<INVRPT_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("PAC", "PCI", "QTY")]
public class INVRPT_SG7 : PAC
{
	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<INVRPT_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("QTY", "GIN", "DTM")]
public class INVRPT_SG8 : QTY
{
	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "NAD", "MEA", "ALI", "LOC", "DTM", "FTX", "RFF", "INV")]
public class INVRPT_SG9 : LIN
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<INVRPT_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<INVRPT_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class INVRPT_SG10 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("INV", "QTY", "GIN", "LOC", "DTM", "STS", "NAD", "PRI", "RFF", "CPS")]
public class INVRPT_SG11 : INV
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityM { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Status
	/// </summary>
	public List<STS>? StatusC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<INVRPT_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<INVRPT_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<INVRPT_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<INVRPT_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("NAD", "LOC")]
public class INVRPT_SG12 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("PRI", "CUX", "DTM")]
public class INVRPT_SG13 : PRI
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class INVRPT_SG14 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CPS", "PAC")]
public class INVRPT_SG15 : CPS
{
	/// <summary>
	/// SG16
	/// </summary>
	public List<INVRPT_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("PAC", "MEA", "QTY", "PCI")]
public class INVRPT_SG16 : PAC
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<INVRPT_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIN")]
public class INVRPT_SG17 : PCI
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }
}