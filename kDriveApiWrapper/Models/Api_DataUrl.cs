namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// dataUrl
    /// </summary>

    public partial class Api_DataUrl
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Gets or sets the mimetype.
        /// </summary>
        [JsonPropertyName("mimetype")]
        public string Mimetype { get; set; } = default!;

        /// <summary>
        /// Gets or sets the encoding.
        /// </summary>
        [JsonPropertyName("encoding")]
        public string Encoding { get; set; } = default!;
    }
}