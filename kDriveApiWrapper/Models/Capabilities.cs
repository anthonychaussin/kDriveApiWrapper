namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The capabilities.
    /// </summary>
    public partial class Capabilities : Data
    {
        /// <summary>
        /// Is versioning activated
        /// </summary>

        [JsonPropertyName("use_versioning")]
        public bool Use_versioning { get; set; } = default!;

        /// <summary>
        /// During upload compression is allowed
        /// </summary>

        [JsonPropertyName("use_upload_compression")]
        public bool Use_upload_compression { get; set; } = default!;

        /// <summary>
        /// Shared/Team directory feature
        /// </summary>

        [JsonPropertyName("use_team_space")]
        public bool Use_team_space { get; set; } = default!;

        /// <summary>
        /// Can add an user in the kDrive
        /// </summary>

        [JsonPropertyName("can_add_user")]
        public bool Can_add_user { get; set; } = default!;

        /// <summary>
        /// Can see stats of the kDrive
        /// </summary>

        [JsonPropertyName("can_see_stats")]
        public bool Can_see_stats { get; set; } = default!;

        /// <summary>
        /// Can the drive be upgraded to a kSuite
        /// </summary>

        [JsonPropertyName("can_upgrade_to_ksuite")]
        public bool Can_upgrade_to_ksuite { get; set; } = default!;

        /// <summary>
        /// Can rewind the kDrive
        /// </summary>

        [JsonPropertyName("can_rewind")]
        public bool Can_rewind { get; set; } = default!;
    }
}