using System.Collections.Generic;
using Edi.Contracts.Interfaces;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Rate type qualifier
/// </summary>
public class RateTypeQualifier : IQualifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator RateTypeQualifier(string s) => new RateTypeQualifier { Code = s };

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
		{ "1", "Allowance rate" },
		{ "2", "Charge rate" },
		{ "3", "Actual versus calculated price difference rate" },
	};
}