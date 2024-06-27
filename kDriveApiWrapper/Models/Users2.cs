namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The users2.
    /// </summary>
    public partial class Users2 : Data
    {
        /// <summary>
        /// Included/Allowed number of user
        /// </summary>

        [JsonPropertyName("base")]
        public int Base { get; set; } = default!;

        /// <summary>
        /// Minimum number of additional user
        /// </summary>

        [JsonPropertyName("min")]
        public int? Min { get; set; } = default!;

        /// <summary>
        /// Maximum number of additional user
        /// </summary>

        [JsonPropertyName("max")]
        public int? Max { get; set; } = default!;
    }
}