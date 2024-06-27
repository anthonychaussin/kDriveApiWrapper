namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Logo
    /// </summary>

    public partial class Api_Logo
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the uuid.
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// Gets or sets the channel_id.
        /// </summary>
        [JsonPropertyName("channel_id")]
        public double Channel_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        [JsonPropertyName("mode")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_LogoMode Mode { get; set; } = default!;

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [JsonPropertyName("position")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_LogoPosition Position { get; set; } = default!;

        /// <summary>
        /// Gets or sets the margin.
        /// </summary>
        [JsonPropertyName("margin")]
        public double Margin { get; set; } = default!;

        /// <summary>
        /// Integer value 1-100
        /// </summary>

        [JsonPropertyName("size")]
        public double Size { get; set; } = default!;

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; } = default!;

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [JsonPropertyName("width")]
        public double Width { get; set; } = default!;

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [JsonPropertyName("height")]
        public double Height { get; set; } = default!;

        /// <summary>
        /// Gets or sets the mimetype.
        /// </summary>
        [JsonPropertyName("mimetype")]
        public string Mimetype { get; set; } = default!;

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
        /// Gets or sets the channel.
        /// </summary>
        [JsonPropertyName("channel")]
        public ICollection<Api_Channel> Channel { get; set; } = default!;

        /// <summary>
        /// Gets or sets the medias.
        /// </summary>
        [JsonPropertyName("medias")]
        public ICollection<Api_Media> Medias { get; set; } = default!;

        /// <summary>
        /// Gets or sets the overlay logos.
        /// </summary>
        [JsonPropertyName("overlayLogos")]
        public ICollection<Api_OverlayLogo> OverlayLogos { get; set; } = default!;

        /// <summary>
        /// Gets or sets the uuid sequence.
        /// </summary>
        [JsonPropertyName("uuidSequence")]
        public Api_UuidSequence UuidSequence { get; set; } = default!;
    }
}