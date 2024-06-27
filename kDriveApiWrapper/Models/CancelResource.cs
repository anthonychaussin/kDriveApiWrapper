namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The cancel resource.
    /// </summary>
    public partial class CancelResource : Data
    {
        /// <summary>
        /// Gets or sets the cancel_id.
        /// </summary>
        [JsonPropertyName("cancel_id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Cancel_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the valid_until.
        /// </summary>
        [JsonPropertyName("valid_until")]
        public int Valid_until { get; set; } = default!;
    }
}