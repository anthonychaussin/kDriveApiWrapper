namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The periodressource.
    /// </summary>
    public partial class Periodressource : Data
    {
        /// <summary>
        /// Gets or sets the monthly.
        /// </summary>
        [JsonPropertyName("monthly")]
        [System.ComponentModel.DataAnnotations.Required]
        public Priceressource Monthly { get; set; } = new Priceressource();

        /// <summary>
        /// Gets or sets the yearly.
        /// </summary>
        [JsonPropertyName("yearly")]
        [System.ComponentModel.DataAnnotations.Required]
        public Priceressource Yearly { get; set; } = new Priceressource();
    }
}