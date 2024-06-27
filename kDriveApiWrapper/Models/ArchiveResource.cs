namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The archive resource.
    /// </summary>
    public partial class ArchiveResource : Data
    {
        /// <summary>
        /// Universally unique identifier of the resource `Archive Resource`
        /// </summary>

        [JsonPropertyName("uuid")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// Number of files in the archive
        /// </summary>

        [JsonPropertyName("number_of_files")]
        public int Number_of_files { get; set; } = default!;

        /// <summary>
        /// Gets or sets the infected_files.
        /// </summary>
        [JsonPropertyName("infected_files")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<File> Infected_files { get; set; } = [];

        /// <summary>
        /// Gets or sets the pua_files.
        /// </summary>
        [JsonPropertyName("pua_files")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<File> Pua_files { get; set; } = [];
    }
}