namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The feedbackresource.
    /// </summary>
    public partial class Feedbackresource : Data
    {
        /// <summary>
        /// Identifier
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Result of the asking query
        /// </summary>

        [JsonPropertyName("result")]
        public bool Result { get; set; } = default!;

        /// <summary>
        /// Message, additional information usually given when the result is false
        /// </summary>

        [JsonPropertyName("message")]
        public string Message { get; set; } = default!;
    }
}