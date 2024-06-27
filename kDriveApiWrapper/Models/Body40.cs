namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body40.
    /// </summary>
    public partial class Body40 : Data
    {
        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        [JsonPropertyName("body")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Body { get; set; } = default!;
    }
}