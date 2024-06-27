namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The event tag.
    /// </summary>
    public partial class EventTag : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Event Tag`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Event Tag`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public EventTag Type { get; set; } = default!;
    }
}