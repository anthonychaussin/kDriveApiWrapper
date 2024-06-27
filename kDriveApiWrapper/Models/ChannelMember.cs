namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The channel member.
    /// </summary>
    public partial class ChannelMember : Data
    {
        /// <summary>
        /// Gets or sets the channel_id.
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string Channel_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_id.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string User_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        [JsonPropertyName("roles")]
        public string Roles { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds the channel was last viewed by the user
        /// </summary>

        [JsonPropertyName("last_viewed_at")]
        public long Last_viewed_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the msg_count.
        /// </summary>
        [JsonPropertyName("msg_count")]
        public int Msg_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the mention_count.
        /// </summary>
        [JsonPropertyName("mention_count")]
        public int Mention_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the notify_props.
        /// </summary>
        [JsonPropertyName("notify_props")]
        public ChannelNotifyProps Notify_props { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds the channel member was last updated
        /// </summary>

        [JsonPropertyName("last_update_at")]
        public long Last_update_at { get; set; } = default!;
    }
}