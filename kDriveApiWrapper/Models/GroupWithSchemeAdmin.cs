namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// group augmented with scheme admin information
    /// </summary>

    public partial class GroupWithSchemeAdmin : Data
    {
        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        [JsonPropertyName("group")]
        public Group Group { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether scheme_admin.
        /// </summary>
        [JsonPropertyName("scheme_admin")]
        public bool Scheme_admin { get; set; } = default!;
    }
}