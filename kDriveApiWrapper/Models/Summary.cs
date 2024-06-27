namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The summary.
    /// </summary>
    public partial class Summary : Data
    {
        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        [JsonPropertyName("total")]
        public Total2 Total { get; set; } = default!;

        /// <summary>
        /// Gets or sets the team.
        /// </summary>
        [JsonPropertyName("team")]
        public Team3 Team { get; set; } = default!;

        /// <summary>
        /// Gets or sets the me.
        /// </summary>
        [JsonPropertyName("me")]
        public Me2 Me { get; set; } = default!;

        /// <summary>
        /// Gets or sets the others.
        /// </summary>
        [JsonPropertyName("others")]
        public ICollection<CountFile> Others { get; set; } = default!;
    }
}