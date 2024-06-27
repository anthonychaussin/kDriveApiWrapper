namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The error response.
    /// </summary>
    public partial class ErrorResponse : Data
    {
        /// <summary>
        /// Result of the HTTP request
        /// </summary>

        [JsonPropertyName("result")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Result { get; set; } = default!;
    }
}