namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The u u i d feedbackresource.
    /// </summary>
    public partial class UUIDFeedbackresource : Data
    {
        /// <summary>
        /// Identifier
        /// </summary>

        [JsonPropertyName("id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; } = default!;

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