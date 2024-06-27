namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The storage.
    /// </summary>
    public partial class Storage : Data
    {
        /// <summary>
        /// Included/Allowed storage (in gigabyte)
        /// </summary>

        [JsonPropertyName("giga")]
        public int Giga { get; set; } = default!;

        /// <summary>
        /// Minimum number of additional storage (in gigabyte)
        /// </summary>

        [JsonPropertyName("min")]
        public int? Min { get; set; } = default!;

        /// <summary>
        /// Maximum number of additional storage (in gigabyte)
        /// </summary>

        [JsonPropertyName("max")]
        public int? Max { get; set; } = default!;
    }
}