namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The embeds.
    /// </summary>
    public partial class Embeds : Data
    {
        /// <summary>
        /// The type of content that is embedded in this point.
        /// </summary>

        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EmbedsType Type { get; set; } = default!;

        /// <summary>
        /// The URL of the embedded content, if one exists.
        /// </summary>

        [JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Any additional information about the embedded content. Only used at this time to store OpenGraph metadata.
        /// <br/>This field will be null for non-OpenGraph embeds.
        /// <br/>
        /// </summary>

        [JsonPropertyName("data")]
        public object Data { get; set; } = default!;
    }
}