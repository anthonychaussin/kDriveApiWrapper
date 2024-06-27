namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The event translation.
    /// </summary>
    public partial class EventTranslation : Data
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("title")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        [JsonPropertyName("body")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EventTranslationLanguage Language { get; set; } = default!;
    }
}