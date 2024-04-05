using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify a directory and to give its release, status, controlling agency, language and maintenance operation.
/// </summary>
[EdiSegment, EdiPath("DII")]
public class DII
{
	/// <summary>
	/// To specify the version number or name of an object.
	/// </summary>
	[EdiValue("X(9)", Path = "DII/0")]
	public string? Version { get; set; }

	/// <summary>
	/// To specify the release number or release name of an object.
	/// </summary>
	[EdiValue("X(9)", Path = "DII/1")]
	public string? Release { get; set; }

	/// <summary>
	/// The status of a directory set.
	/// </summary>
	[EdiValue("X(3)", Path = "DII/2")]
	public string? DirectoryStatus { get; set; }

	/// <summary>
	/// Identification of the agency controlling the specification, maintenance and publication of the message.
	/// </summary>
	[EdiValue("X(2)", Path = "DII/3")]
	public string? ControlAgency { get; set; }

	/// <summary>
	/// Code of language (ISO 639-1988).
	/// </summary>
	[EdiValue("X(3)", Path = "DII/4")]
	public string? LanguageCoded { get; set; }

	/// <summary>
	/// To indicate the type of data maintenance operation for an object, such as add, delete, replace.
	/// </summary>
	[EdiValue("X(3)", Path = "DII/5")]
	public MaintenanceOperationCoded? MaintenanceOperationCoded { get; set; }

}