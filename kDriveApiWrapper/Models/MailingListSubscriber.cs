namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The mailing list subscriber.
    /// </summary>
    public partial class MailingListSubscriber : Data
    {
        /// <summary>
        /// full_name
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("full_name")]
        public string Full_name { get; set; } = default!;

        /// <summary>
        /// Full email address
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("mail")]
        public string Mail { get; set; } = default!;

        /// <summary>
        /// Full email address with IDN format
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("mail_idn")]
        public string Mail_idn { get; set; } = default!;

        /// <summary>
        ///
        /// <br/>
        /// </summary>

        [JsonPropertyName("config")]
        public Config Config { get; set; } = default!;
    }
}