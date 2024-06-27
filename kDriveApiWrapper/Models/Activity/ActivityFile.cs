namespace kDriveApiWrapper.Models.Activity
{
    /// <summary>
    /// The activity file.
    /// </summary>
    public partial class ActivityFile : Activity
    {
        /// <summary>
        /// Unique identifier of the resource `Activity File`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

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
        /// User identifier of the action, null if the user was not logged
        /// </summary>

        [JsonPropertyName("user_id")]
        public int? User_id { get; set; } = default!;

        /// <summary>
        /// User of the action, null if the user was not logged
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

        /// <summary>
        /// get private folder user id
        /// </summary>

        [JsonPropertyName("private_path_user_id")]
        public int Private_path_user_id { get; set; } = default!;
    }
}