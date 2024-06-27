namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The sanitizer.
    /// </summary>
    public partial class Sanitizer : Data
    {
        /// <summary>
        /// Gets or sets the sanitized.
        /// </summary>
        [JsonPropertyName("sanitized")]
        public int Sanitized { get; set; } = default!;

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        [JsonPropertyName("total")]
        public Total Total { get; set; } = default!;

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        [JsonPropertyName("team")]
        public Team2 Team { get; set; } = default!;

        /// <summary>
        /// Gets or sets the me.
        /// </summary>
        [JsonPropertyName("me")]
        public Me Me { get; set; } = default!;

        /// <summary>
        /// Gets or sets the others.
        /// </summary>
        [JsonPropertyName("others")]
        public string Others { get; set; } = default!;
    }
}