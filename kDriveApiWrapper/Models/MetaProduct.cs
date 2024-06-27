namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a MetaProduct
    /// </summary>

    public partial class MetaProduct : Data
    {
        /// <summary>
        /// Unique id of the entity
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Id of the related status of the metaproduct
        /// </summary>

        [JsonPropertyName("status_id")]
        public int Status_id { get; set; } = default!;

        /// <summary>
        /// Pickup type
        /// </summary>

        [JsonPropertyName("collect_options")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MetaProductCollect_options Collect_options { get; set; } = default!;

        /// <summary>
        /// Image representing the metaproduct displayed in the shop
        /// </summary>

        [JsonPropertyName("image")]
        public string Image { get; set; } = default!;

        /// <summary>
        /// Valid sold metaproducts
        /// </summary>

        [JsonPropertyName("count_sold")]
        public int Count_sold { get; set; } = default!;

        /// <summary>
        /// Sold metaproducts even if order is cancelled
        /// </summary>

        [JsonPropertyName("count_all_products_sold")]
        public int Count_all_products_sold { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public MetaProductLanguage Language { get; set; } = default!;

        /// <summary>
        /// Gets or sets the languages.
        /// </summary>
        [JsonPropertyName("languages")]
        public ICollection<MetaProductLanguage> Languages { get; set; } = default!;

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        [JsonPropertyName("attributes")]
        public ICollection<ProductAttributeNormalizer> Attributes { get; set; } = default!;

        /// <summary>
        /// Gets or sets the variants.
        /// </summary>
        [JsonPropertyName("variants")]
        public ICollection<MetaProductVariantNormalizer> Variants { get; set; } = default!;

        /// <summary>
        /// If the metaproduct is link to other elements with dependency rules
        /// </summary>

        [JsonPropertyName("has_dependencies")]
        public bool Has_dependencies { get; set; } = default!;
    }
}