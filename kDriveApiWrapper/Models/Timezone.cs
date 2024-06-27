namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The timezone.
    /// </summary>
    public partial class Timezone : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Timezone`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Timezone`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Greenwich Mean Time (GMT)
        /// </summary>

        [JsonPropertyName("gmt")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Gmt { get; set; } = default!;
    }
}