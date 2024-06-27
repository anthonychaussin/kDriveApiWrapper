namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body28.
    /// </summary>
    public partial class Body28 : Data
    {
        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        [JsonPropertyName("emails")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public ICollection<string> Emails { get; set; } = [];

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonPropertyName("message")]
        public string? Message { get; set; } = default!;

        /// <summary>
        /// Access level of {name}.&lt;note&gt;&lt;strong&gt;manage&lt;/strong&gt;: Can share, write and read the file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;none&lt;/strong&gt;: Can not act on the file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;read&lt;/strong&gt;: Can only read the file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;write&lt;/strong&gt;: Can write and read the file.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("right")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body28Right Right { get; set; } = default!;
    }
}