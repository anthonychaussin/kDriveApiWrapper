namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The file access.
    /// </summary>
    public partial class FileAccess : Data
    {
        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        [JsonPropertyName("users")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<Userfileaccess> Users { get; set; } = [];

        /// <summary>
        /// Gets or sets the teams.
        /// </summary>
        [JsonPropertyName("teams")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<TeamFileAccess> Teams { get; set; } = [];

        /// <summary>
        /// Gets or sets the invitations.
        /// </summary>
        [JsonPropertyName("invitations")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<ExternInvitationFileAccess> Invitations { get; set; } = [];
    }
}