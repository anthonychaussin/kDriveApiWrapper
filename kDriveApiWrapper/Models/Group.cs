namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The group.
    /// </summary>
    public partial class Group : Data
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the display_name.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string Display_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; } = default!;

        /// <summary>
        /// Gets or sets the remote_id.
        /// </summary>
        [JsonPropertyName("remote_id")]
        public string Remote_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the create_at.
        /// </summary>
        [JsonPropertyName("create_at")]
        public long Create_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the update_at.
        /// </summary>
        [JsonPropertyName("update_at")]
        public long Update_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the delete_at.
        /// </summary>
        [JsonPropertyName("delete_at")]
        public long Delete_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether has_syncables.
        /// </summary>
        [JsonPropertyName("has_syncables")]
        public bool Has_syncables { get; set; } = default!;
    }
}