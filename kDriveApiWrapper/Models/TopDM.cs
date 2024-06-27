namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The top d m.
    /// </summary>
    public partial class TopDM : Data
    {
        /// <summary>
        /// Gets or sets the post_count.
        /// </summary>
        [JsonPropertyName("post_count")]
        public long Post_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the outgoing_message_count.
        /// </summary>
        [JsonPropertyName("outgoing_message_count")]
        public long Outgoing_message_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the second_participant.
        /// </summary>
        [JsonPropertyName("second_participant")]
        public TopDMInsightUserInformation Second_participant { get; set; } = default!;
    }
}