namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The reservation.
    /// </summary>
    public partial class Reservation : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Reservation`
        /// </summary>

        [JsonPropertyName("id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Position of reservation
        /// </summary>

        [JsonPropertyName("position")]
        public int Position { get; set; } = default!;

        /// <summary>
        /// Type of reservation
        /// </summary>

        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; } = default!;
    }
}