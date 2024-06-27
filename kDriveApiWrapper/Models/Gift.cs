namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a Gift
    /// </summary>

    public partial class Gift : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Gift`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public GiftLanguage Language { get; set; } = default!;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonPropertyName("value")]
        public double Value { get; set; } = default!;
    }
}