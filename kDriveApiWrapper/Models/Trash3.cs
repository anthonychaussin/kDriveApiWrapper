namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The trash3.
    /// </summary>
    public partial class Trash3 : Data
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
        public Trash3Property Property { get; set; } = default!;
    }
}