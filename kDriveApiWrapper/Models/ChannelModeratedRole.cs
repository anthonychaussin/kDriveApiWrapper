namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The channel moderated role.
    /// </summary>
    public partial class ChannelModeratedRole : Data
    {
        /// <summary>
        /// Gets or sets a value indicating whether value.
        /// </summary>
        [JsonPropertyName("value")]
        public bool Value { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; } = default!;
    }
}