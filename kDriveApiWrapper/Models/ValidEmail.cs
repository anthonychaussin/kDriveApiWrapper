namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The valid email.
    /// </summary>
    public partial class ValidEmail : Data
    {
        /// <summary>
        /// Unique identifier of the resource `ValidEmail`
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
        /// Gets or sets the email_idn.
        /// </summary>
        [JsonPropertyName("email_idn")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Email_idn { get; set; } = default!;

        /// <summary>
        /// Gets or sets the is_account.
        /// </summary>
        [JsonPropertyName("is_account")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Is_account { get; set; } = default!;

        /// <summary>
        /// Gets or sets the is_verified.
        /// </summary>
        [JsonPropertyName("is_verified")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Is_verified { get; set; } = default!;

        /// <summary>
        /// Gets or sets the is_removable.
        /// </summary>
        [JsonPropertyName("is_removable")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Is_removable { get; set; } = default!;
    }
}