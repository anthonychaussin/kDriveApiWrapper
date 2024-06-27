namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The sharefile.
    /// </summary>
    public partial class Sharefile : Data
    {
        /// <summary>
        /// Shared file identifier
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// File name
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the update_at.
        /// </summary>
        [JsonPropertyName("update_at")]
        public int Update_at { get; set; } = default!;

        /// <summary>
        /// Number of active users on file
        /// </summary>

        [JsonPropertyName("users")]
        public int Users { get; set; } = default!;
    }
}