namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a Category Language
    /// </summary>

    public partial class CategoryLanguage : Data
    {
        /// <summary>
        /// Unique id of category language
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Id of the language
        /// </summary>

        [JsonPropertyName("language_id")]
        public int Language_id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Category Language`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the resource `Category Language`
        /// </summary>

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;
    }
}