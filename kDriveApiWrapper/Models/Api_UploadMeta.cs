namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// UploadMeta
    /// </summary>

    public partial class Api_UploadMeta
    {
        /// <summary>
        /// Gets or sets the nb_streams.
        /// </summary>
        [JsonPropertyName("nb_streams")]
        public double Nb_streams { get; set; } = default!;

        /// <summary>
        /// Gets or sets the nb_programs.
        /// </summary>
        [JsonPropertyName("nb_programs")]
        public double Nb_programs { get; set; } = default!;

        /// <summary>
        /// Gets or sets the format_name.
        /// </summary>
        [JsonPropertyName("format_name")]
        public string Format_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the format_long_name.
        /// </summary>
        [JsonPropertyName("format_long_name")]
        public string Format_long_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the start_time.
        /// </summary>
        [JsonPropertyName("start_time")]
        public int Start_time { get; set; } = default!;

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        [JsonPropertyName("duration")]
        public string Duration { get; set; } = default!;

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        [JsonPropertyName("size")]
        public double Size { get; set; } = default!;

        /// <summary>
        /// In bps
        /// </summary>

        [JsonPropertyName("bit_rate")]
        public double Bit_rate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the probe_score.
        /// </summary>
        [JsonPropertyName("probe_score")]
        public double Probe_score { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; } = default!;

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
        /// Gets or sets the display_aspect_ratio.
        /// </summary>
        [JsonPropertyName("display_aspect_ratio")]
        public string Display_aspect_ratio { get; set; } = default!;

        /// <summary>
        /// Gets or sets the display_aspect_ratio_source.
        /// </summary>
        [JsonPropertyName("display_aspect_ratio_source")]
        public string Display_aspect_ratio_source { get; set; } = default!;

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [JsonPropertyName("height")]
        public string Height { get; set; } = default!;

        /// <summary>
        /// Gets or sets the sample_aspect_ratio.
        /// </summary>
        [JsonPropertyName("sample_aspect_ratio")]
        public string Sample_aspect_ratio { get; set; } = default!;

        /// <summary>
        /// Gets or sets the sample_aspect_ratio_source.
        /// </summary>
        [JsonPropertyName("sample_aspect_ratio_source")]
        public string Sample_aspect_ratio_source { get; set; } = default!;

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [JsonPropertyName("width")]
        public string Width { get; set; } = default!;
    }
}