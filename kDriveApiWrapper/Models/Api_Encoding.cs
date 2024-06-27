namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Encoding
    /// </summary>

    public partial class Api_Encoding
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the container.
        /// </summary>
        [JsonPropertyName("container")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_EncodingContainer Container { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether copy.
        /// </summary>
        [JsonPropertyName("copy")]
        public bool Copy { get; set; } = default!;

        /// <summary>
        /// Gets or sets the video_codec.
        /// </summary>
        [JsonPropertyName("video_codec")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_EncodingVideo_codec Video_codec { get; set; } = default!;

        /// <summary>
        /// Gets or sets the video_aspect.
        /// </summary>
        [JsonPropertyName("video_aspect")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_EncodingVideo_aspect Video_aspect { get; set; } = default!;

        /// <summary>
        /// Gets or sets the video_fps.
        /// </summary>
        [JsonPropertyName("video_fps")]
        public string Video_fps { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_codec.
        /// </summary>
        [JsonPropertyName("audio_codec")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_EncodingAudio_codec Audio_codec { get; set; } = default!;

        /// <summary>
        /// Gets or sets the audio_channel.
        /// </summary>
        [JsonPropertyName("audio_channel")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_EncodingAudio_channel Audio_channel { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_at.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether owned.
        /// </summary>
        [JsonPropertyName("owned")]
        public bool Owned { get; set; } = default!;

        /// <summary>
        /// Gets or sets the preset.
        /// </summary>
        [JsonPropertyName("preset")]
        public ICollection<Api_EncodingPreset> Preset { get; set; } = default!;

        /// <summary>
        /// Gets or sets the streams.
        /// </summary>
        [JsonPropertyName("streams")]
        public ICollection<Api_EncodingStream> Streams { get; set; } = default!;
    }
}