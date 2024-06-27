namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The settings.
    /// </summary>
    public partial class Settings : Data
    {
        /// <summary>
        /// Gets or sets the ai_scan.
        /// </summary>
        [JsonPropertyName("ai_scan")]
        public Ai_scan2 Ai_scan { get; set; } = default!;

        /// <summary>
        /// Gets or sets the versioning.
        /// </summary>
        [JsonPropertyName("versioning")]
        public Versioning Versioning { get; set; } = default!;

        /// <summary>
        /// Max time the files of an user deleted is kept
        /// </summary>

        [JsonPropertyName("max_keep_deleted_user")]
        public string Max_keep_deleted_user { get; set; } = default!;
    }
}