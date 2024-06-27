namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Language
    /// </summary>

    public partial class Api_Language : Data
    {
        /// <summary>
        /// ISO 639-1
        /// </summary>

        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the endonym.
        /// </summary>
        [JsonPropertyName("endonym")]
        public string Endonym { get; set; } = default!;
    }
}