namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// playbacks
    /// </summary>

    public partial class Media_playbacks
    {
        /// <summary>
        /// Gets or sets the encoding id.
        /// </summary>
        [JsonPropertyName("encodingId")]
        public EncodingId EncodingId { get; set; } = default!;
    }
}