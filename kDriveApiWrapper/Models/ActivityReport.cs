namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The activity report.
    /// </summary>
    public partial class ActivityReport : Data
    {
        /// <summary>
        /// Activity report identifier
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Report status:&lt;/br&gt; in_progress: Report generation still in progress&lt;/br&gt; done: Report can be downloaded/exported&lt;/br&gt; failed: Report generation failed
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ActivityReportStatus Status { get; set; } = default!;

        /// <summary>
        /// Size in octet of the report
        /// </summary>

        [JsonPropertyName("size")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Size { get; set; } = default!;

        /// <summary>
        /// Gets or sets the generated_by.
        /// </summary>
        [JsonPropertyName("generated_by")]
        [System.ComponentModel.DataAnnotations.Required]
        public User Generated_by { get; set; } = new User();

        /// <summary>
        /// The download url of the report content
        /// </summary>

        [JsonPropertyName("download_url")]
        public string? Download_url { get; set; } = default!;

        /// <summary>
        /// Timestamp `Activity Report` was created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int? Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Activity Report` was updated at
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int? Updated_at { get; set; } = default!;

        /// <summary>
        /// Filter used to generate the report
        /// </summary>

        [JsonPropertyName("filters")]
        public Filters Filters { get; set; } = default!;
    }
}