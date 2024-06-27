namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The workspace user mailbox.
    /// </summary>
    public partial class WorkspaceUserMailbox : MailboxBase
    {
        /// <summary>
        /// Gets or sets the permissions.
        /// </summary>
        [JsonPropertyName("permissions")]
        public MailPermissions Permissions { get; set; } = default!;
    }
}