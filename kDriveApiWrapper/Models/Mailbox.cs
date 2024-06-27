namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The mailbox.
    /// </summary>
    public partial class Mailbox : MailboxBase
    {
        /// <summary>
        /// True if mailbox has rate limit
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_limited")]
        public bool Is_limited { get; set; } = default!;

        /// <summary>
        /// True if mailbox belongs to free mail service
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_free_mail")]
        public bool Is_free_mail { get; set; } = default!;

        /// <summary>
        /// Mailbox's fullname
        /// <br/>
        /// <br/>**This field is provided only if you have set with=full_name**
        /// </summary>

        [JsonPropertyName("full_name")]
        public string Full_name { get; set; } = default!;

        /// <summary>
        /// True if has_auto_responder is enabled
        /// <br/>
        /// <br/>**This field is provided only if you have set with=has_auto_responder**
        /// </summary>

        [JsonPropertyName("has_auto_responder")]
        public bool Has_auto_responder { get; set; } = default!;

        /// <summary>
        /// Gets or sets the auto_responder.
        /// </summary>
        [JsonPropertyName("auto_responder")]
        public MailboxAutoReply Auto_responder { get; set; } = default!;

        /// <summary>
        /// True if has at least one redirection
        /// <br/>
        /// <br/>**This field is provided only if you have set with=redirection**
        /// </summary>

        [JsonPropertyName("has_redirection")]
        public bool Has_redirection { get; set; } = default!;

        /// <summary>
        /// Gets or sets the redirections.
        /// </summary>
        [JsonPropertyName("redirections")]
        public ICollection<string> Redirections { get; set; } = default!;

        /// <summary>
        /// Gets or sets the aliases.
        /// </summary>
        [JsonPropertyName("aliases")]
        public ICollection<string> Aliases { get; set; } = default!;

        /// <summary>
        /// Gets or sets the full_aliases.
        /// </summary>
        [JsonPropertyName("full_aliases")]
        public ICollection<string> Full_aliases { get; set; } = default!;

        /// <summary>
        /// Creation date
        /// <br/>
        /// <br/>**This field is provided only if you have set with=created_at**
        /// </summary>

        [JsonPropertyName("created_at")]
        public int? Created_at { get; set; } = default!;

        /// <summary>
        /// Last password change date
        /// <br/>
        /// <br/>**This field is provided only if you have set with=password_last_changed_at**
        /// </summary>

        [JsonPropertyName("password_last_changed_at")]
        public int? Password_last_changed_at { get; set; } = default!;

        /// <summary>
        /// Mailbox size in ko
        /// <br/>
        /// <br/>**This field is provided only if you have set with=size**
        /// </summary>

        [JsonPropertyName("size")]
        public int? Size { get; set; } = default!;

        /// <summary>
        /// Last mailbox size verification date
        /// <br/>
        /// <br/>**This field is provided only if you have set with=last_login**
        /// </summary>

        [JsonPropertyName("size_checked_at")]
        public int? Size_checked_at { get; set; } = default!;

        /// <summary>
        /// Last login date from imap protocol, unix timestamp
        /// <br/>
        /// <br/>**This field is provided only if you have set with=last_login**
        /// </summary>

        [JsonPropertyName("imap_last_login_at")]
        public int? Imap_last_login_at { get; set; } = default!;

        /// <summary>
        /// Last login date from imap protocol, unix timestamp
        /// <br/>
        /// <br/>**This field is provided only if you have set with=size**
        /// </summary>

        [JsonPropertyName("pop3_last_login_at")]
        public int? Pop3_last_login_at { get; set; } = default!;

        /// <summary>
        /// True if blocking operation is currently in progress on this service
        /// <br/>
        /// <br/>**This field is provided only if you have set with=operation_in_progress**
        /// </summary>

        [JsonPropertyName("operation_in_progress")]
        public bool Operation_in_progress { get; set; } = default!;

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        [JsonPropertyName("users")]
        public ICollection<MailUser> Users { get; set; } = default!;

        /// <summary>
        /// True if has at least one redirection
        /// <br/>
        /// <br/>**This field is provided only if you have set with=has_move_spam**
        /// </summary>

        [JsonPropertyName("has_move_spam")]
        public bool Has_move_spam { get; set; } = default!;

        /// <summary>
        /// Gets or sets the authorized_senders.
        /// </summary>
        [JsonPropertyName("authorized_senders")]
        public ICollection<string> Authorized_senders { get; set; } = default!;

        /// <summary>
        /// Gets or sets the blocked_senders.
        /// </summary>
        [JsonPropertyName("blocked_senders")]
        public ICollection<string> Blocked_senders { get; set; } = default!;

        /// <summary>
        /// True if dkim signature is activated
        /// <br/>
        /// <br/>**This field is provided only if you have set with=has_dkim_signature**
        /// </summary>

        [JsonPropertyName("has_dkim_signature")]
        public bool Has_dkim_signature { get; set; } = default!;

        /// <summary>
        /// True if dkim signature can be updated
        /// <br/>
        /// <br/>**This field is provided only if you have set with=is_dkim_updatable**
        /// </summary>

        [JsonPropertyName("is_dkim_updatable")]
        public bool Is_dkim_updatable { get; set; } = default!;

        /// <summary>
        /// True if Commercial and SocialNetwork filters are activated
        /// <br/>
        /// <br/>**This field is provided only if you have set with=has_mail_filtering**
        /// </summary>

        [JsonPropertyName("has_mail_filtering")]
        public bool Has_mail_filtering { get; set; } = default!;

        /// <summary>
        /// Folder for Commercial emails filter
        /// <br/>
        /// <br/>**This field is provided only if you have set with=mail_filtering_folder_commercials**
        /// </summary>

        [JsonPropertyName("mail_filtering_folder_commercials")]
        public string Mail_filtering_folder_commercials { get; set; } = default!;

        /// <summary>
        /// Folder for SocialNetwork emails filter
        /// <br/>
        /// <br/>**This field is provided only if you have set with=mail_filtering_folder_social_networks**
        /// </summary>

        [JsonPropertyName("mail_filtering_folder_social_networks")]
        public string Mail_filtering_folder_social_networks { get; set; } = default!;

        /// <summary>
        /// True if user is authenticated with this mailbox
        /// <br/>
        /// <br/>**This field is provided only if you have set with=auth**
        /// </summary>

        [JsonPropertyName("is_auth")]
        public bool Is_auth { get; set; } = default!;

        /// <summary>
        /// True if mailbox is is_removable. Note: is always true
        /// <br/>
        /// <br/>**This field is provided only if you have set with=is_removable**
        /// </summary>

        [JsonPropertyName("is_removable")]
        public bool Is_removable { get; set; } = default!;

        /// <summary>
        /// Gets or sets the permissions.
        /// </summary>
        [JsonPropertyName("permissions")]
        public MailMailboxPermissions Permissions { get; set; } = default!;

        /// <summary>
        /// Identifier of this mailbox
        /// <br/>
        /// <br/>**This field is provided only if you have set with=mailbox_id**
        /// </summary>

        [JsonPropertyName("mailbox_id")]
        public int Mailbox_id { get; set; } = default!;
    }
}