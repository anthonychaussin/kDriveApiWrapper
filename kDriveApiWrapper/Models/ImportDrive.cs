namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The import drive.
    /// </summary>
    public partial class ImportDrive : Data
    {
        /// <summary>
        /// Gets or sets the drives.
        /// </summary>
        [JsonPropertyName("drives")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<Drive_26fe3376> Drives { get; set; } = [];

        /// <summary>
        /// The access token identifier built for future requests over identified drives
        /// </summary>

        [JsonPropertyName("access_token_id")]
        public int Access_token_id { get; set; } = default!;
    }
}