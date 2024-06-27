namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body18.
    /// </summary>
    public partial class Body18 : Data
    {
        /// <summary>
        /// ID of the authentication token for the application
        /// </summary>

        [JsonPropertyName("access_token_id")]
        public int Access_token_id { get; set; } = default!;

        /// <summary>
        /// Application to import
        /// </summary>

        [JsonPropertyName("application")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body18Application Application { get; set; } = default!;

        /// <summary>
        /// Application drive id selected
        /// </summary>

        [JsonPropertyName("application_drive_id")]
        public string Application_drive_id { get; set; } = default!;

        /// <summary>
        /// Authentication code of the application
        /// </summary>

        [JsonPropertyName("auth_code")]
        public string Auth_code { get; set; } = default!;

        /// <summary>
        /// Destination directory identifier
        /// </summary>

        [JsonPropertyName("directory_id")]
        public int Directory_id { get; set; } = default!;
    }
}