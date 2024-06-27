namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The partner invitation data.
    /// </summary>
    public partial class PartnerInvitationData : Data
    {
        /// <summary>
        /// Gets or sets the partner_id.
        /// </summary>
        [JsonPropertyName("partner_id")]
        public int Partner_id { get; set; } = default!;

        /// <summary>
        /// Describes the type of access the partner has on its client
        /// </summary>

        [JsonPropertyName("full_access")]
        public bool Full_access { get; set; } = default!;

        /// <summary>
        /// Gets or sets the products.
        /// </summary>
        [JsonPropertyName("products")]
        public ICollection<object> Products { get; set; } = default!;
    }
}