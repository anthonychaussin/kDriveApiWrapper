namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The statistic sharelink.
    /// </summary>
    public partial class StatisticSharelink : Data
    {
        /// <summary>
        /// Share link url
        /// </summary>

        [JsonPropertyName("url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Gets or sets the file_id.
        /// </summary>
        [JsonPropertyName("file_id")]
        public int File_id { get; set; } = default!;

        /// <summary>
        /// Rights required to view the share link.&lt;note&gt;&lt;strong&gt;inherit&lt;/strong&gt;: Share link is accessible only by users of the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;password&lt;/strong&gt;: Share link is public but protected by a password.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;public&lt;/strong&gt;: Share link is public, no restriction set.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("right")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public StatisticSharelinkRight Right { get; set; } = default!;

        /// <summary>
        /// Until when the share link is valid
        /// </summary>

        [JsonPropertyName("valid_until")]
        public int? Valid_until { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the creator of the resource `Statistic Share link`
        /// </summary>

        [JsonPropertyName("created_by")]
        public int Created_by { get; set; } = default!;

        /// <summary>
        /// Timestamp `Statistic Share link` was created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int? Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Statistic Share link` was updated at
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int? Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the capabilities.
        /// </summary>
        [JsonPropertyName("capabilities")]
        [System.ComponentModel.DataAnnotations.Required]
        public Capabilities3 Capabilities { get; set; } = new Capabilities3();

        /// <summary>
        /// If the share link is blocked
        /// </summary>

        [JsonPropertyName("access_blocked")]
        public bool Access_blocked { get; set; } = default!;

        /// <summary>
        /// Number of view on share link
        /// </summary>

        [JsonPropertyName("views")]
        public int Views { get; set; } = default!;

        /// <summary>
        /// File information if the user has right to see the file.
        /// </summary>

        [JsonPropertyName("file")]
        public File? File { get; set; } = default!;

        /// <summary>
        /// Number of unique views on share link
        /// </summary>

        [JsonPropertyName("unique_views")]
        public int Unique_views { get; set; } = default!;
    }
}