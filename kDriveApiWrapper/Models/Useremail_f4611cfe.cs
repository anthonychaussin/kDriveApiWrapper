namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The useremail_f4611cfe.
    /// </summary>
    public partial class Useremail_f4611cfe
    {
        /// <summary>
        /// Unique identifier of the resource `User email`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Email
        /// </summary>

        [JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Timestamp `User email` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether reminder.
        /// </summary>
        [JsonPropertyName("reminder")]
        public bool Reminder { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether checked.
        /// </summary>
        [JsonPropertyName("checked")]
        public bool Checked { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; } = default!;
    }
}