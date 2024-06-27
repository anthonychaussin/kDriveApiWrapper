namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The files2.
    /// </summary>
    public partial class Files2 : Data
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
        public Files2Property Property { get; set; } = default!;
    }
}