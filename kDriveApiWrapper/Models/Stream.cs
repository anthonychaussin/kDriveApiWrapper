namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The stream.
    /// </summary>
    public partial class Stream : Data
    {
        /// <summary>
        /// Unique identifier of the `stream` that is related to the resource `stream`
        /// </summary>

        [JsonPropertyName("stream_id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Stream_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the original_stream_id.
        /// </summary>
        [JsonPropertyName("original_stream_id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Original_stream_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether rendered.
        /// </summary>
        [JsonPropertyName("rendered")]
        public bool Rendered { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `Option transcoding` that is related to the resource `stream`
        /// </summary>

        [JsonPropertyName("transcoding_option_id")]
        public int Transcoding_option_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonPropertyName("url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_bitrate.
        /// </summary>
        [JsonPropertyName("audio_bitrate")]
        public int Audio_bitrate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the video_bitrate.
        /// </summary>
        [JsonPropertyName("video_bitrate")]
        public int Video_bitrate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Timestamp `stream` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `stream` has been interrupted
        /// </summary>

        [JsonPropertyName("interrupted_at")]
        public int Interrupted_at { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `restriction` that is related to the resource `stream`
        /// </summary>

        [JsonPropertyName("restrictions_id")]
        public int Restrictions_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether published.
        /// </summary>
        [JsonPropertyName("published")]
        public bool Published { get; set; } = default!;

        /// <summary>
        /// Gets or sets the resolution.
        /// </summary>
        [JsonPropertyName("resolution")]
        public int Resolution { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `classing config` that is related to the resource `stream`
        /// </summary>

        [JsonPropertyName("classing_config_id")]
        public int classing_config_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [JsonPropertyName("username")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// Gets or sets the pass.
        /// </summary>
        [JsonPropertyName("pass")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Pass { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether interrupted.
        /// </summary>
        [JsonPropertyName("interrupted")]
        public bool Interrupted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_codec.
        /// </summary>
        [JsonPropertyName("audio_codec")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Audio_codec { get; set; } = default!;

        /// <summary>
        /// Gets or sets the frame_rate.
        /// </summary>
        [JsonPropertyName("frame_rate")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Frame_rate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the keyframe_rate.
        /// </summary>
        [JsonPropertyName("keyframe_rate")]
        public int Keyframe_rate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the instant_connection.
        /// </summary>
        [JsonPropertyName("instant_connection")]
        public int Instant_connection { get; set; } = default!;

        /// <summary>
        /// Gets or sets the channel.
        /// </summary>
        [JsonPropertyName("channel")]
        public Channel Channel { get; set; } = default!;
    }
}