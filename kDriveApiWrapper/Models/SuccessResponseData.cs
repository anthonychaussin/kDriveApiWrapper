namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The success response data.
    /// </summary>
    public partial class SuccessResponseData : Data
    {
        /// <summary>
        /// Effective response
        /// </summary>

        [JsonPropertyName("data")]
        public Data Data { get; set; } = default!;
    }
}