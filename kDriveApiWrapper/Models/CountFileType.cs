namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The count file type.
    /// </summary>
    public partial class CountFileType : Data
    {
        /// <summary>
        /// Total size of files
        /// </summary>

        [JsonPropertyName("size")]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Total size of files (with versions)
        /// </summary>

        [JsonPropertyName("storage_size")]
        public int Storage_size { get; set; } = default!;
    }
}