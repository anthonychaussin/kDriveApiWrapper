namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The channel notify props.
    /// </summary>
    public partial class ChannelNotifyProps : Data
    {
        /// <summary>
        /// Set to "true" to enable email notifications, "false" to disable, or "default" to use the global user notification setting.
        /// </summary>

        [JsonPropertyName("email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Set to "all" to receive push notifications for all activity, "mention" for mentions and direct messages only, "none" to disable, or "default" to use the global user notification setting.
        /// </summary>

        [JsonPropertyName("push")]
        public string Push { get; set; } = default!;

        /// <summary>
        /// Set to "all" to receive desktop notifications for all activity, "mention" for mentions and direct messages only, "none" to disable, or "default" to use the global user notification setting.
        /// </summary>

        [JsonPropertyName("desktop")]
        public string Desktop { get; set; } = default!;

        /// <summary>
        /// Set to "all" to mark the channel unread for any new message, "mention" to mark unread for new mentions only. Defaults to "all".
        /// </summary>

        [JsonPropertyName("mark_unread")]
        public string Mark_unread { get; set; } = default!;
    }
}