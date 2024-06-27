namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The mailbox base.
    /// </summary>
    public partial class MailboxBase : Data
    {
        /// <summary>
        /// The username (that is the part before the @) of the email address
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("mailbox_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Mailbox_name { get; set; } = default!;

        /// <summary>
        /// Full email address
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("mailbox")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Mailbox { get; set; } = default!;

        /// <summary>
        /// Full email address with internationalized domain name (IDN) format
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("mailbox_idn")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Mailbox_idn { get; set; } = default!;
    }
}