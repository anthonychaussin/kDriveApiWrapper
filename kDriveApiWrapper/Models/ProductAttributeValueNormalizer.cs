namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a product attribute value
    /// </summary>

    public partial class ProductAttributeValueNormalizer : Data
    {
        /// <summary>
        /// Id of the product attribute value
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public ProductAttributeValueLanguageNormalizer Language { get; set; } = default!;

        /// <summary>
        /// Gets or sets the languages.
        /// </summary>
        [JsonPropertyName("languages")]
        public ICollection<ProductAttributeValueLanguageNormalizer> Languages { get; set; } = default!;
    }
}