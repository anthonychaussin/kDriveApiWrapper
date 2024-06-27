namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Upload
    /// </summary>

    public partial class Api_Upload
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        [JsonPropertyName("index")]
        public double Index { get; set; } = default!;

        /// <summary>
        /// percentage
        /// </summary>

        [JsonPropertyName("progress")]
        public double Progress { get; set; } = default!;

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonPropertyName("url")]
        public object Url { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ready_at.
        /// </summary>
        [JsonPropertyName("ready_at")]
        public string Ready_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the meta.
        /// </summary>
        [JsonPropertyName("meta")]
        public Api_UploadMeta Meta { get; set; } = default!;
    }
}