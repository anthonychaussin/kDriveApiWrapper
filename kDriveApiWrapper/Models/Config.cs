namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The config.
    /// </summary>
    public partial class Config : Data
    {
        /// <summary>
        /// count
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("count")]
        public int Count { get; set; } = default!;

        /// <summary>
        /// last_error
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("last_error")]
        public int Last_error { get; set; } = default!;

        /// <summary>
        /// last_error_code
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("last_error_code")]
        public int Last_error_code { get; set; } = default!;
    }
}