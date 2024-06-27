namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Link
    /// </summary>

    public partial class Download_Link
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
        /// Gets or sets the size.
        /// </summary>
        [JsonPropertyName("size")]
        public double Size { get; set; } = default!;

        /// <summary>
        /// Gets or sets the size_human_readable.
        /// </summary>
        [JsonPropertyName("size_human_readable")]
        public string Size_human_readable { get; set; } = default!;
    }
}