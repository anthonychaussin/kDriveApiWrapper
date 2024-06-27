namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a Tariff Category
    /// </summary>

    public partial class TariffCategory : Data
    {
        /// <summary>
        /// Unique id of a tariff category
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Unique id of a tariff
        /// </summary>

        [JsonPropertyName("tariff_id")]
        public int Tariff_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public CategoryLanguage Language { get; set; } = default!;
    }
}