using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// QALITY
/// </summary>
[EdiMessage]
public class QALITY
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
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescription1C { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? Measurements1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<QALITY_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<QALITY_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<QALITY_SG5>? SG5C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class QALITY_SG2 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<QALITY_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<QALITY_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class QALITY_SG4 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "MEA", "PSD", "SPS", "DTM", "QTY", "FTX", "RFF", "NAD", "TEM", "CCI", "GIN", "PRC")]
public class QALITY_SG5 : LIN
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
	/// Physical sample description
	/// </summary>
	public PSD? PhysicalSampleDescriptionC { get; set; }

	/// <summary>
	/// Sampling parameters for summary statistics
	/// </summary>
	public SPS? SamplingParametersForSummaryStatisticsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<QALITY_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<QALITY_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<QALITY_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<QALITY_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<QALITY_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<QALITY_SG30>? SG30C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG6 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class QALITY_SG7 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<QALITY_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<QALITY_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG8 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class QALITY_SG9 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TEM", "MEA", "DTM", "RFF")]
public class QALITY_SG10 : TEM
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<QALITY_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG11 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CCI", "PSD", "SPS", "DTM", "FTX", "RFF", "MEA", "STA", "TEM")]
public class QALITY_SG12 : CCI
{
	/// <summary>
	/// Physical sample description
	/// </summary>
	public List<PSD>? PhysicalSampleDescriptionC { get; set; }

	/// <summary>
	/// Sampling parameters for summary statistics
	/// </summary>
	public List<SPS>? SamplingParametersForSummaryStatisticsC { get; set; }

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
	public List<QALITY_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<QALITY_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<QALITY_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<QALITY_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG13 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MEA", "DTM", "RFF")]
public class QALITY_SG14 : MEA
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<QALITY_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG15 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("STA", "DTM", "RFF")]
public class QALITY_SG16 : STA
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<QALITY_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG17 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TEM", "MEA", "DTM", "RFF")]
public class QALITY_SG18 : TEM
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<QALITY_SG19>? SG19C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG19 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIN", "DTM", "RFF", "CCI")]
public class QALITY_SG20 : GIN
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<QALITY_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<QALITY_SG22>? SG22C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG21 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CCI", "PSD", "SPS", "DTM", "FTX", "RFF", "MEA", "STA", "TEM")]
public class QALITY_SG22 : CCI
{
	/// <summary>
	/// Physical sample description
	/// </summary>
	public List<PSD>? PhysicalSampleDescriptionC { get; set; }

	/// <summary>
	/// Sampling parameters for summary statistics
	/// </summary>
	public List<SPS>? SamplingParametersForSummaryStatisticsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<QALITY_SG23>? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<QALITY_SG24>? SG24C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<QALITY_SG26>? SG26C { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<QALITY_SG28>? SG28C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG23 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MEA", "DTM", "RFF")]
public class QALITY_SG24 : MEA
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<QALITY_SG25>? SG25C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG25 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("STA", "DTM", "RFF")]
public class QALITY_SG26 : STA
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<QALITY_SG27>? SG27C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG27 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TEM", "MEA", "DTM", "RFF")]
public class QALITY_SG28 : TEM
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<QALITY_SG29>? SG29C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG29 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PRC", "NAD", "CCI")]
public class QALITY_SG30 : PRC
{
	/// <summary>
	/// SG31
	/// </summary>
	public List<QALITY_SG31>? SG31C { get; set; }

	/// <summary>
	/// SG32
	/// </summary>
	public List<QALITY_SG32>? SG32C { get; set; }

}

[EdiSegmentGroup("NAD", "LOC")]
public class QALITY_SG31 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("CCI", "PSD", "SPS", "DTM", "FTX", "RFF", "MEA", "STA", "TEM")]
public class QALITY_SG32 : CCI
{
	/// <summary>
	/// Physical sample description
	/// </summary>
	public List<PSD>? PhysicalSampleDescriptionC { get; set; }

	/// <summary>
	/// Sampling parameters for summary statistics
	/// </summary>
	public List<SPS>? SamplingParametersForSummaryStatisticsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG33
	/// </summary>
	public List<QALITY_SG33>? SG33C { get; set; }

	/// <summary>
	/// SG34
	/// </summary>
	public List<QALITY_SG34>? SG34C { get; set; }

	/// <summary>
	/// SG36
	/// </summary>
	public List<QALITY_SG36>? SG36C { get; set; }

	/// <summary>
	/// SG38
	/// </summary>
	public List<QALITY_SG38>? SG38C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG33 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MEA", "DTM", "RFF")]
public class QALITY_SG34 : MEA
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG35
	/// </summary>
	public List<QALITY_SG35>? SG35C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG35 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("STA", "DTM", "RFF")]
public class QALITY_SG36 : STA
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG37
	/// </summary>
	public List<QALITY_SG37>? SG37C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG37 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TEM", "MEA", "DTM", "RFF")]
public class QALITY_SG38 : TEM
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG39
	/// </summary>
	public List<QALITY_SG39>? SG39C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class QALITY_SG39 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}