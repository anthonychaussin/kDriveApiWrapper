namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The yml.
    /// </summary>
    public partial class Yml : Data
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
        public Data _data { get; set; } = default!;
    }
}