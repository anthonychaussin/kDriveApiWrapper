namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body.
    /// </summary>
    public partial class Body : Data
    {
        /// <summary>
        /// Gets or sets the date_format.
        /// </summary>
        [JsonPropertyName("date_format")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BodyDate_format Date_format { get; set; } = default!;

        /// <summary>
        /// Gets or sets the default_drive.
        /// </summary>
        [JsonPropertyName("default_drive")]
        public int Default_drive { get; set; } = default!;

        /// <summary>
        /// Gets or sets the density.
        /// </summary>
        [JsonPropertyName("density")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BodyDensity Density { get; set; } = default!;

        /// <summary>
        /// Gets or sets the list.
        /// </summary>
        [JsonPropertyName("list")]
        public List2 List { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether sort_recent_file.
        /// </summary>
        [JsonPropertyName("sort_recent_file")]
        public bool Sort_recent_file { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tutorials.
        /// </summary>
        [JsonPropertyName("tutorials")]
        public ICollection<int> Tutorials { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether use_shortcut.
        /// </summary>
        [JsonPropertyName("use_shortcut")]
        public bool Use_shortcut { get; set; } = default!;
    }
}