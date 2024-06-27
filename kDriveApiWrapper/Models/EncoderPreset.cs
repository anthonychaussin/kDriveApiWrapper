namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The encoder preset.
    /// </summary>
    public partial class EncoderPreset : Data
    {
        /// <summary>
        /// Gets or sets the encoder_preset_id.
        /// </summary>
        [JsonPropertyName("encoder_preset_id")]
        public int Encoder_preset_id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `stream` that is related to the resource `EncoderPreset`
        /// </summary>

        [JsonPropertyName("stream_id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Stream_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the template_id.
        /// </summary>
        [JsonPropertyName("template_id")]
        public int Template_id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `EncoderPreset`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Gets or sets the video_bitrate.
        /// </summary>
        [JsonPropertyName("video_bitrate")]
        public int Video_bitrate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_bitrate.
        /// </summary>
        [JsonPropertyName("audio_bitrate")]
        public int Audio_bitrate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the video_codec.
        /// </summary>
        [JsonPropertyName("video_codec")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Video_codec { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_codec.
        /// </summary>
        [JsonPropertyName("audio_codec")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Audio_codec { get; set; } = default!;

        /// <summary>
        /// Gets or sets the encoding_implementation.
        /// </summary>
        [JsonPropertyName("encoding_implementation")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Encoding_implementation { get; set; } = default!;

        /// <summary>
        /// Gets or sets the gpu_id.
        /// </summary>
        [JsonPropertyName("gpu_id")]
        public int Gpu_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the profile.
        /// </summary>
        [JsonPropertyName("profile")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Profile { get; set; } = default!;

        /// <summary>
        /// Gets or sets the key_frame_interval.
        /// </summary>
        [JsonPropertyName("key_frame_interval")]
        public int Key_frame_interval { get; set; } = default!;

        /// <summary>
        /// Gets or sets the fit_mode.
        /// </summary>
        [JsonPropertyName("fit_mode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Fit_mode { get; set; } = default!;

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; set; } = default!;

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; } = default!;

        /// <summary>
        /// Gets or sets the crop_top.
        /// </summary>
        [JsonPropertyName("crop_top")]
        public int Crop_top { get; set; } = default!;

        /// <summary>
        /// Gets or sets the crop_bottom.
        /// </summary>
        [JsonPropertyName("crop_bottom")]
        public int Crop_bottom { get; set; } = default!;

        /// <summary>
        /// Gets or sets the crop_left.
        /// </summary>
        [JsonPropertyName("crop_left")]
        public int Crop_left { get; set; } = default!;

        /// <summary>
        /// Gets or sets the crop_right.
        /// </summary>
        [JsonPropertyName("crop_right")]
        public int Crop_right { get; set; } = default!;
    }
}