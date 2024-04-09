using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// SANCRT
/// </summary>
[EdiMessage]
public class SANCRT
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
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentification1C { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? Reference1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? Measurements1C { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmount1C { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Customs status of goods
	/// </summary>
	public CST? CustomsStatusOfGoods1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<SANCRT_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<SANCRT_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<SANCRT_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<SANCRT_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<SANCRT_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<SANCRT_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<SANCRT_SG9>? SG9C { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<SANCRT_SG17>? SG17C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("DOC", "DTM", "LOC")]
public class SANCRT_SG1 : DOC
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

[EdiSegmentGroup("NAD", "CTA")]
public class SANCRT_SG2 : NAD
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<SANCRT_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SANCRT_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "LOC", "RFF")]
public class SANCRT_SG4 : TDT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("PAC", "PCI", "MEA")]
public class SANCRT_SG5 : PAC
{
	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("EQD", "TMP", "SEL")]
public class SANCRT_SG6 : EQD
{
	/// <summary>
	/// Temperature
	/// </summary>
	public List<TMP>? TemperatureC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<SANCRT_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("SEL", "DTM", "LOC")]
public class SANCRT_SG7 : SEL
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

[EdiSegmentGroup("PRC", "IMD", "NAD", "MEA", "DTM", "LOC", "DOC", "RFF", "TMP")]
public class SANCRT_SG8 : PRC
{
	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public List<TMP>? TemperatureC { get; set; }
}

[EdiSegmentGroup("LIN", "CST", "MEA", "PIA", "IMD", "GIN", "RFF", "ATT", "DTM", "LOC", "FTX", "QTY", "MOA", "DOC", "NAD", "PAC", "EQD", "PRC")]
public class SANCRT_SG9 : LIN
{
	/// <summary>
	/// Customs status of goods
	/// </summary>
	public List<CST>? CustomsStatusOfGoodsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Attribute
	/// </summary>
	public List<ATT>? AttributeC { get; set; }

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
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<SANCRT_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<SANCRT_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<SANCRT_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<SANCRT_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<SANCRT_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM", "LOC")]
public class SANCRT_SG10 : DOC
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

[EdiSegmentGroup("NAD", "CTA")]
public class SANCRT_SG11 : NAD
{
	/// <summary>
	/// SG12
	/// </summary>
	public List<SANCRT_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SANCRT_SG12 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("PAC", "PCI", "MEA")]
public class SANCRT_SG13 : PAC
{
	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("EQD", "TMP", "SEL")]
public class SANCRT_SG14 : EQD
{
	/// <summary>
	/// Temperature
	/// </summary>
	public List<TMP>? TemperatureC { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<SANCRT_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("SEL", "DTM", "LOC")]
public class SANCRT_SG15 : SEL
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

[EdiSegmentGroup("PRC", "IMD", "NAD", "MEA", "DTM", "LOC", "DOC", "RFF", "TMP")]
public class SANCRT_SG16 : PRC
{
	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public List<TMP>? TemperatureC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class SANCRT_SG17 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}