namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The preference.
    /// </summary>
    public partial class Preference : Data
    {
        /// <summary>
        /// Default color for drive
        /// </summary>

        [JsonPropertyName("color")]
        public string Color { get; set; } = default!;

        /// <summary>
        /// Is the drive hidden for the current user
        /// </summary>

        [JsonPropertyName("hide")]
        public bool Hide { get; set; } = default!;

        /// <summary>
        /// The default drive chosen by the user, if none the first drive in the list should be considered the default. There should only be one default drive.
        /// </summary>

        [JsonPropertyName("default")]
        public bool Default { get; set; } = default!;

        /// <summary>
        /// User's default landing page
        /// </summary>

        [JsonPropertyName("default_page")]
        public string Default_page { get; set; } = default!;
    }
}