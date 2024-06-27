namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The chart_c361f33b.
    /// </summary>
    public partial class Chart_c361f33b
    {
        /// <summary>
        /// Chart title
        /// </summary>

        [JsonPropertyName("title")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        [JsonPropertyName("labels")]
        [System.ComponentModel.DataAnnotations.Required]
        public Chart Labels { get; set; } = new Chart();

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [JsonPropertyName("data")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<Chart> Data { get; set; } = [];
    }
}