namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The team member.
    /// </summary>
    public partial class TeamMember : Data
    {
        /// <summary>
        /// The ID of the team this member belongs to.
        /// </summary>

        [JsonPropertyName("team_id")]
        public string Team_id { get; set; } = default!;

        /// <summary>
        /// The ID of the user this member relates to.
        /// </summary>

        [JsonPropertyName("user_id")]
        public string User_id { get; set; } = default!;

        /// <summary>
        /// The complete list of roles assigned to this team member, as a space-separated list of role names, including any roles granted implicitly through permissions schemes.
        /// </summary>

        [JsonPropertyName("roles")]
        public string Roles { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds that this team member was deleted.
        /// </summary>

        [JsonPropertyName("delete_at")]
        public int Delete_at { get; set; } = default!;

        /// <summary>
        /// Whether this team member holds the default user role defined by the team's permissions scheme.
        /// </summary>

        [JsonPropertyName("scheme_user")]
        public bool Scheme_user { get; set; } = default!;

        /// <summary>
        /// Whether this team member holds the default admin role defined by the team's permissions scheme.
        /// </summary>

        [JsonPropertyName("scheme_admin")]
        public bool Scheme_admin { get; set; } = default!;

        /// <summary>
        /// The list of roles explicitly assigned to this team member, as a space separated list of role names. This list does *not* include any roles granted implicitly through permissions schemes.
        /// </summary>

        [JsonPropertyName("explicit_roles")]
        public string Explicit_roles { get; set; } = default!;
    }
}