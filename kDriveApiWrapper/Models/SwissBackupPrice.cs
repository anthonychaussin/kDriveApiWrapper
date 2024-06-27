namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The swiss backup price.
    /// </summary>
    public partial class SwissBackupPrice : Data
    {
        /// <summary>
        /// Type of the resource `Swiss Backup Price`
        /// </summary>

        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        [JsonPropertyName("unit")]
        public int Unit { get; set; } = default!;

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        [JsonPropertyName("currency")]
        public int Currency { get; set; } = default!;

        /// <summary>
        /// Amount incl. VAT
        /// </summary>

        [JsonPropertyName("amount")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Amount { get; set; } = default!;

        /// <summary>
        /// Amount excl. VAT
        /// </summary>

        [JsonPropertyName("amount_excl_vat")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Amount_excl_vat { get; set; } = default!;
    }
}