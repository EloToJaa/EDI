using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFTDGN
/// </summary>
[EdiMessage]
public class IFTDGN
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
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public HAN? HandlingInstructions1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<IFTDGN_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public IFTDGN_SG2? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<IFTDGN_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<IFTDGN_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<IFTDGN_SG6>? SG6M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTDGN_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "RFF", "LOC", "DTM")]
public class IFTDGN_SG2 : TDT
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class IFTDGN_SG3 : NAD
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<IFTDGN_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTDGN_SG4 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("EQD", "MEA")]
public class IFTDGN_SG5 : EQD
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("CNI", "HAN", "DTM", "LOC", "TDT", "NAD", "GID")]
public class IFTDGN_SG6 : CNI
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public HAN? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public IFTDGN_SG7? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<IFTDGN_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<IFTDGN_SG10>? SG10M { get; set; }

}

[EdiSegmentGroup("TDT", "RFF")]
public class IFTDGN_SG7 : TDT
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "RFF")]
public class IFTDGN_SG8 : NAD
{
	/// <summary>
	/// SG9
	/// </summary>
	public IFTDGN_SG9? SG9C { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class IFTDGN_SG9 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("GID", "FTX", "PCI", "SGP", "DGS")]
public class IFTDGN_SG10 : GID
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Package identification
	/// </summary>
	public PCI? PackageIdentificationC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<IFTDGN_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public IFTDGN_SG12? SG12M { get; set; }

}

[EdiSegmentGroup("SGP", "MEA")]
public class IFTDGN_SG11 : SGP
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "MEA", "LOC", "RFF", "SGP")]
public class IFTDGN_SG12 : DGS
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextM { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsM { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<IFTDGN_SG13>? SG13C { get; set; }

}

[EdiSegmentGroup("SGP", "LOC", "MEA")]
public class IFTDGN_SG13 : SGP
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}