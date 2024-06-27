namespace kDriveApiWrapper.Models.Trash
{
    /// <summary>
    /// The trash2.
    /// </summary>
    public partial class TrashSearch : Data
    {
        /// <summary>
        /// Default property to sort trash
        /// </summary>

        [JsonPropertyName("property")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TrashProperty Property { get; set; } = default!;

        /// <summary>
        /// Default sort ordering of trash
        /// </summary>

        [JsonPropertyName("direction")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Direction Direction { get; set; } = default!;
    }
}