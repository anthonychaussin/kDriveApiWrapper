namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The userphone.
    /// </summary>
    public partial class Userphone : Data
    {
        /// <summary>
        /// Unique identifier of the resource `User phone`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        [JsonPropertyName("phone")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Phone { get; set; } = default!;

        /// <summary>
        /// Timestamp `User phone` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the reminder.
        /// </summary>
        [JsonPropertyName("reminder")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Reminder { get; set; } = default!;

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