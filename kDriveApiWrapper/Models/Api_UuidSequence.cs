namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// UuidSequence
    /// </summary>

    public partial class Api_UuidSequence
    {
        /// <summary>
        /// Gets or sets the uuid.
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// Gets or sets the model_type.
        /// </summary>
        [JsonPropertyName("model_type")]
        public string Model_type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the model_id.
        /// </summary>
        [JsonPropertyName("model_id")]
        public double Model_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        [JsonPropertyName("model")]
        public Api_UuidSequence Model { get; set; } = default!;

        /// <summary>
        /// Gets or sets the uuid sequence.
        /// </summary>
        [JsonPropertyName("uuidSequence")]
        public Api_UuidSequence UuidSequence { get; set; } = default!;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;
    }
}