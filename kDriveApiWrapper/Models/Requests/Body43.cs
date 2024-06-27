namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body43.
    /// </summary>
    public partial class Body43 : Data
    {
        /// <summary>
        /// Destination directory identifier
        /// </summary>

        [JsonPropertyName("destination_directory_id")]
        public int Destination_directory_id { get; set; } = default!;
    }
}