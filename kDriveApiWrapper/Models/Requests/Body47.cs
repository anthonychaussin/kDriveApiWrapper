namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body47.
    /// </summary>
    public partial class Body47 : Data
    {
        /// <summary>
        /// Name of the File/Directory
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }
}