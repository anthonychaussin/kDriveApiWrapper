namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The country.
    /// </summary>
    public partial class Country : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Country`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Country`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Short name of the resource `Country`
        /// </summary>

        [JsonPropertyName("short_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Short_name { get; set; } = default!;

        /// <summary>
        /// Is the resource `Country` enabled?
        /// </summary>

        [JsonPropertyName("is_enabled")]
        public bool Is_enabled { get; set; } = default!;
    }
}