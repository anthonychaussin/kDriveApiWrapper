namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The response success total specific.
    /// </summary>
    public partial class ResponseSuccessTotalSpecific : Data
    {
        /// <summary>
        /// Total number of results
        /// </summary>

        [JsonPropertyName("total")]
        public int Total { get; set; } = default!;
    }
}