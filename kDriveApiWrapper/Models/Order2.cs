namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The order2.
    /// </summary>
    public partial class Order2 : Data
    {
        /// <summary>
        /// Gets or sets the waiting_payment.
        /// </summary>
        [JsonPropertyName("waiting_payment")]
        public int Waiting_payment { get; set; } = default!;

        /// <summary>
        /// Gets or sets the in_process.
        /// </summary>
        [JsonPropertyName("in_process")]
        public int In_process { get; set; } = default!;

        /// <summary>
        /// Gets or sets the blocked_order_id.
        /// </summary>
        [JsonPropertyName("blocked_order_id")]
        public ICollection<object> Blocked_order_id { get; set; } = default!;
    }
}