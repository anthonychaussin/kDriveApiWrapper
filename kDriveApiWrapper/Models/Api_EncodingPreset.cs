namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// EncodingPreset
    /// </summary>

    public partial class Api_EncodingPreset
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_EncodingPresetType Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the template.
        /// </summary>
        [JsonPropertyName("template")]
        public Encoding_preset_template Template { get; set; } = default!;
    }
}