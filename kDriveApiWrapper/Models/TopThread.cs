namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The top thread.
    /// </summary>
    public partial class TopThread : Data
    {
        /// <summary>
        /// Gets or sets the post.
        /// </summary>
        [JsonPropertyName("post")]
        public Post Post { get; set; } = default!;

        /// <summary>
        /// Gets or sets the channel_id.
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string Channel_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the channel_display_name.
        /// </summary>
        [JsonPropertyName("channel_display_name")]
        public string Channel_display_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the channel_name.
        /// </summary>
        [JsonPropertyName("channel_name")]
        public string Channel_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the participants.
        /// </summary>
        [JsonPropertyName("Participants")]
        public ICollection<string> Participants { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_information.
        /// </summary>
        [JsonPropertyName("user_information")]
        public InsightUserInformation User_information { get; set; } = default!;
    }
}