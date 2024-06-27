namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The periodicity.
    /// </summary>
    public partial class Periodicity : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Periodicity`
        /// </summary>

        [JsonPropertyName("id")]
        public PeriodicityId Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the unite.
        /// </summary>
        [JsonPropertyName("unite")]
        public int Unite { get; set; } = default!;

        /// <summary>
        /// The `PackPrice` time range
        /// </summary>

        [JsonPropertyName("value")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PeriodicityValue Value { get; set; } = default!;
    }
}