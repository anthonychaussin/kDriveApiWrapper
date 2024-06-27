namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The list2.
    /// </summary>
    public partial class List2 : Data
    {
        /// <summary>
        /// Gets or sets the files.
        /// </summary>
        [JsonPropertyName("files")]
        public Files2 Files { get; set; } = default!;

        /// <summary>
        /// Gets or sets the storage_largest.
        /// </summary>
        [JsonPropertyName("storage_largest")]
        public Storage_largest2 Storage_largest { get; set; } = default!;

        /// <summary>
        /// Gets or sets the storage_versions.
        /// </summary>
        [JsonPropertyName("storage_versions")]
        public Storage_versions2 Storage_versions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the trash.
        /// </summary>
        [JsonPropertyName("trash")]
        public Trash3 Trash { get; set; } = default!;

        /// <summary>
        /// Gets or sets the view.
        /// </summary>
        [JsonPropertyName("view")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public List2View View { get; set; } = default!;
    }
}