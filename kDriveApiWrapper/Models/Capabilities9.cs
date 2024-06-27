namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The capabilities9.
    /// </summary>
    public partial class Capabilities9 : Data
    {
        /// <summary>
        /// Vault directory feature
        /// </summary>

        [JsonPropertyName("use_vault")]
        public bool Use_vault { get; set; } = default!;

        /// <summary>
        /// Can use additional manage right
        /// </summary>

        [JsonPropertyName("use_manage_right")]
        public bool Use_manage_right { get; set; } = default!;

        /// <summary>
        /// Can change the max days in trash
        /// </summary>

        [JsonPropertyName("can_set_trash_duration")]
        public bool Can_set_trash_duration { get; set; } = default!;

        /// <summary>
        /// Dropboxes feature
        /// </summary>

        [JsonPropertyName("use_dropbox")]
        public bool Use_dropbox { get; set; } = default!;

        /// <summary>
        /// Can access/use restoration feature
        /// </summary>

        [JsonPropertyName("can_rewind")]
        public bool Can_rewind { get; set; } = default!;

        /// <summary>
        /// Can set a custom color on a folder
        /// </summary>

        [JsonPropertyName("use_folder_custom_color")]
        public bool Use_folder_custom_color { get; set; } = default!;

        /// <summary>
        /// Can access the managing dashboard
        /// </summary>

        [JsonPropertyName("can_access_dashboard")]
        public bool Can_access_dashboard { get; set; } = default!;

        /// <summary>
        /// Public link can expire
        /// </summary>

        [JsonPropertyName("can_set_sharelink_password")]
        public bool Can_set_sharelink_password { get; set; } = default!;

        /// <summary>
        /// Public link can be protected by password
        /// </summary>

        [JsonPropertyName("can_set_sharelink_expiration")]
        public bool Can_set_sharelink_expiration { get; set; } = default!;

        /// <summary>
        /// Public link can have custom theme
        /// </summary>

        [JsonPropertyName("can_set_sharelink_custom_url")]
        public bool Can_set_sharelink_custom_url { get; set; } = default!;

        /// <summary>
        /// Can activate advanced search functions in file contents
        /// </summary>

        [JsonPropertyName("can_use_content_search")]
        public bool Can_use_content_search { get; set; } = default!;
    }
}