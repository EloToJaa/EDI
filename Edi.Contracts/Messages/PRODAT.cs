using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// PRODAT
/// </summary>
[EdiMessage]
public class PRODAT
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
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformation1C { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescription1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// Product group information
	/// </summary>
	public List<PGI>? ProductGroupInformation1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<PRODAT_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<PRODAT_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<PRODAT_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<PRODAT_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<PRODAT_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<PRODAT_SG8>? SG8M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("TRU", "DTM")]
public class PRODAT_SG1 : TRU
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RCS", "PIA")]
public class PRODAT_SG2 : RCS
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class PRODAT_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "RFF")]
public class PRODAT_SG4 : NAD
{
	/// <summary>
	/// SG5
	/// </summary>
	public List<PRODAT_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<PRODAT_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class PRODAT_SG5 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class PRODAT_SG6 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CCI", "CAV", "MEA")]
public class PRODAT_SG7 : CCI
{
	/// <summary>
	/// Characteristic value
	/// </summary>
	public List<CAV>? CharacteristicValueC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "DTM", "MEA", "HAN", "DOC", "FTX", "PGI", "IMD", "TRU", "RCS", "QTY", "PRI", "CCI", "ALI", "RFF", "NAD", "DGS", "PAC", "HYN")]
public class PRODAT_SG8 : LIN
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Product group information
	/// </summary>
	public List<PGI>? ProductGroupInformationC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<PRODAT_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<PRODAT_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<PRODAT_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<PRODAT_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<PRODAT_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<PRODAT_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<PRODAT_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<PRODAT_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<PRODAT_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<PRODAT_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<PRODAT_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<PRODAT_SG21>? SG21C { get; set; }

}

[EdiSegmentGroup("IMD", "FTX")]
public class PRODAT_SG9 : IMD
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("TRU", "DTM")]
public class PRODAT_SG10 : TRU
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RCS", "PIA")]
public class PRODAT_SG11 : RCS
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }
}

[EdiSegmentGroup("QTY", "DTM")]
public class PRODAT_SG12 : QTY
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PRI", "CUX", "RNG")]
public class PRODAT_SG13 : PRI
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("CCI", "CAV", "MEA")]
public class PRODAT_SG14 : CCI
{
	/// <summary>
	/// Characteristic value
	/// </summary>
	public List<CAV>? CharacteristicValueC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("ALI", "PCD")]
public class PRODAT_SG15 : ALI
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class PRODAT_SG16 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "RFF", "QTY", "CTA")]
public class PRODAT_SG17 : NAD
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<PRODAT_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class PRODAT_SG18 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DGS", "QTY", "FTX")]
public class PRODAT_SG19 : DGS
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("PAC", "MEA", "QTY", "HAN", "PCI")]
public class PRODAT_SG20 : PAC
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
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }
}

[EdiSegmentGroup("HYN", "PIA", "QTY", "FTX", "RFF", "CCI", "NAD")]
public class PRODAT_SG21 : HYN
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<PRODAT_SG22>? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<PRODAT_SG23>? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<PRODAT_SG24>? SG24C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class PRODAT_SG22 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CCI", "CAV", "MEA")]
public class PRODAT_SG23 : CCI
{
	/// <summary>
	/// Characteristic value
	/// </summary>
	public List<CAV>? CharacteristicValueC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("NAD", "PIA", "QTY", "CCI")]
public class PRODAT_SG24 : NAD
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<PRODAT_SG25>? SG25C { get; set; }

}

[EdiSegmentGroup("CCI", "CAV", "MEA")]
public class PRODAT_SG25 : CCI
{
	/// <summary>
	/// Characteristic value
	/// </summary>
	public List<CAV>? CharacteristicValueC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}