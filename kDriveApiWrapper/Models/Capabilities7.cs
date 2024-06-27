namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The capabilities7.
    /// </summary>
    public partial class Capabilities7 : Data
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
        /// Right to see Directory information
        /// </summary>

        [JsonPropertyName("can_show")]
        public bool Can_show { get; set; } = default!;

        /// <summary>
        /// Right to read Directory content
        /// </summary>

        [JsonPropertyName("can_read")]
        public bool Can_read { get; set; } = default!;

        /// <summary>
        /// Right to write Directory
        /// </summary>

        [JsonPropertyName("can_write")]
        public bool Can_write { get; set; } = default!;

        /// <summary>
        /// Right to share Directory or manage access to Directory
        /// </summary>

        [JsonPropertyName("can_share")]
        public bool Can_share { get; set; } = default!;

        /// <summary>
        /// Right to leave shared Directory
        /// </summary>

        [JsonPropertyName("can_leave")]
        public bool Can_leave { get; set; } = default!;

        /// <summary>
        /// Right to delete Directory
        /// </summary>

        [JsonPropertyName("can_delete")]
        public bool Can_delete { get; set; } = default!;

        /// <summary>
        /// Right to rename Directory
        /// </summary>

        [JsonPropertyName("can_rename")]
        public bool Can_rename { get; set; } = default!;

        /// <summary>
        /// Right to move Directory
        /// </summary>

        [JsonPropertyName("can_move")]
        public bool Can_move { get; set; } = default!;

        /// <summary>
        /// Right to add new child directory
        /// </summary>

        [JsonPropertyName("can_create_directory")]
        public bool Can_create_directory { get; set; } = default!;

        /// <summary>
        /// Right to add new child file
        /// </summary>

        [JsonPropertyName("can_create_file")]
        public bool Can_create_file { get; set; } = default!;

        /// <summary>
        /// Right to upload a child file
        /// </summary>

        [JsonPropertyName("can_upload")]
        public bool Can_upload { get; set; } = default!;

        /// <summary>
        /// right to move directory
        /// </summary>

        [JsonPropertyName("can_move_into")]
        public bool Can_move_into { get; set; } = default!;

        /// <summary>
        /// Right to use convert directory into collaborative directory
        /// </summary>

        [JsonPropertyName("can_become_dropbox")]
        public bool Can_become_dropbox { get; set; } = default!;
    }
}