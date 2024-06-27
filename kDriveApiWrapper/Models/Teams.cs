namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The teams.
    /// </summary>
    public partial class Teams : Data
    {
        /// <summary>
        /// Teams identifiers of the account group
        /// </summary>

        [JsonPropertyName("account")]
        public ICollection<int> Account { get; set; } = default!;

        /// <summary>
        /// Teams identifiers of the kDrive
        /// </summary>

        [JsonPropertyName("drive")]
        public ICollection<int> Drive { get; set; } = default!;
    }
}