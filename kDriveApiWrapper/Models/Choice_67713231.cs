namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// A completion choices.
    /// </summary>

    public partial class Choice_67713231
    {
        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        [JsonPropertyName("index")]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonPropertyName("message")]
        public Message Message { get; set; } = default!;

        /// <summary>
        /// Gets or sets the delta.
        /// </summary>
        [JsonPropertyName("delta")]
        [System.ComponentModel.DataAnnotations.Required]
        public Choice Delta { get; set; } = new Choice();

        /// <summary>
        /// The reason the model stopped generating tokens
        /// </summary>

        [JsonPropertyName("finish_reason")]
        public string? Finish_reason { get; set; } = default!;
    }
}