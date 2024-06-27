namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The total success response.
    /// </summary>
    public partial class TotalSuccessResponse : SuccessResponse
    {
        /// <summary>
        /// Total number of results
        /// </summary>

        [JsonPropertyName("total")]
        public int Total { get; set; } = default!;
    }
}