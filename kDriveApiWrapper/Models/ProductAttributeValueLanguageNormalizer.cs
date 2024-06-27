namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a product attribute value translation
    /// </summary>

    public partial class ProductAttributeValueLanguageNormalizer : Data
    {
        /// <summary>
        /// Name of the value
        /// </summary>

        [JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Value { get; set; } = default!;

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