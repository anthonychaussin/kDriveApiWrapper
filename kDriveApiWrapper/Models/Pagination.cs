namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The pagination.
    /// </summary>
    public partial class Pagination
    {
        /// <summary>
        /// Total number of items
        /// <br/>Added when using query parameter `page`
        /// <br/>
        /// </summary>

        [JsonPropertyName("total")]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Number of the current page
        /// <br/>Added when using query parameter `page`
        /// <br/>
        /// </summary>

        [JsonPropertyName("page")]
        public int Page { get; set; } = default!;

        /// <summary>
        /// Total number of pages
        /// <br/>Added when using query parameter `page`
        /// <br/>
        /// </summary>

        [JsonPropertyName("pages")]
        public int Pages { get; set; } = default!;

        /// <summary>
        /// Number of items per page
        /// <br/>Added when using query parameter `page`
        /// <br/>
        /// </summary>

        [JsonPropertyName("items_per_page")]
        public int Items_per_page { get; set; } = default!;

        private IDictionary<string, object>? _additionalProperties;

        /// <summary>
        /// Gets or sets the additional properties.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ??= new Dictionary<string, object>(); }
            set { _additionalProperties = value; }
        }
    }
}