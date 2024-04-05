using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify details relating to pricing of a product.
/// </summary>
[EdiSegment, EdiPath("PIT")]
public class PIT
{
	/// <summary>
	/// Serial number designating each separate item within a series of articles.
	/// </summary>
	[EdiValue("X(6)", Path = "PIT/0")]
	public string? LineItemNumber { get; set; }

	/// <summary>
	/// Code specifying the action to be taken or already taken.
	/// </summary>
	[EdiValue("X(3)", Path = "PIT/1")]
	public ActionRequestNotificationCoded? ActionRequestNotificationCoded { get; set; }

	/// <summary>
	/// A value assigned by the seller to indicate movement of prices from a previous price catalogue.
	/// </summary>
	[EdiPath("PIT/2")]
	public PIT_PriceChangeInformation? PriceChangeInformation { get; set; }

	/// <summary>
	/// Code specifying the production status of an item.
	/// </summary>
	[EdiValue("X(3)", Path = "PIT/3")]
	public ArticleAvailabilityCoded? ArticleAvailabilityCoded { get; set; }

	/// <summary>
	/// Indication that the segment and/or segment group is used for sub-line item information.
	/// </summary>
	[EdiValue("X(3)", Path = "PIT/4")]
	public SublineIndicatorCoded? SublineIndicatorCoded { get; set; }

	/// <summary>
	/// Number indicating the level of an object which is in a hierarchy.
	/// </summary>
	[EdiValue("9(2)", Path = "PIT/5")]
	public int? ConfigurationLevel { get; set; }

	/// <summary>
	/// Code indicating the status of the sub-line item in the configuration.
	/// </summary>
	[EdiValue("X(3)", Path = "PIT/6")]
	public ConfigurationCoded? ConfigurationCoded { get; set; }

}

/// <summary>
/// A value assigned by the seller to indicate movement of prices from a previous price catalogue.
/// </summary>
[EdiElement]
public class PIT_PriceChangeInformation
{
	/// <summary>
	/// Indication of the type of price change for a line item (eg increased).
	/// </summary>
	[EdiValue("X(3)", Path = "PIT/*/0")]
	public string? PriceChangeIndicatorCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PIT/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PIT/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}