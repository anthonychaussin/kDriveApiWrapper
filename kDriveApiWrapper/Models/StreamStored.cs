namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The stream stored.
    /// </summary>
    public partial class StreamStored : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Stream`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

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
        public int Bitrate { get; set; } = default!;

        /// <summary>
        /// The password to access to the protected pages
        /// </summary>

        [JsonPropertyName("password")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Password { get; set; } = default!;

        /// <summary>
        /// The url to listen the stream
        /// </summary>

        [JsonPropertyName("url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The server address to connect encoder
        /// </summary>

        [JsonPropertyName("server_address")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Server_address { get; set; } = default!;

        /// <summary>
        /// The mountpoint used to fallback the stream
        /// </summary>

        [JsonPropertyName("fallback_mountpoint")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Fallback_mountpoint { get; set; } = default!;

        /// <summary>
        /// Define if the stream is a relay stream
        /// </summary>

        [JsonPropertyName("is_relay")]
        public bool Is_relay { get; set; } = default!;

        /// <summary>
        /// Define if the stream is used like a source for HlsStream or Transcoding
        /// </summary>

        [JsonPropertyName("is_source")]
        public bool Is_source { get; set; } = default!;

        /// <summary>
        /// Define if the stream is a transcoded stream
        /// </summary>

        [JsonPropertyName("is_transcoding")]
        public bool Is_transcoding { get; set; } = default!;

        /// <summary>
        /// Is the `Stream` is a fallback?
        /// </summary>

        [JsonPropertyName("is_fallback")]
        public bool Is_fallback { get; set; } = default!;
    }
}