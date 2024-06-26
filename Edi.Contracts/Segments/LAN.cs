using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify a language.
/// </summary>
[EdiSegment, EdiPath("LAN")]
public class LAN : ISegment
{
	/// <summary>
	/// Type of language.
	/// </summary>
	[EdiValue("X(3)", Path = "LAN/0", Mandatory = true)]
	public LanguageQualifier? LanguageQualifier { get; set; }

	/// <summary>
	/// To identify a language.
	/// </summary>
	[EdiPath("LAN/1")]
	public LAN_LanguageDetails? LanguageDetails { get; set; }
}

/// <summary>
/// To identify a language.
/// </summary>
[EdiElement]
public class LAN_LanguageDetails : IElement
{
	/// <summary>
	/// Code of language (ISO 639-1988).
	/// </summary>
	[EdiValue("X(3)", Path = "LAN/*/0", Mandatory = false)]
	public string? LanguageCoded { get; set; }

	/// <summary>
	/// Language as text (ISO 639-1988).
	/// </summary>
	[EdiValue("X(35)", Path = "LAN/*/1", Mandatory = false)]
	public string? Language { get; set; }
}