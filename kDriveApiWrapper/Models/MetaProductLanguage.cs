namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a MetaProductLanguage
    /// </summary>

    public partial class MetaProductLanguage : Data
    {
        /// <summary>
        /// Unique identifier of a metaproduct language
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Id of the language related
        /// </summary>

        [JsonPropertyName("language_id")]
        public int Language_id { get; set; } = default!;

        /// <summary>
        /// short flag representing the language
        /// </summary>

        [JsonPropertyName("short")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Short { get; set; } = default!;

        /// <summary>
        /// Name of the metaproduct
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the metaproduct
        /// </summary>

        [JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Description { get; set; } = default!;
    }
}