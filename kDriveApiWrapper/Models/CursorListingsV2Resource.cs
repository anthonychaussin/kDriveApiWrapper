namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The cursor listings v2 resource.
    /// </summary>
    public partial class CursorListingsV2Resource : Data
    {
        /// <summary>
        /// Cursor for next request
        /// </summary>

        [JsonPropertyName("cursor")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Cursor { get; set; } = default!;

        /// <summary>
        /// Whether there currently is more data to be found in the Cursor and should perform another request to retrieve said data
        /// </summary>

        [JsonPropertyName("has_more")]
        public bool Has_more { get; set; } = default!;

        /// <summary>
        /// Gets or sets the actions.
        /// </summary>
        [JsonPropertyName("actions")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<Activity> Actions { get; set; } = [];

        /// <summary>
        /// List of `File` and `Directory`
        /// </summary>

        [JsonPropertyName("files")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<File> Files { get; set; } = [];
    }
}