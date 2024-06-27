namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The usage.
    /// </summary>
    public partial class Usage : Data
    {
        /// <summary>
        /// Number of tokens in the prompt.
        /// </summary>

        [JsonPropertyName("input_tokens")]
        public int Input_tokens { get; set; } = default!;

        /// <summary>
        /// Number of tokens in the generated completion.
        /// </summary>

        [JsonPropertyName("output_tokens")]
        public int? Output_tokens { get; set; } = default!;

        /// <summary>
        /// Total number of tokens used in the request (input+output).
        /// </summary>

        [JsonPropertyName("total_tokens")]
        public int Total_tokens { get; set; } = default!;
    }
}