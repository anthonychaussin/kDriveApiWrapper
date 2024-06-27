namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The files.
    /// </summary>
    public partial class Files : Data
    {
        /// <summary>
        /// Default property to sort file list
        /// </summary>

        [JsonPropertyName("property")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FilesProperty Property { get; set; } = default!;

        /// <summary>
        /// Default sort ordering of file list
        /// </summary>

        [JsonPropertyName("direction")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Direction Direction { get; set; } = default!;
    }
}