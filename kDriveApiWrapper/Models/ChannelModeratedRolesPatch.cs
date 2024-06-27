namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The channel moderated roles patch.
    /// </summary>
    public partial class ChannelModeratedRolesPatch : Data
    {
        /// <summary>
        /// Gets or sets a value indicating whether guests.
        /// </summary>
        [JsonPropertyName("guests")]
        public bool Guests { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether members.
        /// </summary>
        [JsonPropertyName("members")]
        public bool Members { get; set; } = default!;
    }
}