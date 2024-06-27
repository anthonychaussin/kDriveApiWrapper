namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a tariff zone language
    /// </summary>

    public partial class TariffZoneLanguage : Data
    {
        /// <summary>
        /// Unique identifier of the resource `TariffZoneLanguage`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `TariffZoneLanguage`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;
    }
}