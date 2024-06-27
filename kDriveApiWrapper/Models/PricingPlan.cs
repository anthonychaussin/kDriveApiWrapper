namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The pricing plan.
    /// </summary>
    public partial class PricingPlan : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Pricing Plan`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Pricing Plan`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Get the users and storage limits of the Pricing Plan
        /// </summary>

        [JsonPropertyName("limits")]
        public Limits Limits { get; set; } = default!;

        /// <summary>
        /// Gets or sets the prices.
        /// </summary>
        [JsonPropertyName("prices")]
        public ICollection<Drivepackprice> Prices { get; set; } = default!;

        /// <summary>
        /// Locked/Unlocked features of the Pricing Plan
        /// </summary>

        [JsonPropertyName("capabilities")]
        public Capabilities9 Capabilities { get; set; } = default!;
    }
}