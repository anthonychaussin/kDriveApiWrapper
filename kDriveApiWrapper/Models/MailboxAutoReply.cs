namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The mailbox auto reply.
    /// </summary>
    public partial class MailboxAutoReply : Data
    {
        /// <summary>
        /// Enabled (scheduled)
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_enabled")]
        public bool Is_enabled { get; set; } = default!;

        /// <summary>
        /// Active (currently activated)
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_active")]
        public bool Is_active { get; set; } = default!;

        /// <summary>
        /// Reply message
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("reply_message")]
        public string Reply_message { get; set; } = default!;

        /// <summary>
        /// Reply from
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("reply_from")]
        public string Reply_from { get; set; } = default!;

        /// <summary>
        /// Id of verified email configured as reply from
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("reply_from_id")]
        public int Reply_from_id { get; set; } = default!;

        /// <summary>
        /// Is recurrent
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_recurrent")]
        public bool Is_recurrent { get; set; } = default!;

        /// <summary>
        /// Gets or sets the recurrent_days.
        /// </summary>
        [JsonPropertyName("recurrent_days")]
        public Recurrent_days Recurrent_days { get; set; } = default!;

        /// <summary>
        /// Start
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("started_at")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset Started_at { get; set; } = default!;

        /// <summary>
        /// End
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("ended_at")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset Ended_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the dont_reply_to.
        /// </summary>
        [JsonPropertyName("dont_reply_to")]
        public ICollection<string> Dont_reply_to { get; set; } = default!;

        /// <summary>
        /// Send original message
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("has_send_original_message")]
        public bool Has_send_original_message { get; set; } = default!;

        /// <summary>
        /// Gets or sets the valid_emails.
        /// </summary>
        [JsonPropertyName("valid_emails")]
        public ICollection<VerifiedEmail> Valid_emails { get; set; } = default!;
    }
}