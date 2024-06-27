namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The language.
    /// </summary>
    public partial class Language : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Language`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Language`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Short name of the resource `Language`
        /// </summary>

        [JsonPropertyName("short_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Short_name { get; set; } = default!;

        /// <summary>
        /// Represents a language identifier and a region identifier
        /// </summary>

        [JsonPropertyName("locale")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Locale { get; set; } = default!;

        /// <summary>
        /// Represents a language identifier
        /// </summary>

        [JsonPropertyName("short_locale")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Short_locale { get; set; } = default!;
    }
}