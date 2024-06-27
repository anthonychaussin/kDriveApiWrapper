namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The limits.
    /// </summary>
    public partial class Limits : Data
    {
        /// <summary>
        /// Get users number limit of the Pricing Plan
        /// </summary>

        [JsonPropertyName("users")]
        public Users2 Users { get; set; } = default!;

        /// <summary>
        /// Get the limits of the pricing plan
        /// </summary>

        [JsonPropertyName("storage")]
        public Storage Storage { get; set; } = default!;
    }
}