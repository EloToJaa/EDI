using System.Collections.Generic;
using Edi.Contracts.Interfaces;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Attribute function qualifier
/// </summary>
public class AttributeFunctionQualifier : IQualifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator AttributeFunctionQualifier(string s) => new AttributeFunctionQualifier { Code = s };

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
		{ "1", "Member" },
		{ "2", "Person" },
		{ "3", "Array structure component" },
		{ "4", "University degree" },
		{ "5", "Professional title" },
		{ "6", "Courtesy title" },
		{ "ZZZ", "Mutually defined" },
	};
}