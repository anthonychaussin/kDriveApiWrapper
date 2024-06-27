namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The capabilities6.
    /// </summary>
    public partial class Capabilities6 : Data
    {
        /// <summary>
        /// A password was defined to access to the dropbox
        /// </summary>

        [JsonPropertyName("has_password")]
        public bool Has_password { get; set; } = default!;

        /// <summary>
        /// Notification was enabled on the dropbox, email we be send to dropbox owner when someone upload a file
        /// </summary>

        [JsonPropertyName("has_notification")]
        public bool Has_notification { get; set; } = default!;

        /// <summary>
        /// A validity period was set to the dropbox, after the date define the dropbox is not accessible
        /// </summary>

        [JsonPropertyName("has_validity")]
        public bool Has_validity { get; set; } = default!;

        /// <summary>
        /// A limit size was defined to the dropbox, after the date define the dropbox is not accessible
        /// </summary>

        [JsonPropertyName("has_size_limit")]
        public bool Has_size_limit { get; set; } = default!;

        /// <summary>
        /// Gets or sets the validity.
        /// </summary>
        [JsonPropertyName("validity")]
        public string Validity { get; set; } = default!;

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        [JsonPropertyName("size")]
        public string Size { get; set; } = default!;
    }
}