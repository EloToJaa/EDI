using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DELFOR
/// </summary>
[EdiMessage]
public class DELFOR : IMessage
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
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<DELFOR_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<DELFOR_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<DELFOR_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<DELFOR_SG6>? SG6C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class DELFOR_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "RFF", "CTA")]
public class DELFOR_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<DELFOR_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<DELFOR_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DELFOR_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class DELFOR_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM")]
public class DELFOR_SG5 : TDT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIS", "NAD", "LIN")]
public class DELFOR_SG6 : GIS, ISegmentGroup
{
	/// <summary>
	/// SG7
	/// </summary>
	public DELFOR_SG7? SG7C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<DELFOR_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("NAD", "LOC", "FTX", "RFF", "DOC", "CTA", "TDT")]
public class DELFOR_SG7 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<DELFOR_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<DELFOR_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<DELFOR_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<DELFOR_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DELFOR_SG8 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class DELFOR_SG9 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class DELFOR_SG10 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM")]
public class DELFOR_SG11 : TDT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "MEA", "ALI", "GIN", "GIR", "LOC", "DTM", "FTX", "RFF", "TDT", "QTY", "SCC", "PAC", "NAD")]
public class DELFOR_SG12 : LIN, ISegmentGroup
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
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }

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
	/// SG13
	/// </summary>
	public List<DELFOR_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<DELFOR_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<DELFOR_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<DELFOR_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<DELFOR_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<DELFOR_SG22>? SG22C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DELFOR_SG13 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM")]
public class DELFOR_SG14 : TDT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("QTY", "DTM", "RFF")]
public class DELFOR_SG15 : QTY, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<DELFOR_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DELFOR_SG16 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("SCC", "QTY")]
public class DELFOR_SG17 : SCC, ISegmentGroup
{
	/// <summary>
	/// SG18
	/// </summary>
	public List<DELFOR_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("QTY", "DTM", "RFF")]
public class DELFOR_SG18 : QTY, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<DELFOR_SG19>? SG19C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DELFOR_SG19 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAC", "MEA", "QTY", "DTM", "PCI")]
public class DELFOR_SG20 : PAC, ISegmentGroup
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
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<DELFOR_SG21>? SG21C { get; set; }

}

[EdiSegmentGroup("PCI", "GIN")]
public class DELFOR_SG21 : PCI, ISegmentGroup
{
	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FTX", "DOC", "CTA", "QTY", "SCC", "TDT")]
public class DELFOR_SG22 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<DELFOR_SG23>? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<DELFOR_SG24>? SG24C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<DELFOR_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<DELFOR_SG27>? SG27M { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<DELFOR_SG30>? SG30C { get; set; }

}

[EdiSegmentGroup("DOC", "DTM")]
public class DELFOR_SG23 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class DELFOR_SG24 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("QTY", "DTM", "RFF")]
public class DELFOR_SG25 : QTY, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<DELFOR_SG26>? SG26C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DELFOR_SG26 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("SCC", "QTY")]
public class DELFOR_SG27 : SCC, ISegmentGroup
{
	/// <summary>
	/// SG28
	/// </summary>
	public List<DELFOR_SG28>? SG28M { get; set; }

}

[EdiSegmentGroup("QTY", "DTM", "RFF")]
public class DELFOR_SG28 : QTY, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<DELFOR_SG29>? SG29C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DELFOR_SG29 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM")]
public class DELFOR_SG30 : TDT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}