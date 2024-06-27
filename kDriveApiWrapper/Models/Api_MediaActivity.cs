namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// MediaActivity
    /// </summary>

    public partial class Api_MediaActivity
    {
        /// <summary>
        /// Gets or sets the cause.
        /// </summary>
        [JsonPropertyName("cause")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Api_MediaActivityCause Cause { get; set; } = default!;

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; } = default!;

        /// <summary>
        /// Gets or sets the actor.
        /// </summary>
        [JsonPropertyName("actor")]
        public Api_MediaActivity Actor { get; set; } = default!;

        /// <summary>
        /// Gets or sets the media.
        /// </summary>
        [JsonPropertyName("media")]
        public ICollection<Api_Media> Media { get; set; } = default!;
    }
}