namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drivepackprice.
    /// </summary>
    public partial class Drivepackprice : Data
    {
        /// <summary>
        /// Drive pack price type, Base: standard price, User : Additional user price, Storage_giga : Additional storage price
        /// </summary>

        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DrivepackpriceType Type { get; set; } = default!;

        /// <summary>
        /// Unity of additional type
        /// </summary>

        [JsonPropertyName("unit")]
        public int Unit { get; set; } = default!;

        /// <summary>
        /// Price by months
        /// </summary>

        [JsonPropertyName("period")]
        public int Period { get; set; } = default!;

        /// <summary>
        /// Currency identifier
        /// </summary>

        [JsonPropertyName("currency_id")]
        public int Currency_id { get; set; } = default!;

        /// <summary>
        /// Price without the tax
        /// </summary>

        [JsonPropertyName("amount_excl_vat")]
        public double Amount_excl_vat { get; set; } = default!;

        /// <summary>
        /// Price with the tax
        /// </summary>

        [JsonPropertyName("amount_incl_vat")]
        public double Amount_incl_vat { get; set; } = default!;
    }
}