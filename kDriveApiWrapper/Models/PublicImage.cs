namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The public image.
    /// </summary>
    public partial class PublicImage : Data
    {
        /// <summary>
        /// Unique identifier of the resource `PublicImage`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the public_url.
        /// </summary>
        [JsonPropertyName("public_url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Public_url { get; set; } = default!;
    }
}