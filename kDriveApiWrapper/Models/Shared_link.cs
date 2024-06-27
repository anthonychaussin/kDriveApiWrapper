namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The shared_link.
    /// </summary>
    public partial class Shared_link
    {
        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        [JsonPropertyName("images")]
        public ICollection<PublicImage> Images { get; set; } = default!;

        /// <summary>
        /// Custom share-link is activate
        /// </summary>

        [JsonPropertyName("activate")]
        public bool Activate { get; set; } = default!;

        /// <summary>
        /// Text color for share-link
        /// </summary>

        [JsonPropertyName("txtColor")]
        public string? TxtColor { get; set; } = default!;

        /// <summary>
        /// Background color for share-link
        /// </summary>

        [JsonPropertyName("bgColor")]
        public string? BgColor { get; set; } = default!;
    }
}