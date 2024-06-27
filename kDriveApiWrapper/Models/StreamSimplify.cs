namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The stream simplify.
    /// </summary>
    public partial class StreamSimplify : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Stream`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The type of stream
        /// </summary>

        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The mountpoint to access to the stream
        /// </summary>

        [JsonPropertyName("mountpoint")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Mountpoint { get; set; } = default!;

        /// <summary>
        /// The codec used in the stream
        /// </summary>

        [JsonPropertyName("codec")]
        public int Codec { get; set; } = default!;

        /// <summary>
        /// The bitrate used to in the stream
        /// </summary>

        [JsonPropertyName("bitrate")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Bitrate { get; set; } = default!;

        /// <summary>
        /// Define if the stream is used like a source for HlsStream or Transcoding
        /// </summary>

        [JsonPropertyName("is_source")]
        public bool Is_source { get; set; } = default!;

        /// <summary>
        /// Is the `Stream` is a fallback?
        /// </summary>

        [JsonPropertyName("is_fallback")]
        public bool Is_fallback { get; set; } = default!;
    }
}