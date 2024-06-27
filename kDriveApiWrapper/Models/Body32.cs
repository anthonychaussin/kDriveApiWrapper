namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body32.
    /// </summary>
    public partial class Body32 : Data
    {
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
        public Body32Right Right { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_ids.
        /// </summary>
        [JsonPropertyName("user_ids")]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public ICollection<int> User_ids { get; set; } = [];
    }
}