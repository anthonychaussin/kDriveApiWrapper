namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The ai_scan2.
    /// </summary>
    public partial class Ai_scan2
    {
        /// <summary>
        /// Is AI scanning enabled
        /// </summary>

        [JsonPropertyName("is_enabled")]
        public bool Is_enabled { get; set; } = default!;

        /// <summary>
        /// Is AI scanning approved
        /// </summary>

        [JsonPropertyName("has_approved")]
        public bool? Has_approved { get; set; } = default!;

        /// <summary>
        /// Are AI categories approved
        /// </summary>

        [JsonPropertyName("has_approved_ai_categories")]
        public bool? Has_approved_ai_categories { get; set; } = default!;

        /// <summary>
        /// Is file content search approved
        /// </summary>

        [JsonPropertyName("has_approved_content_search")]
        public bool? Has_approved_content_search { get; set; } = default!;

        /// <summary>
        /// When AI scanning was approved at
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int? Updated_at { get; set; } = default!;
    }
}