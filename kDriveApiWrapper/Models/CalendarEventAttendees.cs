namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The calendar event attendees.
    /// </summary>
    public partial class CalendarEventAttendees : Data
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        [JsonPropertyName("address")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Address { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether organizer.
        /// </summary>
        [JsonPropertyName("organizer")]
        public bool Organizer { get; set; } = default!;

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [JsonPropertyName("state")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CalendarEventAttendeesState State { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string Name { get; set; } = default!;
    }
}