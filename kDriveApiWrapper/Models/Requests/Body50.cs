namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body50.
    /// </summary>
    public partial class Body50 : Data
    {
        /// <summary>
        /// Name of File in the destination Directory
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }
}