namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The mailbox signature element.
    /// </summary>
    public partial class MailboxSignatureElement : Data
    {
        /// <summary>
        /// Signature/personality identifier
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Signature name
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// HTML content of the signature
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("content")]
        public string Content { get; set; } = default!;

        /// <summary>
        /// Reply to email
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("reply_to")]
        public string Reply_to { get; set; } = default!;

        /// <summary>
        /// Reply to email IDN
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("reply_to_idn")]
        public string Reply_to_idn { get; set; } = default!;

        /// <summary>
        /// Reply to VerifiedEmail identifier
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("reply_to_id")]
        public int Reply_to_id { get; set; } = default!;

        /// <summary>
        /// From full name
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("full_name")]
        public string Full_name { get; set; } = default!;

        /// <summary>
        /// From email
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("sender")]
        public string Sender { get; set; } = default!;

        /// <summary>
        /// From email IDN
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("sender_idn")]
        public string Sender_idn { get; set; } = default!;

        /// <summary>
        /// From VerifiedEmail identifier
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("sender_id")]
        public int Sender_id { get; set; } = default!;

        /// <summary>
        /// Hash (deprecated)
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("hash")]
        public string? Hash { get; set; } = default!;

        /// <summary>
        /// True if default signature/personality
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_default")]
        public bool Is_default { get; set; } = default!;
    }
}