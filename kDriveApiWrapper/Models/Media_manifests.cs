namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// manifest
    /// </summary>

    public partial class Media_manifests
    {
        /// <summary>
        /// Gets or sets the json.
        /// </summary>
        [JsonPropertyName("json")]
        public Json Json { get; set; } = default!;

        /// <summary>
        /// Gets or sets the xml.
        /// </summary>
        [JsonPropertyName("xml")]
        public Xml Xml { get; set; } = default!;

        /// <summary>
        /// Gets or sets the v1xml.
        /// </summary>
        [JsonPropertyName("v1xml")]
        public V1xml V1xml { get; set; } = default!;

        /// <summary>
        /// Gets or sets the yaml.
        /// </summary>
        [JsonPropertyName("yaml")]
        public Yaml Yaml { get; set; } = default!;

        /// <summary>
        /// Gets or sets the yml.
        /// </summary>
        [JsonPropertyName("yml")]
        public Yml Yml { get; set; } = default!;
    }
}