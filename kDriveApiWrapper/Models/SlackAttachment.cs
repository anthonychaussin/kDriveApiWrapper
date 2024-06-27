namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The slack attachment.
    /// </summary>
    public partial class SlackAttachment : Data
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("Id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the fallback.
        /// </summary>
        [JsonPropertyName("Fallback")]
        public string Fallback { get; set; } = default!;

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        [JsonPropertyName("Color")]
        public string Color { get; set; } = default!;

        /// <summary>
        /// Gets or sets the pretext.
        /// </summary>
        [JsonPropertyName("Pretext")]
        public string Pretext { get; set; } = default!;

        /// <summary>
        /// Gets or sets the author name.
        /// </summary>
        [JsonPropertyName("AuthorName")]
        public string AuthorName { get; set; } = default!;

        /// <summary>
        /// Gets or sets the author link.
        /// </summary>
        [JsonPropertyName("AuthorLink")]
        public string AuthorLink { get; set; } = default!;

        /// <summary>
        /// Gets or sets the author icon.
        /// </summary>
        [JsonPropertyName("AuthorIcon")]
        public string AuthorIcon { get; set; } = default!;

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonPropertyName("Title")]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Gets or sets the title link.
        /// </summary>
        [JsonPropertyName("TitleLink")]
        public string TitleLink { get; set; } = default!;

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        [JsonPropertyName("Text")]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        [JsonPropertyName("Fields")]
        public ICollection<SlackAttachmentField> Fields { get; set; } = default!;

        /// <summary>
        /// Gets or sets the image u r l.
        /// </summary>
        [JsonPropertyName("ImageURL")]
        public string ImageURL { get; set; } = default!;

        /// <summary>
        /// Gets or sets the thumb u r l.
        /// </summary>
        [JsonPropertyName("ThumbURL")]
        public string ThumbURL { get; set; } = default!;

        /// <summary>
        /// Gets or sets the footer.
        /// </summary>
        [JsonPropertyName("Footer")]
        public string Footer { get; set; } = default!;

        /// <summary>
        /// Gets or sets the footer icon.
        /// </summary>
        [JsonPropertyName("FooterIcon")]
        public string FooterIcon { get; set; } = default!;

        /// <summary>
        /// The timestamp of the slack attachment, either type of string or integer
        /// </summary>

        [JsonPropertyName("Timestamp")]
        public string Timestamp { get; set; } = default!;
    }
}