namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// A completion choices.
    /// </summary>

    public partial class Choice_8fc99c63
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
        [System.ComponentModel.DataAnnotations.Required]
        public Message Message { get; set; } = new Message();

        /// <summary>
        /// Gets or sets the delta.
        /// </summary>
        [JsonPropertyName("delta")]
        [System.ComponentModel.DataAnnotations.Required]
        public Choice Delta { get; set; } = new Choice();

        /// <summary>
        /// Gets or sets the logprobs.
        /// </summary>
        [JsonPropertyName("logprobs")]
        [System.ComponentModel.DataAnnotations.Required]
        public Logprobability_c61983bb Logprobs { get; set; } = new Logprobability_c61983bb();

        /// <summary>
        /// The reason the model stopped generating tokens
        /// </summary>

        [JsonPropertyName("finish_reason")]
        public string? Finish_reason { get; set; } = default!;
    }
}