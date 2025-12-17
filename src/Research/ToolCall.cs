using System.Text.Json.Serialization;

namespace Reka.SDK.Research;

public class ToolCall
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("args")]
    public object? Args { get; set; }
}