namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive user invitation.
    /// </summary>
    public partial class DriveUserInvitation : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Drive User Invitation`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Type of `Invitation`
        /// </summary>

        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DriveUserInvitationType Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether is_private.
        /// </summary>
        [JsonPropertyName("is_private")]
        public bool Is_private { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether user_exist.
        /// </summary>
        [JsonPropertyName("user_exist")]
        public bool User_exist { get; set; } = default!;

        /// <summary>
        /// Random key used to uniquely identify the `Invitation`
        /// </summary>

        [JsonPropertyName("key")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Gets or sets the file_id.
        /// </summary>
        [JsonPropertyName("file_id")]
        public int File_id { get; set; } = default!;

        /// <summary>
        /// Language to invite the `User` in
        /// </summary>

        [JsonPropertyName("lang")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Lang { get; set; } = default!;

        /// <summary>
        /// User identifier
        /// </summary>

        [JsonPropertyName("user_id")]
        public int? User_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; } = default!;

        /// <summary>
        /// Identifier of `User` that sent the invitation
        /// </summary>

        [JsonPropertyName("invited_by")]
        public int? Invited_by { get; set; } = default!;

        /// <summary>
        /// Gets or sets the invited.
        /// </summary>
        [JsonPropertyName("invited")]
        public User Invited { get; set; } = default!;

        /// <summary>
        /// `Invitation` url
        /// </summary>

        [JsonPropertyName("url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Whether the `Invitation` is still valid or not
        /// </summary>

        [JsonPropertyName("is_valid")]
        public bool Is_valid { get; set; } = default!;

        /// <summary>
        /// Status of the `Invitation`
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DriveUserInvitationStatus Status { get; set; } = default!;

        /// <summary>
        /// Email
        /// </summary>

        [JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// `Invitation` message
        /// </summary>

        [JsonPropertyName("message")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// When the invitation expire
        /// </summary>

        [JsonPropertyName("expired_at")]
        public int? Expired_at { get; set; } = default!;

        /// <summary>
        /// When the invitation was created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int? Created_at { get; set; } = default!;

        /// <summary>
        /// `Drive` name displayed for user
        /// </summary>

        [JsonPropertyName("access_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Access_name { get; set; } = default!;

        /// <summary>
        /// Role that will be assigned to invited `User`
        /// </summary>

        [JsonPropertyName("role")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Gets or sets the drive.
        /// </summary>
        [JsonPropertyName("drive")]
        public Drive Drive { get; set; } = default!;
    }
}