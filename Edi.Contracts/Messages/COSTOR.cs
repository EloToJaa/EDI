using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// COSTOR
/// </summary>
[EdiMessage]
public class COSTOR : IMessage
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
	/// SG1
	/// </summary>
	public List<COSTOR_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public COSTOR_SG2? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<COSTOR_SG3>? SG3M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<COSTOR_SG5>? SG5M { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<COSTOR_SG7>? SG7M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public CNT? ControlTotalC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class COSTOR_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM")]
public class COSTOR_SG2 : TDT, ISegmentGroup
{
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
public class COSTOR_SG3 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<COSTOR_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class COSTOR_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("EQD", "RFF", "EQN", "DTM", "TSR", "LOC", "DIM", "HAN", "NAD")]
public class COSTOR_SG5 : EQD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<COSTOR_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("NAD", "DTM")]
public class COSTOR_SG6 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CNI", "RFF", "NAD", "GID")]
public class COSTOR_SG7 : CNI, ISegmentGroup
{
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
	public List<COSTOR_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("GID", "HAN", "TMP", "RNG", "FTX", "DTM", "NAD", "MEA", "PCI", "DOC", "SGP", "DGS")]
public class COSTOR_SG8 : GID, ISegmentGroup
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public List<TMP>? TemperatureC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public List<RNG>? RangeDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<COSTOR_SG9>? SG9C { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<COSTOR_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<COSTOR_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("NAD", "DTM")]
public class COSTOR_SG9 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class COSTOR_SG10 : SGP, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "MEA", "SGP")]
public class COSTOR_SG11 : DGS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<COSTOR_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("SGP", "MEA")]
public class COSTOR_SG12 : SGP, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}