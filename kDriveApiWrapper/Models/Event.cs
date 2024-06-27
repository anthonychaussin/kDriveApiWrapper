namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The event.
    /// </summary>
    public partial class Event : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Event`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonPropertyName("url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Status of the resource `Event`
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.Required]
        public EventDescription Description { get; set; } = new EventDescription();

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        [JsonPropertyName("comments")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Comments { get; set; } = default!;

        /// <summary>
        /// Gets or sets the services.
        /// </summary>
        [JsonPropertyName("services")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<EventTag> Services { get; set; } = [];

        /// <summary>
        /// Timestamp `Event` has been started
        /// </summary>

        [JsonPropertyName("started_at")]
        public int Started_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Event` has ended
        /// </summary>

        [JsonPropertyName("ended_at")]
        public int? Ended_at { get; set; } = default!;
    }
}