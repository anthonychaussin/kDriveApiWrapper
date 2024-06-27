namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The ai discount.
    /// </summary>
    public partial class AiDiscount : Data
    {
        /// <summary>
        /// Gets or sets the start_at.
        /// </summary>
        [JsonPropertyName("start_at")]
        public int Start_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the end_at.
        /// </summary>
        [JsonPropertyName("end_at")]
        public int End_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the used_credit_count.
        /// </summary>
        [JsonPropertyName("used_credit_count")]
        public int Used_credit_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the max_credit_count.
        /// </summary>
        [JsonPropertyName("max_credit_count")]
        public int Max_credit_count { get; set; } = default!;
    }
}