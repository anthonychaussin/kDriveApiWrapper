namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// PlaylistItem
    /// </summary>

    public partial class Api_PlaylistItem
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [JsonPropertyName("position")]
        public double Position { get; set; } = default!;

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
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        [JsonPropertyName("model")]
        public Api_PlaylistItem Model { get; set; } = default!;
    }
}