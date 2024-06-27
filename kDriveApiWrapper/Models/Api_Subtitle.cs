namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Subtitle
    /// </summary>

    public partial class Api_Subtitle
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the lines.
        /// </summary>
        [JsonPropertyName("lines")]
        public string Lines { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_at.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether published.
        /// </summary>
        [JsonPropertyName("published")]
        public bool Published { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether default.
        /// </summary>
        [JsonPropertyName("default")]
        public bool Default { get; set; } = default!;

        /// <summary>
        /// Gets or sets the link.
        /// </summary>
        [JsonPropertyName("link")]
        public ICollection<string> Link { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public ICollection<Api_Language> Language { get; set; } = default!;
    }
}