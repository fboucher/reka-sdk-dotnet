using System.Text.Json.Serialization;

namespace Reka.SDK.Chat;

public class ResponseItem
{
    [JsonPropertyName("finish_reason")]
    public string? FinishReason { get; set; }

    [JsonPropertyName("message")]
    public RekaMessage? Message { get; set; }
}