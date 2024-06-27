namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The activity file.
    /// </summary>
    public partial class ActivityFile : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Activity File`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Timestamp `Activity File` was created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Activity type
        /// </summary>

        [JsonPropertyName("action")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Action { get; set; } = default!;

        /// <summary>
        /// Current path of the activity file/directory
        /// </summary>

        [JsonPropertyName("new_path")]
        public string? New_path { get; set; } = default!;

        /// <summary>
        /// Previous path of the activity file/directory
        /// </summary>

        [JsonPropertyName("old_path")]
        public string? Old_path { get; set; } = default!;

        /// <summary>
        /// Logged file identifier
        /// </summary>

        [JsonPropertyName("file_id")]
        public int File_id { get; set; } = default!;

        /// <summary>
        /// User identifier of the action, null if the user was not logged
        /// </summary>

        [JsonPropertyName("user_id")]
        public int? User_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; } = default!;

        /// <summary>
        /// Information about where the Activity was generated
        /// </summary>

        [JsonPropertyName("source")]
        public Source Source { get; set; } = default!;

        /// <summary>
        /// Associated File or Directory, null is element was deleted
        /// </summary>

        [JsonPropertyName("file")]
        public File? File { get; set; } = default!;

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        [JsonPropertyName("parent")]
        public Directory Parent { get; set; } = default!;

        /// <summary>
        /// Object the Activity is about
        /// </summary>

        [JsonPropertyName("entity")]
        public Entity Entity { get; set; } = default!;
    }
}