namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// A completion choices.
    /// </summary>

    public partial class Choice : Data
    {
        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        [JsonPropertyName("role")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        [JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Content { get; set; } = default!;
    }
}