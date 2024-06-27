namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The v1xml.
    /// </summary>
    public partial class V1xml : Data
    {
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
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public Data Data { get; set; } = default!;
    }
}