namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The user.
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Unique identifier of the resource `User`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Display name
        /// </summary>

        [JsonPropertyName("display_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Display_name { get; set; } = default!;

        /// <summary>
        /// First name
        /// </summary>

        [JsonPropertyName("first_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string First_name { get; set; } = default!;

        /// <summary>
        /// Last name
        /// </summary>

        [JsonPropertyName("last_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Last_name { get; set; } = default!;

        /// <summary>
        /// Email
        /// </summary>

        [JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// null is returned only when request parameter no_avatar_default=1 and the user has not set an avatar
        /// </summary>

        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Timestamp `User` was deleted at
        /// </summary>

        [JsonPropertyName("deleted_at")]
        public int Deleted_at { get; set; } = default!;

        /// <summary>
        /// List of Team identifiers
        /// </summary>

        [JsonPropertyName("teams")]
        public ICollection<int> Teams { get; set; } = default!;

        /// <summary>
        /// Gets or sets the security.
        /// </summary>
        [JsonPropertyName("security")]
        public Security Security { get; set; } = default!;

        private IDictionary<string, object>? _additionalProperties;

        /// <summary>
        /// Gets or sets the additional properties.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ??= new Dictionary<string, object>(); }
            set { _additionalProperties = value; }
        }
    }
}