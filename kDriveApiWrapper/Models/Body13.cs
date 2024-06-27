namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body13.
    /// </summary>
    public partial class Body13 : Data
    {
        /// <summary>
        /// Gets or sets the actions.
        /// </summary>
        [JsonPropertyName("actions")]
        public ICollection<Actions> Actions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the depth.
        /// </summary>
        [JsonPropertyName("depth")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body1ThreeDepth Depth { get; set; } = default!;

        /// <summary>
        /// Gets or sets the from.
        /// </summary>
        [JsonPropertyName("from")]
        public int From { get; set; } = default!;

        /// <summary>
        /// Gets or sets the terms.
        /// </summary>
        [JsonPropertyName("terms")]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 3)]
        public string Terms { get; set; } = default!;

        /// <summary>
        /// Gets or sets the until.
        /// </summary>
        [JsonPropertyName("until")]
        public int Until { get; set; } = default!;

        /// <summary>
        /// User identifier
        /// </summary>

        [JsonPropertyName("user_id")]
        public int? User_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        [JsonPropertyName("users")]
        public ICollection<int> Users { get; set; } = default!;
    }
}