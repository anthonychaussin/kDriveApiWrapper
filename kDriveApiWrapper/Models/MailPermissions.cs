namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Permissions
    /// </summary>

    public partial class MailPermissions : Data
    {
        /// <summary>
        /// Manage filters
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("can_manage_filters")]
        public bool Can_manage_filters { get; set; } = default!;

        /// <summary>
        /// Manage security
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("can_manage_security")]
        public bool Can_manage_security { get; set; } = default!;

        /// <summary>
        /// Manage aliases
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("can_manage_aliases")]
        public bool Can_manage_aliases { get; set; } = default!;

        /// <summary>
        /// Manage redirections
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("can_manage_redirections")]
        public bool Can_manage_redirections { get; set; } = default!;

        /// <summary>
        /// Manage signatures
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("can_manage_signatures")]
        public bool Can_manage_signatures { get; set; } = default!;

        /// <summary>
        /// Manage auto reply
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("can_manage_auto_reply")]
        public bool Can_manage_auto_reply { get; set; } = default!;

        /// <summary>
        /// Change password
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("can_change_password")]
        public bool Can_change_password { get; set; } = default!;

        /// <summary>
        /// Configure mail folders
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("can_configure_mail_folders")]
        public bool Can_configure_mail_folders { get; set; } = default!;
    }
}