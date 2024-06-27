namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The cursor.
    /// </summary>
    public partial class Cursor : Data
    {
        /// <summary>
        /// ID of the user who created the cursor
        /// </summary>

        [JsonPropertyName("user_id")]
        public int User_id { get; set; } = default!;

        /// <summary>
        /// ID of the directory the cursor was created in
        /// </summary>

        [JsonPropertyName("source_id")]
        public int Source_id { get; set; } = default!;

        /// <summary>
        /// ID of the last activity seen by the cursor
        /// </summary>

        [JsonPropertyName("activity_id")]
        public int Activity_id { get; set; } = default!;

        /// <summary>
        /// Timestamp of the cursor's creation
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Whether the cursor also reads children directories
        /// </summary>

        [JsonPropertyName("recursive")]
        public bool Recursive { get; set; } = default!;

        /// <summary>
        /// Current page of cursor data
        /// </summary>

        [JsonPropertyName("page")]
        public int? Page { get; set; } = default!;

        /// <summary>
        /// Curent limit of cursor
        /// </summary>

        [JsonPropertyName("limit")]
        public int? Limit { get; set; } = default!;
    }
}