namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The mail mailbox permissions.
    /// </summary>
    public partial class MailMailboxPermissions : MailPermissions
    {
        /// <summary>
        /// Has technical right
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("has_technical_right")]
        public bool Has_technical_right { get; set; } = default!;

        /// <summary>
        /// Is linked to user
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_linked_to_user")]
        public bool Is_linked_to_user { get; set; } = default!;
    }
}