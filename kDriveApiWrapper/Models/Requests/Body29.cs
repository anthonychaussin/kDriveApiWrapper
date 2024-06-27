namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body29.
    /// </summary>
    public partial class Body29 : Data
    {
        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        [JsonPropertyName("emails")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public ICollection<string> Emails { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_ids.
        /// </summary>
        [JsonPropertyName("user_ids")]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public ICollection<int> User_ids { get; set; } = default!;
    }
}