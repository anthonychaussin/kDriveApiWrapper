namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The versioning.
    /// </summary>
    public partial class Versioning : Data
    {
        /// <summary>
        /// Number of versions that can be kept if active
        /// </summary>

        [JsonPropertyName("max_numbers")]
        public int Max_numbers { get; set; } = default!;

        /// <summary>
        /// Maximum number of days versions are kept
        /// </summary>

        [JsonPropertyName("max_days")]
        public int Max_days { get; set; } = default!;
    }
}