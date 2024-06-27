using kDriveApiWrapper.Models.Trash;

namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The list.
    /// </summary>
    public partial class List : Data
    {
        /// <summary>
        /// Layout for the list view
        /// </summary>

        [JsonPropertyName("view")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ListView View { get; set; } = default!;

        /// <summary>
        /// Gets or sets the files.
        /// </summary>
        [JsonPropertyName("files")]
        public Files Files { get; set; } = default!;

        /// <summary>
        /// Gets or sets the trash.
        /// </summary>
        [JsonPropertyName("trash")]
        public TrashSearch Trash { get; set; } = default!;

        /// <summary>
        /// Gets or sets the storage_largest.
        /// </summary>
        [JsonPropertyName("storage_largest")]
        public Storage_largest Storage_largest { get; set; } = default!;

        /// <summary>
        /// Gets or sets the storage_versions.
        /// </summary>
        [JsonPropertyName("storage_versions")]
        public Storage_versions Storage_versions { get; set; } = default!;
    }
}