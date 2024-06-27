namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// MediaJournalLog
    /// </summary>

    public partial class Api_MediaJournalLog
    {
        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_at.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the media.
        /// </summary>
        [JsonPropertyName("media")]
        public ICollection<Api_Media> Media { get; set; } = default!;
    }
}