namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The public cloud price.
    /// </summary>
    public partial class PublicCloudPrice : Data
    {
        /// <summary>
        /// Gets or sets the c h f_excl_tax.
        /// </summary>
        [JsonPropertyName("CHF_excl_tax")]
        public double CHF_excl_tax { get; set; } = default!;

        /// <summary>
        /// Gets or sets the c h f_incl_tax.
        /// </summary>
        [JsonPropertyName("CHF_incl_tax")]
        public double CHF_incl_tax { get; set; } = default!;

        /// <summary>
        /// Gets or sets the e u r_excl_tax.
        /// </summary>
        [JsonPropertyName("EUR_excl_tax")]
        public double EUR_excl_tax { get; set; } = default!;

        /// <summary>
        /// Gets or sets the e u r_incl_tax.
        /// </summary>
        [JsonPropertyName("EUR_incl_tax")]
        public double EUR_incl_tax { get; set; } = default!;
    }
}