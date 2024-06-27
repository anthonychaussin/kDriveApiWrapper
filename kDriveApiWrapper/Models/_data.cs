namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The _data.
    /// </summary>
    public partial class _data : Data
    {
        /// <summary>
        /// Gets or sets the encoding.
        /// </summary>
        [JsonPropertyName("encoding")]
        public string Encoding { get; set; } = default!;

        /// <summary>
        /// Gets or sets the strategy.
        /// </summary>
        [JsonPropertyName("strategy")]
        public string Strategy { get; set; } = default!;

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = default!;
    }
}