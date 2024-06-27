namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a tariff zone
    /// </summary>

    public partial class TariffZone : Data
    {
        /// <summary>
        /// Unique identifier of the resource `TariffZone`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public TariffZoneLanguage Language { get; set; } = default!;

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tariffs.
        /// </summary>
        [JsonPropertyName("tariffs")]
        public string Tariffs { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tickets_count.
        /// </summary>
        [JsonPropertyName("tickets_count")]
        public int Tickets_count { get; set; } = default!;
    }
}