namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents an organizer
    /// </summary>

    public partial class Organizer : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Organizer`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the firstname.
        /// </summary>
        [JsonPropertyName("firstname")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Firstname { get; set; } = default!;

        /// <summary>
        /// Gets or sets the lastname.
        /// </summary>
        [JsonPropertyName("lastname")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Lastname { get; set; } = default!;

        /// <summary>
        /// Email
        /// </summary>

        [JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Timestamp `Organizer` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Control tools code (only for admins)
        /// </summary>

        [JsonPropertyName("control_tools_code")]
        public string? Control_tools_code { get; set; } = default!;

        /// <summary>
        /// Gets or sets the crm_state.
        /// </summary>
        [JsonPropertyName("crm_state")]
        public string? Crm_state { get; set; } = default!;

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        [JsonPropertyName("group")]
        public Account Group { get; set; } = default!;

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        [JsonPropertyName("owner")]
        public User Owner { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tracking_state.
        /// </summary>
        [JsonPropertyName("tracking_state")]
        public string Tracking_state { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tracking_state_delay.
        /// </summary>
        [JsonPropertyName("tracking_state_delay")]
        public int Tracking_state_delay { get; set; } = default!;

        /// <summary>
        /// Gets or sets the webinar.
        /// </summary>
        [JsonPropertyName("webinar")]
        public Webinar Webinar { get; set; } = default!;

        /// <summary>
        /// Gets or sets the webinar_state.
        /// </summary>
        [JsonPropertyName("webinar_state")]
        public string? Webinar_state { get; set; } = default!;

        /// <summary>
        /// Gets or sets the last_period_created_at.
        /// </summary>
        [JsonPropertyName("last_period_created_at")]
        public int Last_period_created_at { get; set; } = default!;

        /// <summary>
        /// Plan describing organization level with premium subscription, supports, etc
        /// </summary>

        [JsonPropertyName("plan")]
        public string? Plan { get; set; } = default!;

        /// <summary>
        /// Gets or sets the features.
        /// </summary>
        [JsonPropertyName("features")]
        public string Features { get; set; } = default!;
    }
}