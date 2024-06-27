namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// a thread that user is following
    /// </summary>

    public partial class UserThread : Data
    {
        /// <summary>
        /// ID of the post that is this thread's root
        /// </summary>

        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// number of replies in this thread
        /// </summary>

        [JsonPropertyName("reply_count")]
        public int Reply_count { get; set; } = default!;

        /// <summary>
        /// timestamp of the last post to this thread
        /// </summary>

        [JsonPropertyName("last_reply_at")]
        public long Last_reply_at { get; set; } = default!;

        /// <summary>
        /// timestamp of the last time the user viewed this thread
        /// </summary>

        [JsonPropertyName("last_viewed_at")]
        public long Last_viewed_at { get; set; } = default!;

        /// <summary>
        /// list of users participating in this thread. only includes IDs unless 'extended' was set to 'true'
        /// </summary>

        [JsonPropertyName("participants")]
        public ICollection<Post> Participants { get; set; } = default!;

        /// <summary>
        /// Gets or sets the post.
        /// </summary>
        [JsonPropertyName("post")]
        public Post Post { get; set; } = default!;
    }
}