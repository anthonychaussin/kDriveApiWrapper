namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body20.
    /// </summary>
    public partial class Body20 : Data
    {
        /// <summary>
        /// Name of the File/Directory
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;
    }
}