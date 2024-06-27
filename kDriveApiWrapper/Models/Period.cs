namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a period
    /// </summary>

    public partial class Period : Data
    {
        /// <summary>
        /// Unique identifier of this entity
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the group_id.
        /// </summary>
        [JsonPropertyName("group_id")]
        public int Group_id { get; set; } = default!;

        /// <summary>
        /// Timestamp `Period` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Number of paid reservations
        /// </summary>

        [JsonPropertyName("paid_reservations")]
        public string Paid_reservations { get; set; } = default!;

        /// <summary>
        /// Gets or sets the organizer.
        /// </summary>
        [JsonPropertyName("organizer")]
        public Organizer Organizer { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public PeriodLanguage Language { get; set; } = default!;

        /// <summary>
        /// Gets or sets the features.
        /// </summary>
        [JsonPropertyName("features")]
        public string Features { get; set; } = default!;
    }
}