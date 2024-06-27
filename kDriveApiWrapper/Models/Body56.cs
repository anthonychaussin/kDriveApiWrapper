namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body56.
    /// </summary>
    public partial class Body56 : Data
    {
        /// <summary>
        /// Gets or sets the star.
        /// </summary>
        [JsonPropertyName("*")]
        [System.ComponentModel.DataAnnotations.Required]
        public Star2 Star { get; set; } = new Star2();
    }
}