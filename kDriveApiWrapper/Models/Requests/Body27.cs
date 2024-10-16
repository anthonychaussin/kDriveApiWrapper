namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body27.
    /// </summary>
    public partial class Body27 : Data
    {
        /// <summary>
        /// Gets or sets the emails.
        /// </summary>
        [JsonPropertyName("emails")]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public ICollection<string> Emails { get; set; } = default!;

        /// <summary>
        /// Access level of {name}.&lt;note&gt;&lt;strong&gt;manage&lt;/strong&gt;: Can share, write and read the file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;none&lt;/strong&gt;: Can not act on the file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;read&lt;/strong&gt;: Can only read the file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;write&lt;/strong&gt;: Can write and read the file.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("right")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body27Right Right { get; set; } = default!;

        /// <summary>
        /// Gets or sets the team_ids.
        /// </summary>
        [JsonPropertyName("team_ids")]
        [System.ComponentModel.DataAnnotations.MaxLength(40)]
        public ICollection<int> Team_ids { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_ids.
        /// </summary>
        [JsonPropertyName("user_ids")]
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        public ICollection<int> User_ids { get; set; } = default!;
    }
}