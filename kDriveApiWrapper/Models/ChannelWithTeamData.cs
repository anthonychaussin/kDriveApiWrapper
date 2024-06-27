namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The channel with team data.
    /// </summary>
    public partial class ChannelWithTeamData : Channel
    {
        /// <summary>
        /// The display name of the team to which this channel belongs.
        /// </summary>

        [JsonPropertyName("team_display_name")]
        public string Team_display_name { get; set; } = default!;

        /// <summary>
        /// The name of the team to which this channel belongs.
        /// </summary>

        [JsonPropertyName("team_name")]
        public string Team_name { get; set; } = default!;

        /// <summary>
        /// The time at which the team to which this channel belongs was last updated.
        /// </summary>

        [JsonPropertyName("team_update_at")]
        public int Team_update_at { get; set; } = default!;

        /// <summary>
        /// The data retention policy to which this team has been assigned. If no such policy exists, or the caller does not have the `sysconsole_read_compliance_data_retention` permission, this field will be null.
        /// </summary>

        [JsonPropertyName("policy_id")]
        public string Policy_id { get; set; } = default!;
    }
}