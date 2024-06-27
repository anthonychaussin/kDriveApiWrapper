namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a date
    /// </summary>

    public partial class Date : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Date`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the date1.
        /// </summary>
        [JsonPropertyName("date")]
        public int Date1 { get; set; } = default!;

        /// <summary>
        /// Gets or sets the opening_doors.
        /// </summary>
        [JsonPropertyName("opening_doors")]
        public int Opening_doors { get; set; } = default!;

        /// <summary>
        /// Gets or sets the closing_doors.
        /// </summary>
        [JsonPropertyName("closing_doors")]
        public int Closing_doors { get; set; } = default!;

        /// <summary>
        /// Gets or sets the end.
        /// </summary>
        [JsonPropertyName("end")]
        public int End { get; set; } = default!;

        /// <summary>
        /// Gets or sets the capacity.
        /// </summary>
        [JsonPropertyName("capacity")]
        public int Capacity { get; set; } = default!;

        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        [JsonPropertyName("event")]
        public Event Event { get; set; } = default!;

        /// <summary>
        /// Gets or sets the zones.
        /// </summary>
        [JsonPropertyName("zones")]
        public ICollection<TariffZone> Zones { get; set; } = default!;

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address { get; set; } = default!;

        /// <summary>
        /// Gets or sets the hallmap_address.
        /// </summary>
        [JsonPropertyName("hallmap_address")]
        public Address Hallmap_address { get; set; } = default!;

        /// <summary>
        /// Gets or sets the features.
        /// </summary>
        [JsonPropertyName("features")]
        public string Features { get; set; } = default!;
    }
}