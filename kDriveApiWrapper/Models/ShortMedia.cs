namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Media
    /// </summary>

    public partial class ShortMedia : Data
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether validated.
        /// </summary>
        [JsonPropertyName("validated")]
        public bool Validated { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether published.
        /// </summary>
        [JsonPropertyName("published")]
        public bool Published { get; set; } = default!;

        /// <summary>
        /// Gets or sets the streams.
        /// </summary>
        [JsonPropertyName("streams")]
        public ICollection<string> Streams { get; set; } = default!;

        /// <summary>
        /// Gets or sets the shot_boundaries.
        /// </summary>
        [JsonPropertyName("shot_boundaries")]
        public ICollection<object> Shot_boundaries { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether key_restricted.
        /// </summary>
        [JsonPropertyName("key_restricted")]
        public bool Key_restricted { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether ip_restricted.
        /// </summary>
        [JsonPropertyName("ip_restricted")]
        public bool Ip_restricted { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether country_restricted.
        /// </summary>
        [JsonPropertyName("country_restricted")]
        public bool Country_restricted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [JsonPropertyName("state")]
        public int State { get; set; } = default!;

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
        /// Gets or sets the folder.
        /// </summary>
        [JsonPropertyName("folder")]
        public ShortFolder Folder { get; set; } = default!;

        /// <summary>
        /// Gets or sets the upload.
        /// </summary>
        [JsonPropertyName("upload")]
        public ShortUpload Upload { get; set; } = default!;
    }
}