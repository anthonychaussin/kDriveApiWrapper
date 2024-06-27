namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The storage_largest.
    /// </summary>
    public partial class Storage_largest
    {
        /// <summary>
        /// Default property to sort largest items list
        /// </summary>

        [JsonPropertyName("property")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Storage_largestProperty Property { get; set; } = default!;

        /// <summary>
        /// Default sort ordering of largest items list
        /// </summary>

        [JsonPropertyName("direction")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Direction Direction { get; set; } = default!;
    }
}