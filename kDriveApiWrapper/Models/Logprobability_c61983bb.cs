namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Log probability information for the choice.
    /// </summary>

    public partial class Logprobability_c61983bb
    {
        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        [JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<Logprobability> Content { get; set; } = [];
    }
}