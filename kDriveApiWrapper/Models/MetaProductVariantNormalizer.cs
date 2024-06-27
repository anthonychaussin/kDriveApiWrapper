namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a product variant
    /// </summary>

    public partial class MetaProductVariantNormalizer : Data
    {
        /// <summary>
        /// Id of the variant
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Quantity that was available (not the current quantity)
        /// </summary>

        [JsonPropertyName("quota")]
        public double Quota { get; set; } = default!;

        /// <summary>
        /// Id of the status
        /// </summary>

        [JsonPropertyName("status_id")]
        public int Status_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the vat.
        /// </summary>
        [JsonPropertyName("vat")]
        public double Vat { get; set; } = default!;

        /// <summary>
        /// Gets or sets the current_prices.
        /// </summary>
        [JsonPropertyName("current_prices")]
        public ICollection<MetaProductVariantPriceNormalizer> Current_prices { get; set; } = default!;

        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        [JsonPropertyName("values")]
        public ICollection<ProductAttributeValueNormalizer> Values { get; set; } = default!;

        /// <summary>
        /// Gets or sets the meta_product.
        /// </summary>
        [JsonPropertyName("meta_product")]
        public MetaProduct Meta_product { get; set; } = default!;
    }
}