namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body22.
    /// </summary>
    public partial class Body22 : Data
    {
        /// <summary>
        /// Indicate whether the current version should be kept forever
        /// </summary>

        [JsonPropertyName("keep_forever")]
        public bool Keep_forever { get; set; } = default!;
    }
}