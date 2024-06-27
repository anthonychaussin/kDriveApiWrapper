namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// Import
    /// </summary>
    public partial class Import : Data
    {

        /// <summary>
        /// ID of the authentication token for the application
        /// </summary>

        [JsonPropertyName("access_token_id")]
        public int Access_token_id { get; set; } = default!;

        /// <summary>
        /// Authentication code of the application
        /// </summary>

        [JsonPropertyName("auth_code")]
        public string Auth_code { get; set; } = default!;

        /// <summary>
        /// Application to import
        /// </summary>

        [JsonPropertyName("application")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ImportApplicationSource Application { get; set; } = default!;

        /// <summary>
        /// Id of the kDrive containing the content to import
        /// </summary>

        [JsonPropertyName("application_drive_id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Application_drive_id { get; set; } = default!;

        /// <summary>
        /// Destination directory identifier
        /// </summary>

        [JsonPropertyName("directory_id")]
        public int Directory_id { get; set; } = default!;

        /// <summary>
        /// Webdav endpoint
        /// </summary>

        [JsonPropertyName("endpoint")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Endpoint { get; set; } = default!;

        /// <summary>
        /// Webdav login
        /// </summary>

        [JsonPropertyName("login")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// Webdav password
        /// </summary>

        [JsonPropertyName("password")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Password { get; set; } = default!;
    }
}