namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The count file.
    /// </summary>
    public partial class CountFile : Data
    {
        /// <summary>
        /// User id
        /// </summary>

        [JsonPropertyName("user_id")]
        public int User_id { get; set; } = default!;

        /// <summary>
        /// Total of actions executed
        /// </summary>

        [JsonPropertyName("executed")]
        public int Executed { get; set; } = default!;

        /// <summary>
        /// Total of actions archived
        /// </summary>

        [JsonPropertyName("archived")]
        public int Archived { get; set; } = default!;

        /// <summary>
        /// Total of actions conflicted
        /// </summary>

        [JsonPropertyName("conflicted")]
        public int Conflicted { get; set; } = default!;
    }
}