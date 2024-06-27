namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body23.
    /// </summary>
    public partial class Body23 : Data
    {
        /// <summary>
        /// Never delete this version from version history
        /// </summary>

        [JsonPropertyName("keep_forever")]
        public bool Keep_forever { get; set; } = default!;
    }
}