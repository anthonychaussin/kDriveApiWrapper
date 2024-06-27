namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The emoji.
    /// </summary>
    public partial class Emoji : Data
    {
        /// <summary>
        /// The ID of the emoji
        /// </summary>

        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the user that made the emoji
        /// </summary>

        [JsonPropertyName("creator_id")]
        public string Creator_id { get; set; } = default!;

        /// <summary>
        /// The name of the emoji
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds the emoji was made
        /// </summary>

        [JsonPropertyName("create_at")]
        public long Create_at { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds the emoji was last updated
        /// </summary>

        [JsonPropertyName("update_at")]
        public long Update_at { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds the emoji was deleted
        /// </summary>

        [JsonPropertyName("delete_at")]
        public long Delete_at { get; set; } = default!;
    }
}