using System.Text.Json.Serialization;

namespace Reka.SDK.Vision;

/// <summary>
/// Data transfer object for video information from Reka API
/// </summary>
public class Video
{
    [JsonPropertyName("video_id")]
    public string VideoId { get; set; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;

    [JsonPropertyName("indexing_status")]
    public string IndexingStatus { get; set; } = string.Empty;

    [JsonPropertyName("metadata")]
    public VideoMetadata? Metadata { get; set; }

    [JsonPropertyName("indexing_type")]
    public string IndexingType { get; set; } = string.Empty;
}