using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To indicate the group in which a product belongs.
/// </summary>
[EdiSegment, EdiPath("PGI")]
public class PGI
{
	/// <summary>
	/// Specification of the type of product group used for products.
	/// </summary>
	[EdiValue("X(3)", Path = "PGI/0")]
	public ProductGroupTypeCoded? ProductGroupTypeCoded { get; set; }

	/// <summary>
	/// To give product group information.
	/// </summary>
	[EdiPath("PGI/1")]
	public PGI_ProductGroup? ProductGroup { get; set; }
}

/// <summary>
/// To give product group information.
/// </summary>
[EdiElement]
public class PGI_ProductGroup
{
	/// <summary>
	/// Code allocated by the seller to identify uniquely his product group for a product or series of products.
	/// </summary>
	[EdiValue("X(3)", Path = "PGI/*/0")]
	public string? ProductGroupCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PGI/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PGI/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Free form description allocated by the seller to identify uniquely his product group for a product or a series of products.
	/// </summary>
	[EdiValue("X(35)", Path = "PGI/*/3")]
	public string? ProductGroup { get; set; }
}