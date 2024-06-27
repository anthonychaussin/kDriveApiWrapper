namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The temporary u r l.
    /// </summary>
    public partial class TemporaryURL : Data
    {
        /// <summary>
        /// The temporary url for a file
        /// </summary>

        [JsonPropertyName("temporary_url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Temporary_url { get; set; } = default!;
    }
}