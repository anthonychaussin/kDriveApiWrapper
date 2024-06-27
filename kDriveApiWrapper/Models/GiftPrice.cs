namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a Gift Price
    /// </summary>

    public partial class GiftPrice : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Gift Price`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonPropertyName("price")]
        public double Price { get; set; } = default!;

        /// <summary>
        /// Gets or sets the status_id.
        /// </summary>
        [JsonPropertyName("status_id")]
        public int Status_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the gift.
        /// </summary>
        [JsonPropertyName("gift")]
        public Gift Gift { get; set; } = default!;
    }
}