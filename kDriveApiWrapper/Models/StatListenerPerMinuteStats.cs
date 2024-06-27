namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The stat listener per minute stats.
    /// </summary>
    public partial class StatListenerPerMinuteStats : Data
    {
        /// <summary>
        /// The date of the listeners stat
        /// </summary>

        [JsonPropertyName("date")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Date { get; set; } = default!;

        /// <summary>
        /// The number of listeners
        /// </summary>

        [JsonPropertyName("listeners")]
        public int Listeners { get; set; } = default!;
    }
}