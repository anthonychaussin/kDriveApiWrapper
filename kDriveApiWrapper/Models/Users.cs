namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The users.
    /// </summary>
    public partial class Users : Data
    {
        /// <summary>
        /// Users identifiers of the account group
        /// </summary>

        [JsonPropertyName("account")]
        public ICollection<int> Account { get; set; } = default!;

        /// <summary>
        /// Users identifiers of the kDrive
        /// </summary>

        [JsonPropertyName("drive")]
        public ICollection<int> Drive { get; set; } = default!;

        /// <summary>
        /// Users identifiers of the drive (only externals users)
        /// </summary>

        [JsonPropertyName("external")]
        public ICollection<int> External { get; set; } = default!;

        /// <summary>
        /// Users identifiers of the drive (only internal users)
        /// </summary>

        [JsonPropertyName("internal")]
        public ICollection<int> Internal { get; set; } = default!;
    }
}