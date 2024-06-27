namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The source2.
    /// </summary>
    public partial class Source2 : Data
    {
        /// <summary>
        /// Name of the source
        /// </summary>

        [JsonPropertyName("name")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Source2Name Name { get; set; } = default!;

        /// <summary>
        /// Ip of the source
        /// </summary>

        [JsonPropertyName("ip")]
        public string Ip { get; set; } = default!;

        /// <summary>
        /// User Agent of the source
        /// </summary>

        [JsonPropertyName("user_agent")]
        public string User_agent { get; set; } = default!;

        /// <summary>
        /// Device of the source
        /// </summary>

        [JsonPropertyName("device")]
        public string Device { get; set; } = default!;

        /// <summary>
        /// Location of the source
        /// </summary>

        [JsonPropertyName("location")]
        public string Location { get; set; } = default!;
    }
}