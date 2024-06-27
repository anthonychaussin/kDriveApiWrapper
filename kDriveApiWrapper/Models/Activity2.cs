namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The activity2.
    /// </summary>
    public partial class Activity2 : Data
    {
        /// <summary>
        /// Timestamp of the last user access of the File
        /// </summary>

        [JsonPropertyName("last_accessed_at")]
        public int Last_accessed_at { get; set; } = default!;
    }
}