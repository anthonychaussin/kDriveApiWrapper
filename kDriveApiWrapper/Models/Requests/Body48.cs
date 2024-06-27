namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body48.
    /// </summary>
    public partial class Body48 : Data
    {
        /// <summary>
        /// Name of the File/Directory
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }
}