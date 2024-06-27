namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The security.
    /// </summary>
    public partial class Security : Data
    {
        /// <summary>
        /// The last date the assistant was used
        /// </summary>

        [JsonPropertyName("assistant_at")]
        public int? Assistant_at { get; set; } = default!;

        /// <summary>
        /// Double authentication method used to log in
        /// </summary>

        [JsonPropertyName("double_auth_method")]
        public string Double_auth_method { get; set; } = default!;

        /// <summary>
        /// Whether the `User` has double authentication enabled
        /// </summary>

        [JsonPropertyName("has_double_auth")]
        public bool Has_double_auth { get; set; } = default!;

        /// <summary>
        /// Last time `User`'s password was changed
        /// </summary>

        [JsonPropertyName("last_password_at")]
        public int? Last_password_at { get; set; } = default!;

        /// <summary>
        /// Security score of the `User`
        /// </summary>

        [JsonPropertyName("score")]
        public int Score { get; set; } = default!;

        /// <summary>
        /// Whether the `User` has a valid email
        /// </summary>

        [JsonPropertyName("has_valid_email")]
        public int Has_valid_email { get; set; } = default!;

        /// <summary>
        /// Whether the `User` has a recovery email
        /// </summary>

        [JsonPropertyName("has_recovery_email")]
        public bool Has_recovery_email { get; set; } = default!;

        /// <summary>
        /// Whether the `User` has a valid phone number
        /// </summary>

        [JsonPropertyName("has_valid_phone")]
        public bool Has_valid_phone { get; set; } = default!;

        /// <summary>
        /// Whether the `User` has a private folder
        /// </summary>

        [JsonPropertyName("has_private_folder")]
        public bool Has_private_folder { get; set; } = default!;
    }
}