namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body35.
    /// </summary>
    public partial class Body35 : Data
    {
        /// <summary>
        /// Allow users to to comment the shared files. It takes the same value as can_edit if unset or null
        /// </summary>

        [JsonPropertyName("can_comment")]
        public bool Can_comment { get; set; } = default!;

        /// <summary>
        /// Allow users to download shared content
        /// </summary>

        [JsonPropertyName("can_download")]
        public bool Can_download { get; set; } = default!;

        /// <summary>
        /// Allow users to edit the file content using the shared link
        /// </summary>

        [JsonPropertyName("can_edit")]
        public bool Can_edit { get; set; } = default!;

        /// <summary>
        /// Allow users to see information about the shared files
        /// </summary>

        [JsonPropertyName("can_see_info")]
        public bool Can_see_info { get; set; } = default!;

        /// <summary>
        /// Allow users to see statistics
        /// </summary>

        [JsonPropertyName("can_see_stats")]
        public bool Can_see_stats { get; set; } = default!;

        /// <summary>
        /// The password if the permission password is set
        /// </summary>

        [JsonPropertyName("password")]
        public string Password { get; set; } = default!;

        /// <summary>
        /// Permission of the shared link: no restriction (public), access by authenticated and authorized user (inherit) or public but protected by a password (password)
        /// </summary>

        [JsonPropertyName("right")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body35Right Right { get; set; } = default!;

        /// <summary>
        /// Maximum validity timestamp of the shared link
        /// </summary>

        [JsonPropertyName("valid_until")]
        public int? Valid_until { get; set; } = default!;
    }
}