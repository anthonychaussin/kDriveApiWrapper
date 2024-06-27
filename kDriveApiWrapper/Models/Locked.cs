namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The locked.
    /// </summary>
    public partial class Locked : Data
    {
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