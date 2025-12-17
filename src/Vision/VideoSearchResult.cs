using System.Text.Json.Serialization;

namespace Reka.SDK.Vision;

/// <summary>
/// Data transfer object for search result from Reka API 
/// </summary>
public class VideoSearchResult
{
    [JsonPropertyName("video_chunk_id")]
    public string VideoChunkId { get; set; } = string.Empty;

    [JsonPropertyName("video_id")]
    public string VideoId { get; set; } = string.Empty;

    [JsonPropertyName("score")]
    public double Score { get; set; }

    [JsonPropertyName("start_timestamp")]
    public double StartTimestamp { get; set; }

    [JsonPropertyName("end_timestamp")]
    public double EndTimestamp { get; set; }

    [JsonPropertyName("s3_presigned_url")]
    public string S3PresignedUrl { get; set; } = string.Empty;

    [JsonPropertyName("plain_text_caption")]
    public string PlainTextCaption { get; set; } = string.Empty;
}