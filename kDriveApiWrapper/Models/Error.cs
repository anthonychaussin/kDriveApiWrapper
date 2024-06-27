namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The error.
    /// </summary>
    public partial class Error : Data
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonPropertyName("context")]
        public object Context { get; set; } = default!;
    }
}