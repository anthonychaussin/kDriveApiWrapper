namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body10.
    /// </summary>
    public partial class Body10 : Data
    {
        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        [JsonPropertyName("emails")]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public ICollection<string> Emails { get; set; } = default!;

        /// <summary>
        /// For adding a file shared along the invitation.
        /// </summary>

        [JsonPropertyName("file_id")]
        public int? File_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default!;

        /// <summary>
        /// Name of the resource `{name}`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.StringLength(128)]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// Right to add the file with when relevant.
        /// </summary>

        [JsonPropertyName("right")]
        public string? Right { get; set; } = default!;

        /// <summary>
        /// Administration level of the user.&lt;note&gt;&lt;strong&gt;admin&lt;/strong&gt;: Administrator of the drive, can manage the drive (settings, invitations and users) and the files.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;external&lt;/strong&gt;: External user can only access the files given by the others roles.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;user&lt;/strong&gt;: Internal user can invite user and manage the files of his private directory and other directories with manage file access.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("role")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body10Role Role { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether send_email.
        /// </summary>
        [JsonPropertyName("send_email")]
        public bool Send_email { get; set; } = default!;

        /// <summary>
        /// Gets or sets the team_ids.
        /// </summary>
        [JsonPropertyName("team_ids")]
        [System.ComponentModel.DataAnnotations.MaxLength(40)]
        public ICollection<int> Team_ids { get; set; } = default!;

        /// <summary>
        /// Type of the access; this field is no longer used and has been replaced by an additional role property `external`.&lt;note&gt;&lt;strong&gt;main&lt;/strong&gt;: User has access to the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;shared&lt;/strong&gt;: User has access to a shared file / directory only.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body10Type Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_ids.
        /// </summary>
        [JsonPropertyName("user_ids")]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public ICollection<int> User_ids { get; set; } = default!;
    }
}