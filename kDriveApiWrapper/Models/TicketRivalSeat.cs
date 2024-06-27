namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Seat Ticket Rival
    /// </summary>

    public partial class TicketRivalSeat : Data
    {
        /// <summary>
        /// Gets or sets the row.
        /// </summary>
        [JsonPropertyName("row")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Row { get; set; } = default!;

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        [JsonPropertyName("number")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Number { get; set; } = default!;
    }
}