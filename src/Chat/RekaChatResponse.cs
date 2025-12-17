using System.Text.Json.Serialization;


namespace Reka.SDK.Chat;

public class RekaChatResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("usage")]
    public ChatUsage? Usage { get; set; }

    [JsonPropertyName("responses")]
    public List<ResponseItem>? Responses { get; set; }
}