namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The top reaction.
    /// </summary>
    public partial class TopReaction : Data
    {
        /// <summary>
        /// The name of the emoji used for this reaction.
        /// </summary>

        [JsonPropertyName("emoji_name")]
        public string Emoji_name { get; set; } = default!;

        /// <summary>
        /// The number of the times this emoji has been used.
        /// </summary>

        [JsonPropertyName("count")]
        public long Count { get; set; } = default!;
    }
}