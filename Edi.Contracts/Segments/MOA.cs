using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify a monetary amount.
/// </summary>
[EdiSegment, EdiPath("MOA")]
public class MOA
{
	/// <summary>
	/// Amount of goods or services stated as a monetary amount in a specified currency.
	/// </summary>
	[EdiPath("MOA/0")]
	public MOA_MonetaryAmount? MonetaryAmount { get; set; }
}

/// <summary>
/// Amount of goods or services stated as a monetary amount in a specified currency.
/// </summary>
[EdiElement]
public class MOA_MonetaryAmount
{
	/// <summary>
	/// Indication of type of amount.
	/// </summary>
	[EdiValue("X(3)", Path = "MOA/*/0")]
	public MonetaryAmountTypeQualifier? MonetaryAmountTypeQualifier { get; set; }

	/// <summary>
	/// Number of monetary units.
	/// </summary>
	[EdiValue("9(18)", Path = "MOA/*/1")]
	public int? MonetaryAmount { get; set; }

	/// <summary>
	/// Identification of the name or symbol of the monetary unit involved in the transaction.
	/// </summary>
	[EdiValue("X(3)", Path = "MOA/*/2")]
	public string? CurrencyCoded { get; set; }

	/// <summary>
	/// Code giving specific meaning to data element 6345 Currency.
	/// </summary>
	[EdiValue("X(3)", Path = "MOA/*/3")]
	public CurrencyQualifier? CurrencyQualifier { get; set; }

	/// <summary>
	/// Provides information regarding a status.
	/// </summary>
	[EdiValue("X(3)", Path = "MOA/*/4")]
	public StatusCoded? StatusCoded { get; set; }
}