namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The recurrent_days.
    /// </summary>
    public partial class Recurrent_days
    {
        /// <summary>
        /// Activated on mondays
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("monday")]
        public bool Monday { get; set; } = default!;

        /// <summary>
        /// Activated on tuesdays
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("tuesday")]
        public bool Tuesday { get; set; } = default!;

        /// <summary>
        /// Activated on wednesdays
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("wednesday")]
        public bool Wednesday { get; set; } = default!;

        /// <summary>
        /// Activated on thursday
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("thursday")]
        public bool Thursday { get; set; } = default!;

        /// <summary>
        /// Activated on friday
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("friday")]
        public bool Friday { get; set; } = default!;

        /// <summary>
        /// Activated on saturdays
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("saturday")]
        public bool Saturday { get; set; } = default!;

        /// <summary>
        /// Activated on sundays
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("sunday")]
        public bool Sunday { get; set; } = default!;
    }
}