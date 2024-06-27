namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// encoding preset
    /// </summary>

    public partial class Encoding_preset_template
    {
        /// <summary>
        /// Gets or sets the container.
        /// </summary>
        [JsonPropertyName("container")]
        public double Container { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_codec.
        /// </summary>
        [JsonPropertyName("audio_codec")]
        public double Audio_codec { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_channel.
        /// </summary>
        [JsonPropertyName("audio_channel")]
        public double Audio_channel { get; set; } = default!;

        /// <summary>
        /// Gets or sets the streams.
        /// </summary>
        [JsonPropertyName("streams")]
        public ICollection<Streams> Streams { get; set; } = default!;
    }
}