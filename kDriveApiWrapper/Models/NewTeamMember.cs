namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The new team member.
    /// </summary>
    public partial class NewTeamMember : Data
    {
        /// <summary>
        /// The user's ID.
        /// </summary>

        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; } = default!;

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
        /// The user's position field value.
        /// </summary>

        [JsonPropertyName("position")]
        public string Position { get; set; } = default!;

        /// <summary>
        /// The creation timestamp of the team member class.
        /// </summary>

        [JsonPropertyName("create_at")]
        public int Create_at { get; set; } = default!;
    }
}