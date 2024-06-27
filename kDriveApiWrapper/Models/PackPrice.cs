namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The pack price.
    /// </summary>
    public partial class PackPrice : Data
    {
        /// <summary>
        /// Unique identifier of the resource `PackPrice`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The `PackPrice` without vat
        /// </summary>

        [JsonPropertyName("price_excluding_vat")]
        public double Price_excluding_vat { get; set; } = default!;

        /// <summary>
        /// The `PackPrice` currency
        /// </summary>

        [JsonPropertyName("currency")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PackPriceCurrency Currency { get; set; } = default!;

        /// <summary>
        /// The `PackPrice` time range
        /// </summary>

        [JsonPropertyName("periodicity")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PackPricePeriodicity Periodicity { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the resource `Periodicity`
        /// </summary>

        [JsonPropertyName("periodicity_id")]
        public PackPricePeriodicity_id Periodicity_id { get; set; } = default!;
    }
}