namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The capabilities3.
    /// </summary>
    public partial class Capabilities3 : Data
    {
        /// <summary>
        /// Does share link allow editing
        /// </summary>

        [JsonPropertyName("can_edit")]
        public bool Can_edit { get; set; } = default!;

        /// <summary>
        /// Does share link allow stats to be seen
        /// </summary>

        [JsonPropertyName("can_see_stats")]
        public bool Can_see_stats { get; set; } = default!;

        /// <summary>
        /// Does share link allow info to be seen
        /// </summary>

        [JsonPropertyName("can_see_info")]
        public bool Can_see_info { get; set; } = default!;

        /// <summary>
        /// Does share link allow download
        /// </summary>

        [JsonPropertyName("can_download")]
        public bool Can_download { get; set; } = default!;

        /// <summary>
        /// Does share link allow adding comments
        /// </summary>

        [JsonPropertyName("can_comment")]
        public bool Can_comment { get; set; } = default!;
    }
}