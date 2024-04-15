using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// MEDRPT
/// </summary>
[EdiMessage]
public class MEDRPT : IMessage
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
	public List<MEDRPT_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<MEDRPT_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<MEDRPT_SG19>? SG19C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("PNA", "ADR", "COM", "FTX", "RFF", "SEQ", "LAN", "SPR", "QUA", "EMP")]
public class MEDRPT_SG1 : PNA, ISegmentGroup
{
	/// <summary>
	/// Address
	/// </summary>
	public List<ADR>? AddressC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Sequence details
	/// </summary>
	public SEQ? SequenceDetailsC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public List<LAN>? LanguageC { get; set; }

	/// <summary>
	/// Organisation classification details
	/// </summary>
	public SPR? OrganisationClassificationDetailsC { get; set; }

	/// <summary>
	/// Qualification
	/// </summary>
	public List<QUA>? QualificationC { get; set; }

	/// <summary>
	/// Employment details
	/// </summary>
	public List<EMP>? EmploymentDetailsC { get; set; }
}

[EdiSegmentGroup("IRQ", "GIS", "RFF", "DTM", "STS", "PTY", "LAN", "FTX", "TEM", "RFF", "FCA", "ATT")]
public class MEDRPT_SG2 : IRQ, ISegmentGroup
{
	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorM { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodM { get; set; }

	/// <summary>
	/// Status
	/// </summary>
	public STS? StatusC { get; set; }

	/// <summary>
	/// Priority
	/// </summary>
	public PTY? PriorityC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public LAN? LanguageC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Test method
	/// </summary>
	public TEM? TestMethodC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<MEDRPT_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<MEDRPT_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<MEDRPT_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class MEDRPT_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("FCA", "RFF", "GIS", "DTM", "PTY", "CIN", "FTX", "TEM", "DOC")]
public class MEDRPT_SG4 : FCA, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceM { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Priority
	/// </summary>
	public PTY? PriorityC { get; set; }

	/// <summary>
	/// Clinical information
	/// </summary>
	public List<CIN>? ClinicalInformationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Test method
	/// </summary>
	public List<TEM>? TestMethodC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<MEDRPT_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("DOC", "RFF", "DTM")]
public class MEDRPT_SG5 : DOC, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("ATT", "RFF", "ADR", "COM", "REL", "IMD", "FTX", "PNA", "DTM", "PDI", "NAT", "LAN", "HAN", "CCI", "PAS", "CAV", "SEQ", "LIN")]
public class MEDRPT_SG6 : ATT, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Address
	/// </summary>
	public List<ADR>? AddressC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Relationship
	/// </summary>
	public REL? RelationshipC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Party name
	/// </summary>
	public List<PNA>? PartyNameC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Person demographic information
	/// </summary>
	public PDI? PersonDemographicInformationC { get; set; }

	/// <summary>
	/// Nationality
	/// </summary>
	public List<NAT>? NationalityC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public List<LAN>? LanguageC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Characteristic/class id
	/// </summary>
	public List<CCI>? CharacteristicClassIdC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<MEDRPT_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<MEDRPT_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<MEDRPT_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<MEDRPT_SG16>? SG16M { get; set; }

}

[EdiSegmentGroup("PAS", "LOC", "DTM", "RFF")]
public class MEDRPT_SG7 : PAS, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }
}

[EdiSegmentGroup("CAV", "CIN", "LAN", "DTM", "FTX", "RFF", "STS", "CLI")]
public class MEDRPT_SG8 : CAV, ISegmentGroup
{
	/// <summary>
	/// Clinical information
	/// </summary>
	public List<CIN>? ClinicalInformationC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public List<LAN>? LanguageC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<MEDRPT_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<MEDRPT_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("STS", "SEQ", "GIS", "RSL", "CCI", "CIN", "DTM", "FTX", "RFF", "RSL", "REL")]
public class MEDRPT_SG9 : STS, ISegmentGroup
{
	/// <summary>
	/// Sequence details
	/// </summary>
	public SEQ? SequenceDetailsC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Result
	/// </summary>
	public RSL? ResultC { get; set; }

	/// <summary>
	/// Characteristic/class id
	/// </summary>
	public List<CCI>? CharacteristicClassIdM { get; set; }

	/// <summary>
	/// Clinical information
	/// </summary>
	public List<CIN>? ClinicalInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<MEDRPT_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<MEDRPT_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("RSL", "FTX", "CCI")]
public class MEDRPT_SG10 : RSL, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Characteristic/class id
	/// </summary>
	public List<CCI>? CharacteristicClassIdC { get; set; }
}

[EdiSegmentGroup("REL", "RFF")]
public class MEDRPT_SG11 : REL, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("CLI", "IMD")]
public class MEDRPT_SG12 : CLI, ISegmentGroup
{
	/// <summary>
	/// SG13
	/// </summary>
	public List<MEDRPT_SG13>? SG13C { get; set; }

}

[EdiSegmentGroup("IMD", "DSG", "FTX", "INP")]
public class MEDRPT_SG13 : IMD, ISegmentGroup
{
	/// <summary>
	/// Dosage administration
	/// </summary>
	public List<DSG>? DosageAdministrationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("SEQ", "IMD", "PRC", "RFF", "QTY", "DTM", "PAC", "FTX", "TDT", "HAN", "LOC", "ADR", "CLI")]
public class MEDRPT_SG14 : SEQ, ISegmentGroup
{
	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionM { get; set; }

	/// <summary>
	/// Process identification
	/// </summary>
	public List<PRC>? ProcessIdentificationC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Package
	/// </summary>
	public PAC? PackageC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Details of transport
	/// </summary>
	public List<TDT>? DetailsOfTransportC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Address
	/// </summary>
	public List<ADR>? AddressC { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<MEDRPT_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("CLI", "IMD", "DSG", "DTM", "FTX", "QTY", "INP")]
public class MEDRPT_SG15 : CLI, ISegmentGroup
{
	/// <summary>
	/// Item description
	/// </summary>
	public IMD? ItemDescriptionC { get; set; }

	/// <summary>
	/// Dosage administration
	/// </summary>
	public DSG? DosageAdministrationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("LIN", "GIS", "RSL", "CCI", "CIN", "SEQ", "STS", "DTM", "FTX", "MOA", "RFF", "EQD", "REL", "RSL")]
public class MEDRPT_SG16 : LIN, ISegmentGroup
{
	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorM { get; set; }

	/// <summary>
	/// Result
	/// </summary>
	public RSL? ResultC { get; set; }

	/// <summary>
	/// Characteristic/class id
	/// </summary>
	public List<CCI>? CharacteristicClassIdM { get; set; }

	/// <summary>
	/// Clinical information
	/// </summary>
	public List<CIN>? ClinicalInformationC { get; set; }

	/// <summary>
	/// Sequence details
	/// </summary>
	public SEQ? SequenceDetailsC { get; set; }

	/// <summary>
	/// Status
	/// </summary>
	public STS? StatusC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Equipment details
	/// </summary>
	public List<EQD>? EquipmentDetailsC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<MEDRPT_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<MEDRPT_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("REL", "RFF")]
public class MEDRPT_SG17 : REL, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("RSL", "FTX", "CCI")]
public class MEDRPT_SG18 : RSL, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Characteristic/class id
	/// </summary>
	public List<CCI>? CharacteristicClassIdC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class MEDRPT_SG19 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}