namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body11.
    /// </summary>
    public partial class Body11 : Data
    {
        /// <summary>
        /// Name of the resource `{name}`
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Administration level of the user.&lt;note&gt;&lt;strong&gt;admin&lt;/strong&gt;: Administrator of the drive, can manage the drive (settings, invitations and users) and the files.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;user&lt;/strong&gt;: Internal user can invite user and manage the files of his private directory and other directories with manage file access.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("role")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DriveUserRole Role { get; set; } = default!;
    }
}