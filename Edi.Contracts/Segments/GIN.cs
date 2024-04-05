using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To give specific identification numbers, either as single numbers or ranges.
/// </summary>
[EdiSegment, EdiPath("GIN")]
public class GIN
{
	/// <summary>
	/// Code specifying the type/source of identity number.
	/// </summary>
	[EdiValue("X(3)", Path = "GIN/0")]
	public IdentityNumberQualifier? IdentityNumberQualifier { get; set; }

	/// <summary>
	/// Goods item identification numbers, start and end of consecutively numbered range.
	/// </summary>
	[EdiPath("GIN/1")]
	public GIN_IdentityNumberRange? IdentityNumberRange1 { get; set; }

	/// <summary>
	/// Goods item identification numbers, start and end of consecutively numbered range.
	/// </summary>
	[EdiPath("GIN/2")]
	public GIN_IdentityNumberRange? IdentityNumberRange2 { get; set; }

	/// <summary>
	/// Goods item identification numbers, start and end of consecutively numbered range.
	/// </summary>
	[EdiPath("GIN/3")]
	public GIN_IdentityNumberRange? IdentityNumberRange3 { get; set; }

	/// <summary>
	/// Goods item identification numbers, start and end of consecutively numbered range.
	/// </summary>
	[EdiPath("GIN/4")]
	public GIN_IdentityNumberRange? IdentityNumberRange4 { get; set; }

	/// <summary>
	/// Goods item identification numbers, start and end of consecutively numbered range.
	/// </summary>
	[EdiPath("GIN/5")]
	public GIN_IdentityNumberRange? IdentityNumberRange5 { get; set; }
}

/// <summary>
/// Goods item identification numbers, start and end of consecutively numbered range.
/// </summary>
[EdiElement]
public class GIN_IdentityNumberRange
{
	/// <summary>
	/// The number given to an object for its unique identification.
	/// </summary>
	[EdiValue("X(35)", Path = "GIN/*/0")]
	public string? IdentityNumber1 { get; set; }

	/// <summary>
	/// The number given to an object for its unique identification.
	/// </summary>
	[EdiValue("X(35)", Path = "GIN/*/1")]
	public string? IdentityNumber2 { get; set; }
}