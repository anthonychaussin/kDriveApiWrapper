namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The geolocationressource.
    /// </summary>
    public partial class Geolocationressource : Data
    {
        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        [JsonPropertyName("locations")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<object> Locations { get; set; } = [];

        /// <summary>
        /// Timestamp `Geolocation ressource` from
        /// </summary>

        [JsonPropertyName("from")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string From { get; set; } = default!;

        /// <summary>
        /// Timestamp `Geolocation ressource` to
        /// </summary>

        [JsonPropertyName("to")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string To { get; set; } = default!;
    }
}