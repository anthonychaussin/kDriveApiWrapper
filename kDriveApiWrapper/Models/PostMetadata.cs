namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Additional information used to display a post.
    /// </summary>

    public partial class PostMetadata : Data
    {
        /// <summary>
        /// Information about content embedded in the post including OpenGraph previews, image link previews, and message attachments. This field will be null if the post does not contain embedded content.
        /// <br/>
        /// </summary>

        [JsonPropertyName("embeds")]
        public ICollection<Embeds> Embeds { get; set; } = default!;

        /// <summary>
        /// The custom emojis that appear in this point or have been used in reactions to this post. This field will be null if the post does not contain custom emojis.
        /// <br/>
        /// </summary>

        [JsonPropertyName("emojis")]
        public ICollection<Emoji> Emojis { get; set; } = default!;

        /// <summary>
        /// The FileInfo objects for any files attached to the post. This field will be null if the post does not have any file attachments.
        /// <br/>
        /// </summary>

        [JsonPropertyName("files")]
        public ICollection<FileInfo> Files { get; set; } = default!;

        /// <summary>
        /// An object mapping the URL of an external image to an object containing the dimensions of that image. This field will be null if the post or its embedded content does not reference any external images.
        /// <br/>
        /// </summary>

        [JsonPropertyName("images")]
        public object Images { get; set; } = default!;

        /// <summary>
        /// Any reactions made to this point. This field will be null if no reactions have been made to this post.
        /// <br/>
        /// </summary>

        [JsonPropertyName("reactions")]
        public ICollection<Reaction> Reactions { get; set; } = default!;
    }
}