using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// SAFHAZ
/// </summary>
[EdiMessage]
public class SAFHAZ : IMessage
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
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<SAFHAZ_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<SAFHAZ_SG3>? SG3M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "RFF", "CTA")]
public class SAFHAZ_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<SAFHAZ_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SAFHAZ_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "IMD", "PIA", "MEA", "RCS", "RFF", "DTM", "FTX", "NAD", "SFI")]
public class SAFHAZ_SG3 : DOC, ISegmentGroup
{
	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public List<RCS>? RequirementsAndConditionsC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<SAFHAZ_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<SAFHAZ_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("NAD", "RFF", "CTA")]
public class SAFHAZ_SG4 : NAD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<SAFHAZ_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SAFHAZ_SG5 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("SFI", "PIA", "EQD", "FTX", "NAD", "HAN", "IMD", "DGS", "CCI")]
public class SAFHAZ_SG6 : SFI, ISegmentGroup
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Equipment details
	/// </summary>
	public List<EQD>? EquipmentDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<SAFHAZ_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<SAFHAZ_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<SAFHAZ_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<SAFHAZ_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<SAFHAZ_SG13>? SG13C { get; set; }

}

[EdiSegmentGroup("NAD", "RFF", "CTA")]
public class SAFHAZ_SG7 : NAD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<SAFHAZ_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SAFHAZ_SG8 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("HAN", "FTX")]
public class SAFHAZ_SG9 : HAN, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("IMD", "MEA", "PCD", "RFF", "FTX")]
public class SAFHAZ_SG10 : IMD, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("DGS", "RFF", "FTX", "PAC")]
public class SAFHAZ_SG11 : DGS, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<SAFHAZ_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("PAC", "PCI")]
public class SAFHAZ_SG12 : PAC, ISegmentGroup
{
	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }
}

[EdiSegmentGroup("CCI", "IMD", "FTX", "CAV", "RFF", "MEA")]
public class SAFHAZ_SG13 : CCI, ISegmentGroup
{
	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Characteristic value
	/// </summary>
	public List<CAV>? CharacteristicValueC { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<SAFHAZ_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<SAFHAZ_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class SAFHAZ_SG14 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MEA", "TEM", "DTM", "RFF", "FTX")]
public class SAFHAZ_SG15 : MEA, ISegmentGroup
{
	/// <summary>
	/// Test method
	/// </summary>
	public List<TEM>? TestMethodC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}