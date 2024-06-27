namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The api error.
    /// </summary>
    public partial class ApiError : Data
    {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; } = default!;

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        [JsonPropertyName("error")]
        public Error Error { get; set; } = default!;
    }
}