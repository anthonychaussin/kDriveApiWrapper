namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body24.
    /// </summary>
    public partial class Body24 : Data
    {
        /// <summary>
        /// Name of File in the destination Directory
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }
}