using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Haulage arrangements, coded
/// </summary>
public class HaulageArrangementsCoded
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator HaulageArrangementsCoded(string s) => new HaulageArrangementsCoded { Code = s };

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
		{ "1", "Carrier" },
		{ "2", "Merchant" },
	};
}