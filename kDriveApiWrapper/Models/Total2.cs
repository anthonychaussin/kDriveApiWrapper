namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The total2.
    /// </summary>
    public partial class Total2 : Data
    {
        /// <summary>
        /// Gets or sets the executed.
        /// </summary>
        [JsonPropertyName("executed")]
        public int Executed { get; set; } = default!;

        /// <summary>
        /// Gets or sets the archived.
        /// </summary>
        [JsonPropertyName("archived")]
        public int Archived { get; set; } = default!;

        /// <summary>
        /// Gets or sets the conflicted.
        /// </summary>
        [JsonPropertyName("conflicted")]
        public int Conflicted { get; set; } = default!;
    }
}