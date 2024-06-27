namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The uploadsegment.
    /// </summary>
    public partial class Uploadsegment : Data
    {
        /// <summary>
        /// Index of the chunk to compute the final object correctly
        /// </summary>

        [JsonPropertyName("number")]
        public int Number { get; set; } = default!;

        /// <summary>
        /// The chunk status during the upload.&lt;note&gt;&lt;strong&gt;error&lt;/strong&gt;: Something was wrong chunk was not correctly received, retried to send the same chunk.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;ok&lt;/strong&gt;: Chunk has been received.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;uploading&lt;/strong&gt;: Chunks still uploading.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UploadsegmentStatus Status { get; set; } = default!;

        /// <summary>
        /// Timestamp `Upload segment` was created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Chunk uploaded size, computed
        /// </summary>

        [JsonPropertyName("size")]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Chunk uploaded hash, computed
        /// </summary>

        [JsonPropertyName("hash")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Hash { get; set; } = default!;
    }
}