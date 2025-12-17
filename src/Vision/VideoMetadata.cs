using System.Text.Json.Serialization;

namespace Reka.SDK.Vision;

/// <summary>
/// Video metadata structure (Domain)
/// </summary>
public class VideoMetadata
{
    [JsonPropertyName("width")]
    public int? Width { get; set; }
    
    [JsonPropertyName("height")]
    public int? Height { get; set; }
    
    [JsonPropertyName("avg_fps")]
    public double? AvgFps { get; set; }
    
    [JsonPropertyName("video_name")]
    public string VideoName { get; set; } = string.Empty;
    
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;
    
    [JsonPropertyName("video_start_timestamp_utc_ms")]
    public long? VideoStartTimestampUtcMs { get; set; }
    
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }
    
    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; } = string.Empty;
    
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
    
    [JsonPropertyName("source")]
    public string Source { get; set; } = string.Empty;
}