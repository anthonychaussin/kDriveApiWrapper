namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The userconnection.
    /// </summary>
    public partial class Userconnection : Data
    {
        /// <summary>
        /// Gets or sets a value indicating whether unsuccessful_limit.
        /// </summary>
        [JsonPropertyName("unsuccessful_limit")]
        public bool Unsuccessful_limit { get; set; } = default!;

        /// <summary>
        /// Gets or sets the unsuccessful_rate_limit.
        /// </summary>
        [JsonPropertyName("unsuccessful_rate_limit")]
        public int Unsuccessful_rate_limit { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether unsuccessful_notification.
        /// </summary>
        [JsonPropertyName("unsuccessful_notification")]
        public bool Unsuccessful_notification { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether successful_notification.
        /// </summary>
        [JsonPropertyName("successful_notification")]
        public bool Successful_notification { get; set; } = default!;
    }
}