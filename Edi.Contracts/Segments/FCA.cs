using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// Description of allocation of charges.
/// </summary>
[EdiSegment, EdiPath("FCA")]
public class FCA
{
	/// <summary>
	/// Indication of how allowances or charges are to be settled.
	/// </summary>
	[EdiValue("X(3)", Path = "FCA/0")]
	public SettlementCoded? SettlementCoded { get; set; }

	/// <summary>
	/// Identification of the account for charge or allowance.
	/// </summary>
	[EdiPath("FCA/1")]
	public FCA_ChargeAllowanceAccount? ChargeAllowanceAccount { get; set; }
}

/// <summary>
/// Identification of the account for charge or allowance.
/// </summary>
[EdiElement]
public class FCA_ChargeAllowanceAccount
{
	/// <summary>
	/// Number identifying a branch of an institution.
	/// </summary>
	[EdiValue("X(17)", Path = "FCA/*/0")]
	public string? InstitutionBranchNumber { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "FCA/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "FCA/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Account number of the holder of the account.
	/// </summary>
	[EdiValue("X(35)", Path = "FCA/*/3")]
	public string? AccountHolderNumber { get; set; }

	/// <summary>
	/// Identification of the name or symbol of the monetary unit involved in the transaction.
	/// </summary>
	[EdiValue("X(3)", Path = "FCA/*/4")]
	public string? CurrencyCoded { get; set; }
}