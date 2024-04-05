using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Seal condition, coded
/// </summary>
public class SealConditionCoded
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator SealConditionCoded(string s) => new SealConditionCoded { Code = s };

	/// <summary>
	/// Code of the value
	/// </summary>
	public string? Code { get; set; }

	/// <summary>
	/// Value converted from code
	/// </summary>
	public string? Value => Code is null ? null : (Qualifiers.ContainsKey(Code) ? Qualifiers[Code] : null);

	/// <summary>
	/// All possible values
	/// </summary>
	[JsonIgnore]
	public Dictionary<string, string> Qualifiers => new Dictionary<string, string>
	{
		{ "1", "In right condition" },
		{ "2", "Damaged" },
	};
}