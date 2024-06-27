namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a product variant price
    /// </summary>

    public partial class MetaProductVariantPriceNormalizer : Data
    {
        /// <summary>
        /// Id of the variant price
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Id of the currency
        /// </summary>

        [JsonPropertyName("currency_id")]
        public int Currency_id { get; set; } = default!;

        /// <summary>
        /// price of the variant
        /// </summary>

        [JsonPropertyName("price")]
        public double Price { get; set; } = default!;
    }
}