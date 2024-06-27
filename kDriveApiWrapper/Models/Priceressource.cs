namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The priceressource.
    /// </summary>
    public partial class Priceressource : Data
    {
        /// <summary>
        /// Gets or sets the excl_vat.
        /// </summary>
        [JsonPropertyName("excl_vat")]
        public double Excl_vat { get; set; } = default!;
    }
}