namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body5.
    /// </summary>
    public partial class Body5 : Data
    {
        /// <summary>
        /// True if category is correct, False if incorrect. Removes category if False.
        /// </summary>

        [JsonPropertyName("valid")]
        public bool Valid { get; set; } = default!;
    }
}