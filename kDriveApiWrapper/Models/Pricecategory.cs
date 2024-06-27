namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a category of price
    /// </summary>

    public partial class Pricecategory : Data
    {
        /// <summary>
        /// Unique identifier of this entity
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        [JsonPropertyName("currency")]
        public int Currency { get; set; } = default!;

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonPropertyName("amount")]
        public double Amount { get; set; } = default!;
    }
}