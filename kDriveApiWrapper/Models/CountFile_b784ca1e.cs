namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The count file_b784ca1e.
    /// </summary>
    public partial class CountFile_b784ca1e
    {
        /// <summary>
        /// Total of element in the directory
        /// </summary>

        [JsonPropertyName("count")]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Total of files in the directory
        /// </summary>

        [JsonPropertyName("files")]
        public int Files { get; set; } = default!;

        /// <summary>
        /// Total of directories in the directory
        /// </summary>

        [JsonPropertyName("directories")]
        public int Directories { get; set; } = default!;
    }
}