namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body6.
    /// </summary>
    public partial class Body6 : Data
    {
        /// <summary>
        /// If the `User` consents to the AI scan.
        /// </summary>

        [JsonPropertyName("has_approved")]
        public bool Has_approved { get; set; } = default!;

        /// <summary>
        /// If the `User` consents to automatic `Categories` on `Files`.
        /// </summary>

        [JsonPropertyName("has_approved_ai_categories")]
        public bool Has_approved_ai_categories { get; set; } = default!;

        /// <summary>
        /// If the `User` consents to search in `Files` contents.
        /// </summary>

        [JsonPropertyName("has_approved_content_search")]
        public bool Has_approved_content_search { get; set; } = default!;
    }
}