namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The capabilities2.
    /// </summary>
    public partial class Capabilities2 : Data
    {
        /// <summary>
        /// Gets or sets a value indicating whether can_create_team_directory.
        /// </summary>
        [JsonPropertyName("can_create_team_directory")]
        public bool Can_create_team_directory { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether can_set_trash_duration.
        /// </summary>
        [JsonPropertyName("can_set_trash_duration")]
        public bool Can_set_trash_duration { get; set; } = default!;

        /// <summary>
        /// Whether the `Drive User` has the permission to perform technical operations
        /// </summary>

        [JsonPropertyName("has_technical_permission")]
        public bool Has_technical_permission { get; set; } = default!;
    }
}