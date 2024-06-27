namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Channel
    /// </summary>

    public partial class Api_Channel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the statistic_ignored_ip.
        /// </summary>
        [JsonPropertyName("statistic_ignored_ip")]
        public ICollection<string> Statistic_ignored_ip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_at.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether auto_empty_trash.
        /// </summary>
        [JsonPropertyName("auto_empty_trash")]
        public bool Auto_empty_trash { get; set; } = default!;

        /// <summary>
        /// Gets or sets the journal.
        /// </summary>
        [JsonPropertyName("journal")]
        public ICollection<Api_MediaJournalLog> Journal { get; set; } = default!;
    }
}