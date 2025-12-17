using System.Text.Json.Serialization;

namespace Reka.SDK.Chat;

public class ContentItem
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }
}