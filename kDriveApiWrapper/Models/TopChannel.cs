namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The top channel.
    /// </summary>
    public partial class TopChannel : Data
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the display_name.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string Display_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the team_id.
        /// </summary>
        [JsonPropertyName("team_id")]
        public string Team_id { get; set; } = default!;

        /// <summary>
        /// The number of messages posted in the channel by users over the given time period (not including messages posted by bots).
        /// </summary>

        [JsonPropertyName("message_count")]
        public string Message_count { get; set; } = default!;
    }
}