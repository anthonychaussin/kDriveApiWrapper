namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive_26fe3376.
    /// </summary>
    public partial class Drive_26fe3376
    {
        /// <summary>
        /// Drive identifier
        /// </summary>

        [JsonPropertyName("id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Drive name
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;
    }
}