namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The navigator response.
    /// </summary>
    public partial class NavigatorResponse : Data
    {
        /// <summary>
        /// Cursor pagination uses a cursor to track the current position in the dataset. This cursor should be passed back in the subsequent API request in order to retrieve the next set of results or page of the list.
        /// </summary>

        [JsonPropertyName("cursor")]
        public string? Cursor { get; set; } = default!;

        /// <summary>
        /// The has_more boolean flag indicates whether additional items are available beyond the current page of results.
        /// </summary>

        [JsonPropertyName("has_more")]
        public bool Has_more { get; set; } = default!;

        /// <summary>
        /// The timestamp, in seconds, indicating when the dataset was generated.
        /// </summary>

        [JsonPropertyName("response_at")]
        public int Response_at { get; set; } = default!;
    }
}