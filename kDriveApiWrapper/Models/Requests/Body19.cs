namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body19.
    /// </summary>
    public partial class Body19 : Data
    {
        /// <summary>
        /// The cancel identifier
        /// </summary>

        [JsonPropertyName("cancel_id")]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"/^[0-9a-f\-]{36}$/i")]
        public string Cancel_id { get; set; } = default!;

        /// <summary>
        /// The cancel identifiers
        /// </summary>

        [JsonPropertyName("cancel_ids")]
        public ICollection<string> Cancel_ids { get; set; } = default!;
    }
}