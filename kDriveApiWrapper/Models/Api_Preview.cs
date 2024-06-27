namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Preview
    /// </summary>

    public partial class Api_Preview
    {
        /// <summary>
        /// Gets or sets the audio.
        /// </summary>
        [JsonPropertyName("audio")]
        public Api_Link Audio { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_raw.
        /// </summary>
        [JsonPropertyName("audio_raw")]
        public Api_Link Audio_raw { get; set; } = default!;

        /// <summary>
        /// Gets or sets the video.
        /// </summary>
        [JsonPropertyName("video")]
        public Api_Link Video { get; set; } = default!;
    }
}