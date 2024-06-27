namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a Pass Category
    /// </summary>

    public partial class PassCategory : Data
    {
        /// <summary>
        /// Unique id of a pass category
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the period.
        /// </summary>
        [JsonPropertyName("period")]
        public Period Period { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public CategoryLanguage Language { get; set; } = default!;

        /// <summary>
        /// Gets or sets the zones.
        /// </summary>
        [JsonPropertyName("zones")]
        public ICollection<TariffZone> Zones { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether has_renewed_pass.
        /// </summary>
        [JsonPropertyName("has_renewed_pass")]
        public bool Has_renewed_pass { get; set; } = default!;
    }
}