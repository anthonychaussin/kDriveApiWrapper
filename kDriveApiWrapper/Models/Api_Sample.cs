namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Sample
    /// </summary>

    public partial class Api_Sample
    {
        /// <summary>
        /// Gets or sets the audio.
        /// </summary>
        [JsonPropertyName("audio")]
        public Api_Link Audio { get; set; } = default!;

        /// <summary>
        /// Gets or sets the video.
        /// </summary>
        [JsonPropertyName("video")]
        public Api_Link Video { get; set; } = default!;
    }
}