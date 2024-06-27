namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The k_suite.
    /// </summary>
    public partial class K_suite
    {
        /// <summary>
        /// Id of the kSuite
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the kSuite
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Id of the type of kSuite
        /// </summary>

        [JsonPropertyName("pack_id")]
        public int Pack_id { get; set; } = default!;

        /// <summary>
        /// Name of the type of kSuite
        /// </summary>

        [JsonPropertyName("pack")]
        public string Pack { get; set; } = default!;
    }
}