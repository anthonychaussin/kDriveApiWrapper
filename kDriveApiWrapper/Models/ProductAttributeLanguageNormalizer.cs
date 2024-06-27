namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a ProductAttributeLanguage
    /// </summary>

    public partial class ProductAttributeLanguageNormalizer : Data
    {
        /// <summary>
        /// Name of the attribute
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Id of the language related
        /// </summary>

        [JsonPropertyName("language_id")]
        public int Language_id { get; set; } = default!;

        /// <summary>
        /// short flag representing the language
        /// </summary>

        [JsonPropertyName("short")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Short { get; set; } = default!;
    }
}