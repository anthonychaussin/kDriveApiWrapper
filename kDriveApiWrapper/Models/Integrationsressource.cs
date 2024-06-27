namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The integrationsressource.
    /// </summary>
    public partial class Integrationsressource : Data
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonPropertyName("url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether constant_url.
        /// </summary>
        [JsonPropertyName("constant_url")]
        public bool Constant_url { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `stream` that is related to the resource `Integrations ressource`
        /// </summary>

        [JsonPropertyName("stream_id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Stream_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether dvr_available.
        /// </summary>
        [JsonPropertyName("dvr_available")]
        public bool Dvr_available { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether dvr_enabled.
        /// </summary>
        [JsonPropertyName("dvr_enabled")]
        public bool Dvr_enabled { get; set; } = default!;
    }
}