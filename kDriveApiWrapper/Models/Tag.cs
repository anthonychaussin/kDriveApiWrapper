namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The tag.
    /// </summary>
    public partial class Tag : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Tag`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Tag`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        [JsonPropertyName("color")]
        public int Color { get; set; } = default!;

        /// <summary>
        /// Product count related to the resource `Tag`
        /// </summary>

        [JsonPropertyName("product_count")]
        public int Product_count { get; set; } = default!;
    }
}