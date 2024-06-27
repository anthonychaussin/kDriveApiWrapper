namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The activity4.
    /// </summary>
    public partial class Activity4 : Data
    {
        /// <summary>
        /// Timestamp of the last user access of the Shared Generic File
        /// </summary>

        [JsonPropertyName("last_accessed_at")]
        public int Last_accessed_at { get; set; } = default!;
    }
}