namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The mail user.
    /// </summary>
    public partial class MailUser : Data
    {
        /// <summary>
        /// WorkspaceUser identifier
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Email
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Name
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// True if deleted
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_deleted")]
        public bool Is_deleted { get; set; } = default!;

        /// <summary>
        /// Avatar url
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; } = default!;

        /// <summary>
        /// Last login timestamp
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("last_login_at")]
        public object Last_login_at { get; set; } = default!;

        /// <summary>
        /// True if double authentication is enabled
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("has_double_auth")]
        public bool Has_double_auth { get; set; } = default!;

        /// <summary>
        /// Gets or sets the permissions.
        /// </summary>
        [JsonPropertyName("permissions")]
        public MailPermissions Permissions { get; set; } = default!;
    }
}