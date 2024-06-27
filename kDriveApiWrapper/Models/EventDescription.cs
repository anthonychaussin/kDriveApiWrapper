namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The event description.
    /// </summary>
    public partial class EventDescription : Data
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("title")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Description of the resource `Event Description`
        /// </summary>

        [JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the translations.
        /// </summary>
        [JsonPropertyName("translations")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<EventTranslation> Translations { get; set; } = [];
    }
}