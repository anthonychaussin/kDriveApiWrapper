namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The feedbackaccessresource_c3fdaa7f.
    /// </summary>
    public partial class Feedbackaccessresource_c3fdaa7f
    {
        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        [JsonPropertyName("emails")]
        public ICollection<Feedbackaccessresource> Emails { get; set; } = default!;

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        [JsonPropertyName("users")]
        public ICollection<Feedbackaccessresource> Users { get; set; } = default!;

        /// <summary>
        /// Gets or sets the teams.
        /// </summary>
        [JsonPropertyName("teams")]
        public ICollection<Feedbackaccessresource> Teams { get; set; } = default!;
    }
}