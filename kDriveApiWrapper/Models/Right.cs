namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The right.
    /// </summary>
    public partial class Right : Data
    {
        /// <summary>
        /// Gets or sets a value indicating whether technical.
        /// </summary>
        [JsonPropertyName("technical")]
        public bool Technical { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether statistic.
        /// </summary>
        [JsonPropertyName("statistic")]
        public bool Statistic { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether check.
        /// </summary>
        [JsonPropertyName("check")]
        public bool Check { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether sale.
        /// </summary>
        [JsonPropertyName("sale")]
        public bool Sale { get; set; } = default!;
    }
}