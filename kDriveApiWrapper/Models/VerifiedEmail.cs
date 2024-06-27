namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The verified email.
    /// </summary>
    public partial class VerifiedEmail : Data
    {
        /// <summary>
        /// VerifiedEmail identifier
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Email
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("email")]
        public string Email { get; set; } = default!;

        /// <summary>
        /// EmailIDN
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("email_idn")]
        public string Email_idn { get; set; } = default!;

        /// <summary>
        /// True if is an account
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_account")]
        public bool Is_account { get; set; } = default!;

        /// <summary>
        /// True if verified
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_verified")]
        public bool Is_verified { get; set; } = default!;

        /// <summary>
        /// True if is_removable
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_removable")]
        public bool Is_removable { get; set; } = default!;
    }
}