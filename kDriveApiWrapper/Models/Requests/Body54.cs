namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body54.
    /// </summary>
    public partial class Body54 : Data
    {
        /// <summary>
        /// Gets or sets the star.
        /// </summary>
        [JsonPropertyName("*")]
        [System.ComponentModel.DataAnnotations.Required]
        public Star Star { get; set; } = new Star();
    }
}