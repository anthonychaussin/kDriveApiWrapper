namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The conference options return.
    /// </summary>
    public partial class ConferenceOptionsReturn : Data
    {
        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        [JsonPropertyName("subject")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Subject { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether start_audio_muted.
        /// </summary>
        [JsonPropertyName("start_audio_muted")]
        public bool Start_audio_muted { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether enable_classing.
        /// </summary>
        [JsonPropertyName("enable_classing")]
        public bool Enable_classing { get; set; } = default!;

        /// <summary>
        /// Required if enable_classing is true
        /// </summary>

        [JsonPropertyName("drive_id")]
        public int Drive_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether enable_moderator_video.
        /// </summary>
        [JsonPropertyName("enable_moderator_video")]
        public bool Enable_moderator_video { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether start_audio_only.
        /// </summary>
        [JsonPropertyName("start_audio_only")]
        public bool Start_audio_only { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether lobby_enabled.
        /// </summary>
        [JsonPropertyName("lobby_enabled")]
        public bool Lobby_enabled { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether password_enabled.
        /// </summary>
        [JsonPropertyName("password_enabled")]
        public bool Password_enabled { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether e2ee_enabled.
        /// </summary>
        [JsonPropertyName("e2ee_enabled")]
        public bool E2ee_enabled { get; set; } = default!;
    }
}