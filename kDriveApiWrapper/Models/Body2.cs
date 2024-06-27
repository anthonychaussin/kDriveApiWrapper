namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body2.
    /// </summary>
    public partial class Body2 : Data
    {
        /// <summary>
        /// Gets or sets a value indicating whether can_create_category.
        /// </summary>
        [JsonPropertyName("can_create_category")]
        public bool Can_create_category { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether can_delete_category.
        /// </summary>
        [JsonPropertyName("can_delete_category")]
        public bool Can_delete_category { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether can_edit_category.
        /// </summary>
        [JsonPropertyName("can_edit_category")]
        public bool Can_edit_category { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether can_put_category_on_file.
        /// </summary>
        [JsonPropertyName("can_put_category_on_file")]
        public bool Can_put_category_on_file { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether can_read_category_on_file.
        /// </summary>
        [JsonPropertyName("can_read_category_on_file")]
        public bool Can_read_category_on_file { get; set; } = default!;

        /// <summary>
        /// Gets or sets the team_id.
        /// </summary>
        [JsonPropertyName("team_id")]
        public int Team_id { get; set; } = default!;

        /// <summary>
        /// User identifier
        /// </summary>

        [JsonPropertyName("user_id")]
        public int User_id { get; set; } = default!;
    }
}