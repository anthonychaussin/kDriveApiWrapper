namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body4.
    /// </summary>
    public partial class Body4 : Data
    {
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        [JsonPropertyName("color")]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"/^#([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$/")]
        public string Color { get; set; } = default!;

        /// <summary>
        /// Name of the Category
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }
}