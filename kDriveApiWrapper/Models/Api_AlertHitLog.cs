namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// AlertHitLog
    /// </summary>

    public partial class Api_AlertHitLog
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the datetime.
        /// </summary>
        [JsonPropertyName("datetime")]
        public string Datetime { get; set; } = default!;

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether result.
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; } = default!;

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        [JsonPropertyName("response")]
        public string Response { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;
    }
}