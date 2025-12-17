using System.Text.Json.Serialization;

namespace Reka.SDK.Vision;

public class QAAnswer
{
    [JsonPropertyName("chat_response")]
    public string ChatResponse { get; set; } = string.Empty;

    [JsonPropertyName("system_message")]
    public string? SystemMessage { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; } = string.Empty;

    [JsonPropertyName("debug_chunks")]
    public object? DebugChunks { get; set; }

    [JsonPropertyName("debug_predicted_start_time")]
    public string DebugPredictedStartTime { get; set; } = string.Empty;

    [JsonPropertyName("debug_predicted_end_time")]
    public string DebugPredictedEndTime { get; set; } = string.Empty;
}