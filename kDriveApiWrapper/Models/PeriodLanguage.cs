namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a period language
    /// </summary>

    public partial class PeriodLanguage : Data
    {
        /// <summary>
        /// Unique identifier of this entity
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the language
        /// </summary>

        [JsonPropertyName("language_id")]
        public int Language_id { get; set; } = default!;

        /// <summary>
        /// Name of the period
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;
    }
}