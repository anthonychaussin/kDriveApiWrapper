namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The closinguploadsession.
    /// </summary>
    public partial class Closinguploadsession : Data
    {
        /// <summary>
        /// Upload session token
        /// </summary>

        [JsonPropertyName("token")]
        public string? Token { get; set; } = default!;

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        [JsonPropertyName("file")]
        [System.ComponentModel.DataAnnotations.Required]
        public File File { get; set; } = new File();

        /// <summary>
        /// Upload session was closed
        /// </summary>

        [JsonPropertyName("result")]
        public bool Result { get; set; } = default!;

        /// <summary>
        /// Additional message about the closed upload session
        /// </summary>

        [JsonPropertyName("message")]
        public string? Message { get; set; } = default!;
    }
}