namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The post.
    /// </summary>
    public partial class Post : Data
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds a post was created
        /// </summary>

        [JsonPropertyName("create_at")]
        public long Create_at { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds a post was last updated
        /// </summary>

        [JsonPropertyName("update_at")]
        public long Update_at { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds a post was deleted
        /// </summary>

        [JsonPropertyName("delete_at")]
        public long Delete_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the edit_at.
        /// </summary>
        [JsonPropertyName("edit_at")]
        public long Edit_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_id.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string User_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the channel_id.
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string Channel_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the root_id.
        /// </summary>
        [JsonPropertyName("root_id")]
        public string Root_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the original_id.
        /// </summary>
        [JsonPropertyName("original_id")]
        public string Original_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the props.
        /// </summary>
        [JsonPropertyName("props")]
        public object Props { get; set; } = default!;

        /// <summary>
        /// Gets or sets the hashtag.
        /// </summary>
        [JsonPropertyName("hashtag")]
        public string Hashtag { get; set; } = default!;

        /// <summary>
        /// Gets or sets the file_ids.
        /// </summary>
        [JsonPropertyName("file_ids")]
        public ICollection<string> File_ids { get; set; } = default!;

        /// <summary>
        /// Gets or sets the pending_post_id.
        /// </summary>
        [JsonPropertyName("pending_post_id")]
        public string Pending_post_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [JsonPropertyName("metadata")]
        public PostMetadata Metadata { get; set; } = default!;
    }
}