namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body21.
    /// </summary>
    public partial class Body21 : Data
    {
        /// <summary>
        /// Source Drive Identifier
        /// </summary>

        [JsonPropertyName("source_drive_id")]
        public int Source_drive_id { get; set; } = default!;

        /// <summary>
        /// Source File Identifier
        /// </summary>

        [JsonPropertyName("source_file_id")]
        public int Source_file_id { get; set; } = default!;
    }
}