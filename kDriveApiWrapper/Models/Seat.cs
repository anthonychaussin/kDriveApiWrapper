namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a seat
    /// </summary>

    public partial class Seat : Data
    {
        /// <summary>
        /// Unique identifier of a Seat
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Seat number
        /// </summary>

        [JsonPropertyName("number")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Number { get; set; } = default!;

        /// <summary>
        /// Row name
        /// </summary>

        [JsonPropertyName("row")]
        public string Row { get; set; } = default!;

        /// <summary>
        /// Bloc name
        /// </summary>

        [JsonPropertyName("bloc")]
        public string Bloc { get; set; } = default!;
    }
}