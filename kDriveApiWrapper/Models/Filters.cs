namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The filters.
    /// </summary>
    public partial class Filters : Data
    {
        /// <summary>
        /// Activities actions available in the report
        /// </summary>

        [JsonPropertyName("actions")]
        public ICollection<string> Actions { get; set; } = default!;

        /// <summary>
        /// Starting date of the report
        /// </summary>

        [JsonPropertyName("start_at")]
        public int? Start_at { get; set; } = default!;

        /// <summary>
        /// Ending date of the report
        /// </summary>

        [JsonPropertyName("end_at")]
        public int? End_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; } = default!;
    }
}