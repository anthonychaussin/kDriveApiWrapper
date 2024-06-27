namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The capabilities8.
    /// </summary>
    public partial class Capabilities8 : Data
    {
        /// <summary>
        /// Right to set file as favorite
        /// </summary>

        [JsonPropertyName("can_use_favorite")]
        public bool Can_use_favorite { get; set; } = default!;

        /// <summary>
        /// Right to share file by link (share_link)
        /// </summary>

        [JsonPropertyName("can_become_sharelink")]
        public bool Can_become_sharelink { get; set; } = default!;

        /// <summary>
        /// Right to use and give team access
        /// </summary>

        [JsonPropertyName("can_use_team")]
        public bool Can_use_team { get; set; } = default!;

        /// <summary>
        /// Right to see Shared Generic File information
        /// </summary>

        [JsonPropertyName("can_show")]
        public bool Can_show { get; set; } = default!;

        /// <summary>
        /// Right to read Shared Generic File content
        /// </summary>

        [JsonPropertyName("can_read")]
        public bool Can_read { get; set; } = default!;

        /// <summary>
        /// Right to write Shared Generic File
        /// </summary>

        [JsonPropertyName("can_write")]
        public bool Can_write { get; set; } = default!;

        /// <summary>
        /// Right to share Shared Generic File or manage access to Shared Generic File
        /// </summary>

        [JsonPropertyName("can_share")]
        public bool Can_share { get; set; } = default!;

        /// <summary>
        /// Right to leave shared Shared Generic File
        /// </summary>

        [JsonPropertyName("can_leave")]
        public bool Can_leave { get; set; } = default!;

        /// <summary>
        /// Right to delete Shared Generic File
        /// </summary>

        [JsonPropertyName("can_delete")]
        public bool Can_delete { get; set; } = default!;

        /// <summary>
        /// Right to rename Shared Generic File
        /// </summary>

        [JsonPropertyName("can_rename")]
        public bool Can_rename { get; set; } = default!;

        /// <summary>
        /// Right to move Shared Generic File
        /// </summary>

        [JsonPropertyName("can_move")]
        public bool Can_move { get; set; } = default!;
    }
}