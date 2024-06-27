namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body39.
    /// </summary>
    public partial class Body39 : Data
    {
        /// <summary>
        /// List of emails to invite
        /// </summary>

        [JsonPropertyName("emails")]
        public ICollection<string> Emails { get; set; } = default!;

        /// <summary>
        /// Message to be sent
        /// </summary>

        [JsonPropertyName("message")]
        public string? Message { get; set; } = default!;

        /// <summary>
        /// List of user ids to invite by mail. Users must be in the drive's organisation
        /// </summary>

        [JsonPropertyName("user_ids")]
        public ICollection<int> User_ids { get; set; } = default!;
    }
}