namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The pricesressource.
    /// </summary>
    public partial class Pricesressource : Data
    {
        /// <summary>
        /// Gets or sets the pack.
        /// </summary>
        [JsonPropertyName("pack")]
        [System.ComponentModel.DataAnnotations.Required]
        public Periodressource Pack { get; set; } = new Periodressource();

        /// <summary>
        /// Gets or sets the excess.
        /// </summary>
        [JsonPropertyName("excess")]
        [System.ComponentModel.DataAnnotations.Required]
        public Periodressource Excess { get; set; } = new Periodressource();

        /// <summary>
        /// Gets or sets the additional_channel.
        /// </summary>
        [JsonPropertyName("additional_channel")]
        [System.ComponentModel.DataAnnotations.Required]
        public Periodressource Additional_channel { get; set; } = new Periodressource();

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        [JsonPropertyName("currency")]
        [System.ComponentModel.DataAnnotations.Required]
        public Admin Currency { get; set; } = new Admin();
    }
}