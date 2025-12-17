using System.Text.Json.Serialization;

namespace Reka.SDK.Vision;

/// <summary>
/// Response model for the Reka API videos/search endpoint 
/// </summary>
public class VideoSearchResponse
{
    [JsonPropertyName("results")]
    public List<VideoSearchResult> Results { get; set; } = new();

    [JsonPropertyName("total_results")]
    public int TotalResults { get; set; }
}