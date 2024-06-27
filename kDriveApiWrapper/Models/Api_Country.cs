namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Country
    /// </summary>

    public partial class Api_Country
    {
        /// <summary>
        /// ISO 3166-1 alpha-2
        /// </summary>

        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// ISO 3166-1 alpha-3
        /// </summary>

        [JsonPropertyName("alpha3")]
        public string Alpha3 { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the official_state_name.
        /// </summary>
        [JsonPropertyName("official_state_name")]
        public string Official_state_name { get; set; } = default!;
    }
}