namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The encoding id.
    /// </summary>
    public partial class EncodingId : Data
    {
        /// <summary>
        /// Gets or sets the strategy.
        /// </summary>
        [JsonPropertyName("strategy")]
        public Strategy Strategy { get; set; } = default!;
    }
}