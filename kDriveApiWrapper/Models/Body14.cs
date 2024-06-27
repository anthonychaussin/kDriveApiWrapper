namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body14.
    /// </summary>
    public partial class Body14 : Data
    {
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        [JsonPropertyName("color")]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"/^#([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$/")]
        public string Color { get; set; } = default!;

        /// <summary>
        /// Gets or sets the default_page.
        /// </summary>
        [JsonPropertyName("default_page")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body14Default_page Default_page { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether hide.
        /// </summary>
        [JsonPropertyName("hide")]
        public bool Hide { get; set; } = default!;
    }
}