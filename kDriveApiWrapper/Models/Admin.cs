namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The admin.
    /// </summary>
    public partial class Admin : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Admin`
        /// </summary>

        [JsonPropertyName("id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        [JsonPropertyName("currency")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// Gets or sets the currency_pretty.
        /// </summary>
        [JsonPropertyName("currency_pretty")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Currency_pretty { get; set; } = default!;
    }
}