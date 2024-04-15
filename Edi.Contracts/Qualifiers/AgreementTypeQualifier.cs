using System.Collections.Generic;
using Edi.Contracts.Interfaces;
using System.Text.Json.Serialization;

namespace Edi.Contracts.Qualifiers;

/// <summary>
/// Agreement type qualifier
/// </summary>
public class AgreementTypeQualifier : IQualifier
{
	/// <summary>
	/// String assign converter
	/// </summary>
	public static implicit operator AgreementTypeQualifier(string s) => new AgreementTypeQualifier { Code = s };

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
		{ "1", "Type of participation" },
		{ "2", "Credit cover agreement" },
	};
}