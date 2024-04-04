using System.Text.Json.Serialization;

namespace Edi.Generator;


public class Schema
{
    [JsonPropertyName("Release")]
    public string? Release { get; set; }

    [JsonPropertyName("Qualifiers")]
    public Dictionary<string, Dictionary<string, string>> Qualifiers { get; set; } = new Dictionary<string, Dictionary<string, string>>();

    [JsonPropertyName("Segments")]
    public Dictionary<string, Segment> Segments { get; set; } = new Dictionary<string, Segment>();
}

public class Segment
{
    [JsonPropertyName("Desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("Elements")]
    public List<Element> Elements { get; set; } = new List<Element>();

    [JsonPropertyName("Purpose")]
    public string? Purpose { get; set; }
}

public class Element
{
    [JsonPropertyName("Id")]
    public string? Id { get; set; }

    [JsonPropertyName("Desc")]
    public string? Desc { get; set; }

    [JsonPropertyName("Required")]
    public bool Required { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Components")]
    public List<Element>? Components { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Definition")]
    public string? Definition { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DataType")]
    public string? DataType { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MinLength")]
    public int? MinLength { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("MaxLength")]
    public int? MaxLength { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("QualifierRef")]
    public string? QualifierRef { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("Name")]
    public string? Name { get; set; }
}