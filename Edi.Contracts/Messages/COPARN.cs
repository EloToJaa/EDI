using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// COPARN
/// </summary>
[EdiMessage]
public class COPARN : IMessage
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
	/// Transport movement details
	/// </summary>
	public TMD? TransportMovementDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<COPARN_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<COPARN_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<COPARN_SG3>? SG3M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<COPARN_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<COPARN_SG9>? SG9M { get; set; }

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
public class COPARN_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "RFF", "LOC", "DTM")]
public class COPARN_SG2 : TDT, ISegmentGroup
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

[EdiSegmentGroup("NAD", "CTA", "RFF", "DTM")]
public class COPARN_SG3 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG4
	/// </summary>
	public List<COPARN_SG4>? SG4C { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class COPARN_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("GID", "HAN", "FTX", "RFF", "PIA", "NAD", "MEA", "DIM", "DOC", "SGP", "DGS")]
public class COPARN_SG5 : GID, ISegmentGroup
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<COPARN_SG6>? SG6C { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<COPARN_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<COPARN_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("NAD", "DTM", "RFF")]
public class COPARN_SG6 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class COPARN_SG7 : SGP, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "MEA")]
public class COPARN_SG8 : DGS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("EQD", "RFF", "EQN", "TMD", "DTM", "TSR", "LOC", "MEA", "DIM", "TMP", "RNG", "SEL", "FTX", "DGS", "MOA", "GOR", "EQA", "HAN", "DAM", "TDT", "NAD")]
public class COPARN_SG9 : EQD, ISegmentGroup
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
	/// Transport movement details
	/// </summary>
	public List<TMD>? TransportMovementDetailsC { get; set; }

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
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public List<TMP>? TemperatureC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public List<RNG>? RangeDetailsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Dangerous goods
	/// </summary>
	public DGS? DangerousGoodsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Governmental requirements
	/// </summary>
	public List<GOR>? GovernmentalRequirementsC { get; set; }

	/// <summary>
	/// Attached equipment
	/// </summary>
	public EQA? AttachedEquipmentC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<COPARN_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<COPARN_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<COPARN_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("DAM", "COD")]
public class COPARN_SG10 : DAM, ISegmentGroup
{
	/// <summary>
	/// Component details
	/// </summary>
	public COD? ComponentDetailsC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM")]
public class COPARN_SG11 : TDT, ISegmentGroup
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

[EdiSegmentGroup("NAD", "DTM", "CTA", "COM", "RFF")]
public class COPARN_SG12 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}