namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The chart.
    /// </summary>
    public partial class Chart : Data
    {
        /// <summary>
        /// X coordinate name
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// X coordinate unit
        /// </summary>

        [JsonPropertyName("unit")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Unit { get; set; } = default!;

        /// <summary>
        /// X coordinate data points
        /// </summary>

        [JsonPropertyName("data")]
        [System.ComponentModel.DataAnnotations.Required]
        public object Data { get; set; } = new object();

        /// <summary>
        /// Metric of the requested chart
        /// </summary>

        [JsonPropertyName("metric")]
        public string Metric { get; set; } = default!;
    }
}