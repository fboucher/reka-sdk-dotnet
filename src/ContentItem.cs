using System.Text.Json.Serialization;

namespace Reka.SDK;

public class ContentItem
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }
}