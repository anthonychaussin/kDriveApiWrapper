namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body17.
    /// </summary>
    public partial class Body17 : Data
    {
        /// <summary>
        /// Application to import
        /// </summary>

        [JsonPropertyName("application")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body17Application Application { get; set; } = default!;

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