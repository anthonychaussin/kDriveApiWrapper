namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The team3.
    /// </summary>
    public partial class Team3 : Data
    {
        /// <summary>
        /// Gets or sets the executed.
        /// </summary>
        [JsonPropertyName("executed")]
        public int Executed { get; set; } = default!;

        /// <summary>
        /// Gets or sets the archived.
        /// </summary>
        [JsonPropertyName("archived")]
        public int Archived { get; set; } = default!;

        /// <summary>
        /// Gets or sets the conflicted.
        /// </summary>
        [JsonPropertyName("conflicted")]
        public int Conflicted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the directory_id.
        /// </summary>
        [JsonPropertyName("directory_id")]
        public int? Directory_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the directory_archive_id.
        /// </summary>
        [JsonPropertyName("directory_archive_id")]
        public int? Directory_archive_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the directory_conflict_id.
        /// </summary>
        [JsonPropertyName("directory_conflict_id")]
        public int? Directory_conflict_id { get; set; } = default!;
    }
}