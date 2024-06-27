namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The storage_largest2.
    /// </summary>
    public partial class Storage_largest2
    {
        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        [JsonPropertyName("direction")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Direction Direction { get; set; } = default!;

        /// <summary>
        /// Gets or sets the property.
        /// </summary>
        [JsonPropertyName("property")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Storage_largest2Property Property { get; set; } = default!;
    }
}