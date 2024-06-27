namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Share
    /// </summary>

    public partial class Api_Share
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the target_type.
        /// </summary>
        [JsonPropertyName("target_type")]
        public string Target_type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the target_id.
        /// </summary>
        [JsonPropertyName("target_id")]
        public string Target_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; } = default!;

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// In seconds
        /// </summary>

        [JsonPropertyName("validity")]
        public double Validity { get; set; } = default!;

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
        /// Gets or sets the links.
        /// </summary>
        [JsonPropertyName("links")]
        public ICollection<string> Links { get; set; } = default!;

        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        [JsonPropertyName("player")]
        public Api_Player Player { get; set; } = default!;

        /// <summary>
        /// Gets or sets the manifests.
        /// </summary>
        [JsonPropertyName("manifests")]
        public string Manifests { get; set; } = default!;

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        [JsonPropertyName("target")]
        public Api_Share Target { get; set; } = default!;

        /// <summary>
        /// Gets or sets the encoding.
        /// </summary>
        [JsonPropertyName("encoding")]
        public ICollection<Api_Encoding> Encoding { get; set; } = default!;

        /// <summary>
        /// Gets or sets the valid_until.
        /// </summary>
        [JsonPropertyName("valid_until")]
        public object Valid_until { get; set; } = default!;
    }
}