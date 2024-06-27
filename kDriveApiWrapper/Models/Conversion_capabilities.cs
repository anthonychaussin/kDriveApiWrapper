namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The conversion_capabilities.
    /// </summary>
    public partial class Conversion_capabilities
    {
        /// <summary>
        /// Whether the file may be converted upon download
        /// </summary>

        [JsonPropertyName("when_downloading")]
        public bool When_downloading { get; set; } = default!;

        /// <summary>
        /// Available extensions to which the file may be converted upon download, if possible
        /// </summary>

        [JsonPropertyName("download_extensions")]
        public ICollection<string> Download_extensions { get; set; } = default!;

        /// <summary>
        /// Whether the file may be converted for live edition with OnlyOffice
        /// </summary>

        [JsonPropertyName("when_onlyoffice_opening")]
        public bool When_onlyoffice_opening { get; set; } = default!;

        /// <summary>
        /// Available extension to which the file may be converted by OnlyOffice, if possible
        /// </summary>

        [JsonPropertyName("onlyoffice_extension")]
        public string? Onlyoffice_extension { get; set; } = default!;
    }
}