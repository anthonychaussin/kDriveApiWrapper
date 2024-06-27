namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The strategy.
    /// </summary>
    public partial class Strategy : Data
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
        /// Gets or sets the _data.
        /// </summary>
        [JsonPropertyName(" data")]
        public _data _data { get; set; } = default!;
    }
}