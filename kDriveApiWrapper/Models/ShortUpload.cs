namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// upload
    /// </summary>

    public partial class ShortUpload : Data
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        [JsonPropertyName("index")]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Gets or sets the progress.
        /// </summary>
        [JsonPropertyName("progress")]
        public int Progress { get; set; } = default!;

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ready_at.
        /// </summary>
        [JsonPropertyName("ready_at")]
        public string Ready_at { get; set; } = default!;
    }
}