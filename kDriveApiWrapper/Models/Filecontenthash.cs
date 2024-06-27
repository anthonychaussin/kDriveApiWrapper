namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The filecontenthash.
    /// </summary>
    public partial class Filecontenthash : Data
    {
        /// <summary>
        /// The hash of file content
        /// </summary>

        [JsonPropertyName("hash")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Hash { get; set; } = default!;
    }
}