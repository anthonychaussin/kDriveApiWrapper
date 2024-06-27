namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body25.
    /// </summary>
    public partial class Body25 : Data
    {
        /// <summary>
        /// Message provided by the requestor of new access
        /// </summary>

        [JsonPropertyName("message")]
        public string? Message { get; set; } = default!;
    }
}