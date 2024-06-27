namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// User's sidebar category with it's channels
    /// </summary>

    public partial class SidebarCategoryWithChannels : Data
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_id.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string User_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the team_id.
        /// </summary>
        [JsonPropertyName("team_id")]
        public string Team_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the display_name.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string Display_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SidebarCategoryWithChannelsType Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the channel_ids.
        /// </summary>
        [JsonPropertyName("channel_ids")]
        public ICollection<string> Channel_ids { get; set; } = default!;
    }
}