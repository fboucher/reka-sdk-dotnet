using System.Text.Json.Serialization;

namespace Reka.SDK.Vision;

/// <summary>
/// Response model for the Reka API videos/get endpoint (DTO)
/// </summary>
public class RekaVideoResponse
{
    [JsonPropertyName("results")]
    public List<Video> Results { get; set; } = new();
}