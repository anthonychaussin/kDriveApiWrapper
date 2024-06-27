namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body38.
    /// </summary>
    public partial class Body38 : Data
    {
        /// <summary>
        /// Alias of the collaborative folder
        /// </summary>

        [JsonPropertyName("alias")]
        public string? Alias { get; set; } = default!;

        /// <summary>
        /// Send an email when done
        /// </summary>

        [JsonPropertyName("email_when_finished")]
        public bool Email_when_finished { get; set; } = default!;

        /// <summary>
        /// Maximum accepted file size (bytes)
        /// </summary>

        [JsonPropertyName("limit_file_size")]
        public int? Limit_file_size { get; set; } = default!;

        /// <summary>
        /// Password for protecting the collaborative folder
        /// </summary>

        [JsonPropertyName("password")]
        public string? Password { get; set; } = default!;

        /// <summary>
        /// Maximum validity date
        /// </summary>

        [JsonPropertyName("valid_until")]
        public int? Valid_until { get; set; } = default!;
    }
}