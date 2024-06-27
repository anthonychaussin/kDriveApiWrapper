namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a GiftLanguage
    /// </summary>

    public partial class GiftLanguage : Data
    {
        /// <summary>
        /// Unique identifier of the resource `GiftLanguage`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `GiftLanguage`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;
    }
}