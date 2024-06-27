using kDriveApiWrapper.Models.Trash;

namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive settings.
    /// </summary>
    public partial class DriveSettings : Data
    {
        /// <summary>
        /// Gets or sets the ai_scan.
        /// </summary>
        [JsonPropertyName("ai_scan")]
        [System.ComponentModel.DataAnnotations.Required]
        public Ai_scan Ai_scan { get; set; } = new Ai_scan();

        /// <summary>
        /// Gets or sets the shared_link.
        /// </summary>
        [JsonPropertyName("shared_link")]
        [System.ComponentModel.DataAnnotations.Required]
        public Shared_link Shared_link { get; set; } = new Shared_link();

        /// <summary>
        /// Gets or sets the trash.
        /// </summary>
        [JsonPropertyName("trash")]
        [System.ComponentModel.DataAnnotations.Required]
        public TrashOption Trash { get; set; } = new TrashOption();
    }
}