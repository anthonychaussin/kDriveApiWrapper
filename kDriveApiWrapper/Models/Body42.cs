namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body42.
    /// </summary>
    public partial class Body42 : Data
    {
        /// <summary>
        /// The ids of the files to check
        /// </summary>

        [JsonPropertyName("ids")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<int> Ids { get; set; } = [];
    }
}