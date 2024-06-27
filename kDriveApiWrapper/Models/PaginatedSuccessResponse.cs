namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The paginated success response.
    /// </summary>
    public partial class PaginatedSuccessResponse : TotalSuccessResponse
    {
        /// <summary>
        /// Total number of pages
        /// </summary>

        [JsonPropertyName("pages")]
        public int Pages { get; set; } = default!;

        /// <summary>
        /// The current page
        /// </summary>

        [JsonPropertyName("page")]
        public int Page { get; set; } = default!;

        /// <summary>
        /// Number of results per page
        /// </summary>

        [JsonPropertyName("items_per_page")]
        public int Items_per_page { get; set; } = default!;
    }
}