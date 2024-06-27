namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body30.
    /// </summary>
    public partial class Body30 : Data
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
        public Body30Right Right { get; set; } = default!;

        /// <summary>
        /// Gets or sets the team_ids.
        /// </summary>
        [JsonPropertyName("team_ids")]
        [System.ComponentModel.DataAnnotations.MaxLength(40)]
        public ICollection<int> Team_ids { get; set; } = default!;
    }
}