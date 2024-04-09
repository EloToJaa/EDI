using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// PROINQ
/// </summary>
[EdiMessage]
public class PROINQ
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
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<PROINQ_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<PROINQ_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<PROINQ_SG4>? SG4M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class PROINQ_SG1 : NAD
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<PROINQ_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class PROINQ_SG2 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class PROINQ_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LIN", "CCI", "IRQ")]
public class PROINQ_SG4 : LIN
{
	/// <summary>
	/// SG5
	/// </summary>
	public List<PROINQ_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<PROINQ_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("CCI", "CAV", "MEA")]
public class PROINQ_SG5 : CCI
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

[EdiSegmentGroup("IRQ", "PIA", "IMD", "MEA", "NAD", "PGI", "DTM", "PRI")]
public class PROINQ_SG6 : IRQ
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
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Product group information
	/// </summary>
	public List<PGI>? ProductGroupInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<PROINQ_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("PRI", "RNG")]
public class PROINQ_SG7 : PRI
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}