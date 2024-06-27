namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The trash2.
    /// </summary>
    public partial class Trash2 : Data
    {
        /// <summary>
        /// Default property to sort trash
        /// </summary>

        [JsonPropertyName("property")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Trash2Property Property { get; set; } = default!;

        /// <summary>
        /// Default sort ordering of trash
        /// </summary>

        [JsonPropertyName("direction")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Direction Direction { get; set; } = default!;
    }
}