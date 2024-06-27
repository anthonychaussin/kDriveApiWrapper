namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body41.
    /// </summary>
    public partial class Body41 : Data
    {
        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether is_resolved.
        /// </summary>
        [JsonPropertyName("is_resolved")]
        public bool Is_resolved { get; set; } = default!;
    }
}