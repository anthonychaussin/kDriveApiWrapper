namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a ticket
    /// </summary>

    public partial class Ticket : Data
    {
        /// <summary>
        /// Unique identifier of a Ticket
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonPropertyName("amount")]
        public double Amount { get; set; } = default!;

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        [JsonPropertyName("date")]
        public Date Date { get; set; } = default!;

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
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Date_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the status_id.
        /// </summary>
        [JsonPropertyName("status_id")]
        public int Status_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the entry_at.
        /// </summary>
        [JsonPropertyName("entry_at")]
        public int Entry_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Ticket` has been updated
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the hardware_id.
        /// </summary>
        [JsonPropertyName("hardware_id")]
        public string? Hardware_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the reservation.
        /// </summary>
        [JsonPropertyName("reservation")]
        public Reservation Reservation { get; set; } = default!;

        /// <summary>
        /// Gets or sets the pass.
        /// </summary>
        [JsonPropertyName("pass")]
        public Pass Pass { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tariff.
        /// </summary>
        [JsonPropertyName("tariff")]
        public TariffCategory Tariff { get; set; } = default!;

        /// <summary>
        /// Gets or sets the zone.
        /// </summary>
        [JsonPropertyName("zone")]
        public TariffZone Zone { get; set; } = default!;

        /// <summary>
        /// Gets or sets the is_inside.
        /// </summary>
        [JsonPropertyName("is_inside")]
        public string? Is_inside { get; set; } = default!;

        /// <summary>
        /// Gets or sets the seat.
        /// </summary>
        [JsonPropertyName("seat")]
        public Seat Seat { get; set; } = default!;

        /// <summary>
        /// Gets or sets the icon_type.
        /// </summary>
        [JsonPropertyName("icon_type")]
        public int? Icon_type { get; set; } = default!;
    }
}