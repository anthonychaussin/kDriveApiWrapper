namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a fnac ticket
    /// </summary>

    public partial class FnacTicket : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Fnac Ticket`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        [JsonPropertyName("code")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Gets or sets the date_id.
        /// </summary>
        [JsonPropertyName("date_id")]
        public int Date_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the seat.
        /// </summary>
        [JsonPropertyName("seat")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<object> Seat { get; set; } = [];

        /// <summary>
        /// Status of the resource `Fnac Ticket`
        /// </summary>

        [JsonPropertyName("status")]
        public int Status { get; set; } = default!;

        /// <summary>
        /// Gets or sets the entry.
        /// </summary>
        [JsonPropertyName("entry")]
        public int Entry { get; set; } = default!;

        /// <summary>
        /// Timestamp `Fnac Ticket` has been updated
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the hardware_id.
        /// </summary>
        [JsonPropertyName("hardware_id")]
        public string Hardware_id { get; set; } = default!;
    }
}