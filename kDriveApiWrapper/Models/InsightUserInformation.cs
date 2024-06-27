namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The insight user information.
    /// </summary>
    public partial class InsightUserInformation : Data
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the first_name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string First_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the last_name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string Last_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the nickname.
        /// </summary>
        [JsonPropertyName("nickname")]
        public string Nickname { get; set; } = default!;

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; } = default!;

        /// <summary>
        /// Gets or sets the last_picture_update.
        /// </summary>
        [JsonPropertyName("last_picture_update")]
        public string Last_picture_update { get; set; } = default!;

        /// <summary>
        /// Gets or sets the create_at.
        /// </summary>
        [JsonPropertyName("create_at")]
        public long Create_at { get; set; } = default!;
    }
}