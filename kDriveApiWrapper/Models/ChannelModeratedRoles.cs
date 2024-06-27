namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The channel moderated roles.
    /// </summary>
    public partial class ChannelModeratedRoles : Data
    {
        /// <summary>
        /// Gets or sets the guests.
        /// </summary>
        [JsonPropertyName("guests")]
        public ChannelModeratedRole Guests { get; set; } = default!;

        /// <summary>
        /// Gets or sets the members.
        /// </summary>
        [JsonPropertyName("members")]
        public ChannelModeratedRole Members { get; set; } = default!;
    }
}