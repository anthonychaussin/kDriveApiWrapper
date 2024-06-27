namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body52.
    /// </summary>
    public partial class Body52 : Data
    {
        /// <summary>
        /// Array of files to exclude from the request; only used when parent_id is set, meaningless otherwise
        /// </summary>

        [JsonPropertyName("except_file_ids")]
        public ICollection<int> Except_file_ids { get; set; } = default!;

        /// <summary>
        /// Array of files to include in the request; required without parent_id
        /// </summary>

        [JsonPropertyName("file_ids")]
        public ICollection<int> File_ids { get; set; } = default!;

        /// <summary>
        /// The directory containing the files to include in the request; required without file_ids
        /// </summary>

        [JsonPropertyName("parent_id")]
        public int Parent_id { get; set; } = default!;
    }
}