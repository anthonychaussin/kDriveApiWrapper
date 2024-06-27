namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The version2.
    /// </summary>
    public partial class Version2 : Data
    {
        /// <summary>
        /// File has multi-version
        /// </summary>

        [JsonPropertyName("is_multiple")]
        public bool Is_multiple { get; set; } = default!;

        /// <summary>
        /// Get number of version
        /// </summary>

        [JsonPropertyName("number")]
        public int Number { get; set; } = default!;

        /// <summary>
        /// Size of the file with all version  (byte unit)
        /// </summary>

        [JsonPropertyName("total_size")]
        public int? Total_size { get; set; } = default!;

        /// <summary>
        /// True if the current version of this file should be kept forever, otherwise false or empty
        /// </summary>

        [JsonPropertyName("keep_forever")]
        public bool Keep_forever { get; set; } = default!;
    }
}