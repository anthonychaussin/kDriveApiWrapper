namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// A transcription segment.
    /// </summary>

    public partial class SpeechToTextSegment : Data
    {
        /// <summary>
        /// Unique identifier of the segment.
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Seek offset of the segment.
        /// </summary>

        [JsonPropertyName("seek")]
        public int Seek { get; set; } = default!;

        /// <summary>
        /// Start time of the segment in seconds.
        /// </summary>

        [JsonPropertyName("start")]
        public double Start { get; set; } = default!;

        /// <summary>
        /// End time of the segment in seconds.
        /// </summary>

        [JsonPropertyName("end")]
        public double End { get; set; } = default!;

        /// <summary>
        /// Text content of the segment.
        /// </summary>

        [JsonPropertyName("text")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Array of token IDs for the text content.
        /// </summary>

        [JsonPropertyName("tokens")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<int> Tokens { get; set; } = [];

        /// <summary>
        /// Temperature parameter used for generating the segment.
        /// </summary>

        [JsonPropertyName("temperature")]
        public double Temperature { get; set; } = default!;

        /// <summary>
        /// Average logprob of the segment. If the value is lower than -1, consider the logprobs failed.
        /// </summary>

        [JsonPropertyName("avg_logprob")]
        public double Avg_logprob { get; set; } = default!;

        /// <summary>
        /// Compression ratio of the segment. If the value is greater than 2.4, consider the compression failed.
        /// </summary>

        [JsonPropertyName("compression_ratio")]
        public double Compression_ratio { get; set; } = default!;

        /// <summary>
        /// Probability of no speech in the segment. If the value is higher than 1.0 and the avg_logprob is below -1, consider this segment silent.
        /// </summary>

        [JsonPropertyName("no_speech_prob")]
        public double No_speech_prob { get; set; } = default!;
    }
}