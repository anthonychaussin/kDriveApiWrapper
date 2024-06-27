namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The reaction.
    /// </summary>
    public partial class Reaction : Data
    {
        /// <summary>
        /// The ID of the user that made this reaction
        /// </summary>

        [JsonPropertyName("user_id")]
        public string User_id { get; set; } = default!;

        /// <summary>
        /// The ID of the post to which this reaction was made
        /// </summary>

        [JsonPropertyName("post_id")]
        public string Post_id { get; set; } = default!;

        /// <summary>
        /// The name of the emoji that was used for this reaction
        /// </summary>

        [JsonPropertyName("emoji_name")]
        public string Emoji_name { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds this reaction was made
        /// </summary>

        [JsonPropertyName("create_at")]
        public long Create_at { get; set; } = default!;
    }
}