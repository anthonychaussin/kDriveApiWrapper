namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive user.
    /// </summary>
    public partial class DriveUser : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Drive User`
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
        /// Type of the access; this field is no longer used and has been replaced by an additional role property `external`.&lt;note&gt;&lt;strong&gt;main&lt;/strong&gt;: User has access to the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;shared&lt;/strong&gt;: User has access to a shared file / directory only.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [Obsolete]
        public DriveUserType Type { get; set; } = default!;

        /// <summary>
        /// Timestamp `Drive User` was deleted at
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
        public Security2 Security { get; set; } = default!;

        /// <summary>
        /// Drive identifier
        /// </summary>

        [JsonPropertyName("drive_id")]
        public int Drive_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the drive.
        /// </summary>
        [JsonPropertyName("drive")]
        public Drive Drive { get; set; } = default!;

        /// <summary>
        /// Gets or sets the drive_name.
        /// </summary>
        [JsonPropertyName("drive_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Drive_name { get; set; } = default!;

        /// <summary>
        /// Account identifier of resource `Drive User`
        /// </summary>

        [JsonPropertyName("account_id")]
        public int Account_id { get; set; } = default!;

        /// <summary>
        /// Timestamp `Drive User` was created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Drive User` was updated at
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `User` was last connected at
        /// </summary>

        [JsonPropertyName("last_connection_at")]
        public int? Last_connection_at { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `product` that is related to the resource `Drive User`
        /// </summary>

        [JsonPropertyName("product_id")]
        public int Product_id { get; set; } = default!;

        /// <summary>
        /// Current access status of the user in the drive.&lt;note&gt;&lt;strong&gt;active&lt;/strong&gt;: User has access to the Drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;deleted_kept&lt;/strong&gt;: User has been removed but his data remain in the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;deleted_removed&lt;/strong&gt;: User has been removed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;deleted_transferred&lt;/strong&gt;: User has been removed and his data has been transferred to another user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;deleted_transferring&lt;/strong&gt;: User has been removed and is being transferred to another user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;locked&lt;/strong&gt;: User has been locked, user can no longer access to the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;pending&lt;/strong&gt;: User has not accepted the invitation request.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DriveUserStatus Status { get; set; } = default!;

        /// <summary>
        /// Administration level of the user.&lt;note&gt;&lt;strong&gt;admin&lt;/strong&gt;: Administrator of the drive, can manage the drive (settings, invitations and users) and the files.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;external&lt;/strong&gt;: External user can only access the files given by the others roles.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;user&lt;/strong&gt;: Internal user can invite user and manage the files of his private directory and other directories with manage file access.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("role")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DriveUserRole Role { get; set; } = default!;

        /// <summary>
        /// Gets or sets the preference.
        /// </summary>
        [JsonPropertyName("preference")]
        [System.ComponentModel.DataAnnotations.Required]
        public Preference Preference { get; set; } = new Preference();

        /// <summary>
        /// Get user permissions on categories
        /// </summary>

        [JsonPropertyName("categories_permissions")]
        public string Categories_permissions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the capabilities.
        /// </summary>
        [JsonPropertyName("capabilities")]
        public Capabilities2 Capabilities { get; set; } = default!;

        /// <summary>
        /// Storage size of private files (bytes)
        /// </summary>

        [JsonPropertyName("private_storage")]
        public int Private_storage { get; set; } = default!;
    }
}