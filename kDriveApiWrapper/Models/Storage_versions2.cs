namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The storage_versions2.
    /// </summary>
    public partial class Storage_versions2
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
        public Storage_versions2Property Property { get; set; } = default!;
    }
}