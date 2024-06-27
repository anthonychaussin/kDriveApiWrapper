namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The app error.
    /// </summary>
    public partial class AppError : Error
    {
        /// <summary>
        /// Gets or sets the status_code.
        /// </summary>
        [JsonPropertyName("status_code")]
        public int Status_code { get; set; } = default!;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Gets or sets the request_id.
        /// </summary>
        [JsonPropertyName("request_id")]
        public string Request_id { get; set; } = default!;
    }
}