namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The ai_scan.
    /// </summary>
    public partial class Ai_scan
    {
        /// <summary>
        /// Has approved the file scan for IA purpose
        /// </summary>

        [JsonPropertyName("has_approved")]
        public bool Has_approved { get; set; } = default!;

        /// <summary>
        /// Approval date
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int? Updated_at { get; set; } = default!;
    }
}