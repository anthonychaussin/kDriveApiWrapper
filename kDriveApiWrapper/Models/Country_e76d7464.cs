namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The country_e76d7464.
    /// </summary>
    public partial class Country_e76d7464
    {
        /// <summary>
        /// Unique identifier of the resource `Country`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the short.
        /// </summary>
        [JsonPropertyName("short")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Short { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Country`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; } = default!;
    }
}