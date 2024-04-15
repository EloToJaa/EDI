using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFTIAG
/// </summary>
[EdiMessage]
public class IFTIAG : IMessage
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
	/// Control total
	/// </summary>
	public CNT? ControlTotalM { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<IFTIAG_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public IFTIAG_SG2? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<IFTIAG_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<IFTIAG_SG5>? SG5M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<IFTIAG_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<IFTIAG_SG7>? SG7M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTIAG_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "CTA")]
public class IFTIAG_SG2 : TDT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class IFTIAG_SG3 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<IFTIAG_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTIAG_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("LOC", "NAD", "RFF", "DTM")]
public class IFTIAG_SG5 : LOC, ISegmentGroup
{
	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQD", "SEL")]
public class IFTIAG_SG6 : EQD, ISegmentGroup
{
	/// <summary>
	/// Seal number
	/// </summary>
	public SEL? SealNumberC { get; set; }
}

[EdiSegmentGroup("CNI", "LOC", "RFF", "NAD", "GID")]
public class IFTIAG_SG7 : CNI, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<IFTIAG_SG8>? SG8M { get; set; }

}

[EdiSegmentGroup("GID", "FTX", "PCI", "DGS")]
public class IFTIAG_SG8 : GID, ISegmentGroup
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
	/// SG9
	/// </summary>
	public IFTIAG_SG9? SG9M { get; set; }

}

[EdiSegmentGroup("DGS", "FTX", "LOC", "MEA", "SGP")]
public class IFTIAG_SG9 : DGS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextM { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsM { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<IFTIAG_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("SGP", "LOC", "MEA")]
public class IFTIAG_SG10 : SGP, ISegmentGroup
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