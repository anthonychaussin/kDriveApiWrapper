namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The response.
    /// </summary>
    public partial class Response
    {
        /// <summary>
        /// Result of the HTTP request
        /// </summary>

        [JsonPropertyName("result")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ResponseResult Result { get; set; } = default!;

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        public Data Data { get; set; }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        [JsonPropertyName("error")]
        public Error Error { get; set; } = default!;


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
    }
}