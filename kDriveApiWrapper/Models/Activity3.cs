namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The activity3.
    /// </summary>
    public partial class Activity3 : Data
    {
        /// <summary>
        /// Timestamp of the last user access of the Directory
        /// </summary>

        [JsonPropertyName("last_accessed_at")]
        public int Last_accessed_at { get; set; } = default!;
    }
}