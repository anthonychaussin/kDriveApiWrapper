namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The activity_0d9678c0.
    /// </summary>
    public partial class Activity_0d9678c0
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

        [JsonPropertyName("executed_at")]
        public int Executed_at { get; set; } = default!;
    }
}