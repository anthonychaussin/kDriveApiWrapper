namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The partnership income total.
    /// </summary>
    public partial class PartnershipIncomeTotal : Data
    {
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonPropertyName("amount")]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        [JsonPropertyName("currency")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Currency { get; set; } = default!;
    }
}