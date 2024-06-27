namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The swiss backup discount.
    /// </summary>
    public partial class SwissBackupDiscount : Data
    {
        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        [JsonPropertyName("label")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// Commitment period (in years)
        /// </summary>

        [JsonPropertyName("periodicity")]
        public int Periodicity { get; set; } = default!;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [JsonPropertyName("value")]
        public int Value { get; set; } = default!;
    }
}