namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// OverlayLogo
    /// </summary>

    public partial class Api_OverlayLogo
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the uuid.
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// Gets or sets the media_id.
        /// </summary>
        [JsonPropertyName("media_id")]
        public double Media_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logo_id.
        /// </summary>
        [JsonPropertyName("logo_id")]
        public double Logo_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        [JsonPropertyName("index")]
        public double Index { get; set; } = default!;

        /// <summary>
        /// Gets or sets the progress.
        /// </summary>
        [JsonPropertyName("progress")]
        public string Progress { get; set; } = default!;

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
        /// Gets or sets the activities.
        /// </summary>
        [JsonPropertyName("activities")]
        public ICollection<Api_MediaActivity> Activities { get; set; } = default!;

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        [JsonPropertyName("link")]
        public Api_Link Link { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        [JsonPropertyName("logo")]
        public ICollection<Api_Logo> Logo { get; set; } = default!;

        /// <summary>
        /// Gets or sets the media.
        /// </summary>
        [JsonPropertyName("media")]
        public ICollection<Api_Media> Media { get; set; } = default!;

        /// <summary>
        /// Gets or sets the uuid sequence.
        /// </summary>
        [JsonPropertyName("uuidSequence")]
        public Api_UuidSequence UuidSequence { get; set; } = default!;
    }
}