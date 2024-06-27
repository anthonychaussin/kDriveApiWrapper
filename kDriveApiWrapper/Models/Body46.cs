namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body46.
    /// </summary>
    public partial class Body46 : Data
    {
        /// <summary>
        /// The name of the file
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The extension of the file
        /// </summary>

        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body46Type Type { get; set; } = default!;
    }
}