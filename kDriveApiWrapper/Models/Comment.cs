namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The comment.
    /// </summary>
    public partial class Comment : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Comment`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Comment parent identifier. If present, this comment is a response of another comment
        /// </summary>

        [JsonPropertyName("parent_id")]
        public int Parent_id { get; set; } = default!;

        /// <summary>
        /// Comment message
        /// </summary>

        [JsonPropertyName("body")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Body { get; set; } = default!;

        /// <summary>
        /// If a comment is set as resolved, solved.
        /// </summary>

        [JsonPropertyName("is_resolved")]
        public bool Is_resolved { get; set; } = default!;

        /// <summary>
        /// Timestamp `Comment` was created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Comment` was updated at
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;

        /// <summary>
        /// if the comment is liked
        /// </summary>

        [JsonPropertyName("liked")]
        public bool Liked { get; set; } = default!;

        /// <summary>
        /// Number of likes
        /// </summary>

        [JsonPropertyName("likes_count")]
        public int Likes_count { get; set; } = default!;

        /// <summary>
        /// Number of responses for this comment
        /// </summary>

        [JsonPropertyName("responses_count")]
        public int Responses_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; } = default!;

        /// <summary>
        /// Gets or sets the responses.
        /// </summary>
        [JsonPropertyName("responses")]
        public ICollection<Comment> Responses { get; set; } = default!;

        /// <summary>
        /// Gets or sets the likes.
        /// </summary>
        [JsonPropertyName("likes")]
        public ICollection<User> Likes { get; set; } = default!;
    }
}