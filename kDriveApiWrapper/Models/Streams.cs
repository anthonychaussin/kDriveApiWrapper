namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The streams.
    /// </summary>
    public partial class Streams : Data
    {
        /// <summary>
        /// Gets or sets the audio_bitrate.
        /// </summary>
        [JsonPropertyName("audio_bitrate")]
        public double Audio_bitrate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_sampling.
        /// </summary>
        [JsonPropertyName("audio_sampling")]
        public double Audio_sampling { get; set; } = default!;
    }
}