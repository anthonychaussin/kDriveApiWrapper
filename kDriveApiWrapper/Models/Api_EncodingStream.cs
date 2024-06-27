namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// EncodingStream
    /// </summary>

    public partial class Api_EncodingStream
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// In bps
        /// </summary>

        [JsonPropertyName("video_bitrate")]
        public double Video_bitrate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the video_width.
        /// </summary>
        [JsonPropertyName("video_width")]
        public double Video_width { get; set; } = default!;

        /// <summary>
        /// Gets or sets the video_height.
        /// </summary>
        [JsonPropertyName("video_height")]
        public double Video_height { get; set; } = default!;

        /// <summary>
        /// In bps
        /// </summary>

        [JsonPropertyName("audio_bitrate")]
        public double Audio_bitrate { get; set; } = default!;

        /// <summary>
        /// In Hz
        /// </summary>

        [JsonPropertyName("audio_sampling")]
        public double Audio_sampling { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_at.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the encoding.
        /// </summary>
        [JsonPropertyName("encoding")]
        public ICollection<Api_Encoding> Encoding { get; set; } = default!;
    }
}