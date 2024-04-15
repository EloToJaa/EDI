using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// MEDPID
/// </summary>
[EdiMessage]
public class MEDPID : IMessage
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
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<MEDPID_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<MEDPID_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<MEDPID_SG6>? SG6C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("PNA", "ADR", "CTA", "COM", "RFF", "LAN")]
public class MEDPID_SG1 : PNA, ISegmentGroup
{
	/// <summary>
	/// Address
	/// </summary>
	public List<ADR>? AddressC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public List<CTA>? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public List<LAN>? LanguageC { get; set; }
}

[EdiSegmentGroup("GIS", "PNA", "ADR", "RFF", "DTM", "IHC", "NAT", "FTX", "LAN", "HAN", "LOC", "FII", "CTA", "PDI", "COM", "REL")]
public class MEDPID_SG2 : GIS, ISegmentGroup
{
	/// <summary>
	/// Party name
	/// </summary>
	public PNA? PartyNameC { get; set; }

	/// <summary>
	/// Address
	/// </summary>
	public List<ADR>? AddressC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Person characteristic
	/// </summary>
	public List<IHC>? PersonCharacteristicC { get; set; }

	/// <summary>
	/// Nationality
	/// </summary>
	public List<NAT>? NationalityC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public List<LAN>? LanguageC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public List<CTA>? ContactInformationC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<MEDPID_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<MEDPID_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<MEDPID_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("PDI", "DTM")]
public class MEDPID_SG3 : PDI, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("COM", "CTA")]
public class MEDPID_SG4 : COM, ISegmentGroup
{
	/// <summary>
	/// Contact information
	/// </summary>
	public List<CTA>? ContactInformationC { get; set; }
}

[EdiSegmentGroup("REL", "PNA", "ADR", "RFF", "DTM", "PDI", "IHC", "NAT", "LAN")]
public class MEDPID_SG5 : REL, ISegmentGroup
{
	/// <summary>
	/// Party name
	/// </summary>
	public PNA? PartyNameC { get; set; }

	/// <summary>
	/// Address
	/// </summary>
	public List<ADR>? AddressC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Person demographic information
	/// </summary>
	public PDI? PersonDemographicInformationC { get; set; }

	/// <summary>
	/// Person characteristic
	/// </summary>
	public List<IHC>? PersonCharacteristicC { get; set; }

	/// <summary>
	/// Nationality
	/// </summary>
	public List<NAT>? NationalityC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public List<LAN>? LanguageC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class MEDPID_SG6 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}