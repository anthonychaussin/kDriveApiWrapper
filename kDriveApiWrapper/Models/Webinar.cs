namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a Webinar
    /// </summary>

    public partial class Webinar : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Webinar`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the firstname.
        /// </summary>
        [JsonPropertyName("firstname")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Firstname { get; set; } = default!;

        /// <summary>
        /// Gets or sets the lastname.
        /// </summary>
        [JsonPropertyName("lastname")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Lastname { get; set; } = default!;

        /// <summary>
        /// Gets or sets the firm.
        /// </summary>
        [JsonPropertyName("firm")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Firm { get; set; } = default!;

        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        [JsonPropertyName("event")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Event { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ticket_quantity.
        /// </summary>
        [JsonPropertyName("ticket_quantity")]
        public int Ticket_quantity { get; set; } = default!;

        /// <summary>
        /// Email
        /// </summary>

        [JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Gets or sets the average_price.
        /// </summary>
        [JsonPropertyName("average_price")]
        public double Average_price { get; set; } = default!;

        /// <summary>
        /// Gets or sets the needs.
        /// </summary>
        [JsonPropertyName("needs")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Needs { get; set; } = default!;

        /// <summary>
        /// Gets or sets the blurb.
        /// </summary>
        [JsonPropertyName("blurb")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Blurb { get; set; } = default!;

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        [JsonPropertyName("phone")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Phone { get; set; } = default!;

        /// <summary>
        /// Timestamp `Webinar` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tracking_state.
        /// </summary>
        [JsonPropertyName("tracking_state")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Tracking_state { get; set; } = default!;

        /// <summary>
        /// Status of the resource `Webinar`
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Status { get; set; } = default!;
    }
}