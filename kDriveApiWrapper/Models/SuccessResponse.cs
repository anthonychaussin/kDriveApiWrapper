namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The success response.
    /// </summary>
    public partial class SuccessResponse : Response
    {
        /// <summary>
        /// Effective response
        /// </summary>

        [JsonPropertyName("data")]
        public Data Data { get; set; } = default!;
    }
}