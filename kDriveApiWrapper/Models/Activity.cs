namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The activity.
    /// </summary>
    public partial class Activity : Data
    {
        /// <summary>
        /// Action type
        /// </summary>

        [JsonPropertyName("action")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Action { get; set; } = default!;

        /// <summary>
        /// Directory/File identifier
        /// </summary>

        [JsonPropertyName("file_id")]
        public int File_id { get; set; } = default!;

        /// <summary>
        /// Parent directory identifier
        /// </summary>

        [JsonPropertyName("parent_id")]
        public int Parent_id { get; set; } = default!;

        /// <summary>
        /// Directory/File type
        /// </summary>

        [JsonPropertyName("file_type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ActivityFile_type File_type { get; set; } = default!;

        /// <summary>
        /// Size of Activity &lt;note&gt;The unit of size is defined in Bytes&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("size")]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Activity creation timestamp (in seconds), if available in its metadata or specified on upload
        /// </summary>

        [JsonPropertyName("last_modified_at")]
        public int Last_modified_at { get; set; } = default!;

        /// <summary>
        /// Time the action took place
        /// </summary>

        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; } = default!;

        /// <summary>
        /// Path of Directory/File
        /// </summary>

        [JsonPropertyName("path")]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Destination of Directory/File in case of move or rename action
        /// </summary>

        [JsonPropertyName("destination")]
        public string Destination { get; set; } = default!;

        /// <summary>
        /// Creation date of Directory/File
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Symlink target path if the related file was uploaded as a symlink
        /// </summary>

        [JsonPropertyName("symbolic_link")]
        public string Symbolic_link { get; set; } = default!;
    }
}