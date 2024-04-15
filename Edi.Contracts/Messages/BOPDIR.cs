using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// BOPDIR
/// </summary>
[EdiMessage]
public class BOPDIR : IMessage
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
	/// SG1
	/// </summary>
	public List<BOPDIR_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<BOPDIR_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<BOPDIR_SG3>? SG3C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<BOPDIR_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<BOPDIR_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public BOPDIR_SG16? SG16C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class BOPDIR_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class BOPDIR_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("LIN", "FII", "RCS")]
public class BOPDIR_SG3 : LIN, ISegmentGroup
{
	/// <summary>
	/// Financial institution information
	/// </summary>
	public FII? FinancialInstitutionInformationM { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<BOPDIR_SG4>? SG4M { get; set; }

}

[EdiSegmentGroup("RCS", "FTX", "RFF", "NAD", "MOA", "LOC")]
public class BOPDIR_SG4 : RCS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public BOPDIR_SG5? SG5C { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressM { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public BOPDIR_SG6? SG6M { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class BOPDIR_SG5 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MOA", "CUX")]
public class BOPDIR_SG6 : MOA, ISegmentGroup
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }
}

[EdiSegmentGroup("LIN", "RCS", "FII", "NAD", "MOA", "RCS")]
public class BOPDIR_SG7 : LIN, ISegmentGroup
{
	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public RCS? RequirementsAndConditionsM { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public FII? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountM { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<BOPDIR_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("RCS", "FTX", "GIR", "RFF", "FII", "NAD", "MOA", "LOC")]
public class BOPDIR_SG8 : RCS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public BOPDIR_SG9? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public BOPDIR_SG10? SG10C { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public FII? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountM { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("GIR", "QTY", "PRI")]
public class BOPDIR_SG9 : GIR, ISegmentGroup
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class BOPDIR_SG10 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "RCS")]
public class BOPDIR_SG11 : RFF, ISegmentGroup
{
	/// <summary>
	/// SG12
	/// </summary>
	public List<BOPDIR_SG12>? SG12M { get; set; }

}

[EdiSegmentGroup("RCS", "FTX", "SEQ")]
public class BOPDIR_SG12 : RCS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<BOPDIR_SG13>? SG13M { get; set; }

}

[EdiSegmentGroup("SEQ", "GIR", "MOA")]
public class BOPDIR_SG13 : SEQ, ISegmentGroup
{
	/// <summary>
	/// SG14
	/// </summary>
	public BOPDIR_SG14? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<BOPDIR_SG15>? SG15M { get; set; }

}

[EdiSegmentGroup("GIR", "QTY", "PRI")]
public class BOPDIR_SG14 : GIR, ISegmentGroup
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "NAD")]
public class BOPDIR_SG15 : MOA, ISegmentGroup
{
	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class BOPDIR_SG16 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}