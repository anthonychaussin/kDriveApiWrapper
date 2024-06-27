namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Thumbnail
    /// </summary>

    public partial class Api_Thumbnail
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

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
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        [JsonPropertyName("link")]
        public Api_Link Link { get; set; } = default!;
    }
}