namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a product attribute
    /// </summary>

    public partial class ProductAttributeNormalizer : Data
    {
        /// <summary>
        /// Id of the attribute
        /// </summary>

        [JsonPropertyName("id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Number of metaproducts linked with this attribute
        /// </summary>

        [JsonPropertyName("count_products")]
        public int Count_products { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public ProductAttributeLanguageNormalizer Language { get; set; } = default!;

        /// <summary>
        /// Gets or sets the languages.
        /// </summary>
        [JsonPropertyName("languages")]
        public ICollection<ProductAttributeLanguageNormalizer> Languages { get; set; } = default!;

        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        [JsonPropertyName("values")]
        public ICollection<ProductAttributeValueNormalizer> Values { get; set; } = default!;
    }
}