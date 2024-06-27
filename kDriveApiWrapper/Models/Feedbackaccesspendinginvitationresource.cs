namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The feedbackaccesspendinginvitationresource.
    /// </summary>
    public partial class Feedbackaccesspendinginvitationresource : Data
    {
        /// <summary>
        /// The pending invitation of the file, if any
        /// </summary>

        [JsonPropertyName("invitation_id")]
        public int? Invitation_id { get; set; } = default!;

        /// <summary>
        /// The pending invitation of the drive if any
        /// </summary>

        [JsonPropertyName("drive_invitation_id")]
        public int? Drive_invitation_id { get; set; } = default!;

        /// <summary>
        /// If there is at least a file or drive pending invitation on the drive
        /// </summary>

        [JsonPropertyName("has_invitation")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Has_invitation { get; set; } = default!;

        /// <summary>
        /// The user id asked
        /// </summary>

        [JsonPropertyName("user_id")]
        public int User_id { get; set; } = default!;

        /// <summary>
        /// The email asked
        /// </summary>

        [JsonPropertyName("email")]
        public string Email { get; set; } = default!;
    }
}