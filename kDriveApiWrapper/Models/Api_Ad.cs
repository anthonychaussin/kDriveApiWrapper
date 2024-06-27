namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Ad
    /// </summary>

    public partial class Api_Ad
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Gets or sets the mimetype.
        /// </summary>
        [JsonPropertyName("mimetype")]
        public string Mimetype { get; set; } = default!;

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_AdType Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the offset.
        /// </summary>
        [JsonPropertyName("offset")]
        public string Offset { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tracking_id.
        /// </summary>
        [JsonPropertyName("tracking_id")]
        public string Tracking_id { get; set; } = default!;
    }
}