namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The lock.
    /// </summary>
    public partial class Lock : Data
    {
        /// <summary>
        /// When File is locked, locked timestamp
        /// </summary>

        [JsonPropertyName("locked_at")]
        public int? Locked_at { get; set; } = default!;

        /// <summary>
        /// When File is locked, automatic lock release timestamp
        /// </summary>

        [JsonPropertyName("unlocked_at")]
        public int? Unlocked_at { get; set; } = default!;

        /// <summary>
        /// When File is locked, locked reason
        /// </summary>

        [JsonPropertyName("description")]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// When File is locked, locked token
        /// </summary>

        [JsonPropertyName("token")]
        public string? Token { get; set; } = default!;
    }
}