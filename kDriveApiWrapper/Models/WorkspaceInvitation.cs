namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The workspace invitation.
    /// </summary>
    public partial class WorkspaceInvitation : Data
    {
        /// <summary>
        /// Invitation url
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("short_url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Short_url { get; set; } = default!;

        /// <summary>
        /// Key
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("key")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Invitation recipient email address
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("sent_to")]
        public string? Sent_to { get; set; } = default!;

        /// <summary>
        /// Gets or sets the permissions.
        /// </summary>
        [JsonPropertyName("permissions")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<MailPermissions> Permissions { get; set; } = [];

        /// <summary>
        /// Expired date
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("expired_at")]
        public int Expired_at { get; set; } = default!;

        /// <summary>
        /// True if still valid
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_valid")]
        public bool Is_valid { get; set; } = default!;

        /// <summary>
        /// True if invitation has been accepted
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_used")]
        public bool Is_used { get; set; } = default!;

        /// <summary>
        /// Gets or sets the mailbox.
        /// </summary>
        [JsonPropertyName("mailbox")]
        public MailboxBase Mailbox { get; set; } = default!;

        /// <summary>
        /// QR Code url
        /// <br/>
        /// <br/>**This field is provided only if you have set with=qrcode**
        /// </summary>

        [JsonPropertyName("qrcode")]
        public byte[] Qrcode { get; set; } = default!;
    }
}