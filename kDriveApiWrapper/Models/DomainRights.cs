namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Rights
    /// </summary>

    public partial class DomainRights : Data
    {
        /// <summary>
        /// Technical
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("technical")]
        public bool Technical { get; set; } = default!;

        /// <summary>
        /// Technical
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("statistic")]
        public bool Statistic { get; set; } = default!;

        /// <summary>
        /// Technical
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("check")]
        public bool Check { get; set; } = default!;

        /// <summary>
        /// Technical
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("sale")]
        public bool Sale { get; set; } = default!;
    }
}