namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The slack attachment field.
    /// </summary>
    public partial class SlackAttachmentField : Data
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("Title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// The value of the attachment, set as string but capable with golang interface
        /// </summary>

        [JsonPropertyName("Value")]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether short.
        /// </summary>
        [JsonPropertyName("Short")]
        public bool Short { get; set; } = default!;
    }
}