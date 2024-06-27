namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The active members.
    /// </summary>
    public partial class ActiveMembers : Data
    {
        /// <summary>
        /// User identifier
        /// </summary>

        [JsonPropertyName("user_id")]
        public int? User_id { get; set; } = default!;

        /// <summary>
        /// Connected user name
        /// </summary>

        [JsonPropertyName("name")]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// User agent used on connection
        /// </summary>

        [JsonPropertyName("agent")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Agent { get; set; } = default!;

        /// <summary>
        /// Ip used on connection
        /// </summary>

        [JsonPropertyName("ip")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Ip { get; set; } = default!;

        /// <summary>
        /// Last login at
        /// </summary>

        [JsonPropertyName("last_login_at")]
        public int Last_login_at { get; set; } = default!;
    }
}