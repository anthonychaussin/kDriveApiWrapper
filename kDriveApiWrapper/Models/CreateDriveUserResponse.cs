namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The create drive user response.
    /// </summary>
    public partial class CreateDriveUserResponse : Data
    {
        /// <summary>
        /// Gets or sets the invitation.
        /// </summary>
        [JsonPropertyName("invitation")]
        public DriveUserInvitation Invitation { get; set; } = default!;

        /// <summary>
        /// Gets or sets the drive_user.
        /// </summary>
        [JsonPropertyName("drive_user")]
        public DriveUser Drive_user { get; set; } = default!;

        /// <summary>
        /// Error message when applicable
        /// </summary>

        [JsonPropertyName("error")]
        public string Error { get; set; } = default!;

        /// <summary>
        /// when no invitation or drive_user
        /// </summary>

        [JsonPropertyName("user_id")]
        public int User_id { get; set; } = default!;

        /// <summary>
        /// when no invitation or drive_user
        /// </summary>

        [JsonPropertyName("email")]
        public string Email { get; set; } = default!;
    }
}