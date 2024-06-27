namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body3.
    /// </summary>
    public partial class Body3 : Data
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
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;
    }
}