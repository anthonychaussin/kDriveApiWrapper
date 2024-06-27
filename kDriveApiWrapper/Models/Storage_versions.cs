namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The storage_versions.
    /// </summary>
    public partial class Storage_versions
    {
        /// <summary>
        /// Default property to sort list of file versions
        /// </summary>

        [JsonPropertyName("property")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Storage_versionsProperty Property { get; set; } = default!;

        /// <summary>
        /// Default sort ordering of list of file versions
        /// </summary>

        [JsonPropertyName("direction")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Direction Direction { get; set; } = default!;
    }
}