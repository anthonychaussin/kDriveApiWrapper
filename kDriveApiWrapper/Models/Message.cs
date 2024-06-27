namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The message.
    /// </summary>
    public partial class Message : Data
    {
        /// <summary>
        /// The role of the author of this message.
        /// </summary>

        [JsonPropertyName("role")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MessageRole Role { get; set; } = default!;

        /// <summary>
        /// The contents of the message.
        /// </summary>

        [JsonPropertyName("content")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Content { get; set; } = default!;
    }
}