namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The maintenance.
    /// </summary>
    public partial class Maintenance : Data
    {
        /// <summary>
        /// Gets or sets a value indicating whether technical.
        /// </summary>
        [JsonPropertyName("technical")]
        public bool Technical { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether superuser.
        /// </summary>
        [JsonPropertyName("superuser")]
        public bool Superuser { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether infomaniak.
        /// </summary>
        [JsonPropertyName("infomaniak")]
        public bool Infomaniak { get; set; } = default!;
    }
}