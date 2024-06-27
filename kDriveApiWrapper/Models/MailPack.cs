namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Pack
    /// </summary>

    public partial class MailPack : Data
    {
        /// <summary>
        /// Ressource identifier
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Description
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Is starter
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("is_starter")]
        public bool Is_starter { get; set; } = default!;

        /// <summary>
        /// Has list tool
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("has_list_tool")]
        public bool Has_list_tool { get; set; } = default!;

        /// <summary>
        /// Has newsletter tool
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("has_newsletter_tool")]
        public bool Has_newsletter_tool { get; set; } = default!;

        /// <summary>
        /// Additional paid email
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("additional_paid_email")]
        public int Additional_paid_email { get; set; } = default!;

        /// <summary>
        /// Free additional email
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("free_additional_email")]
        public int Free_additional_email { get; set; } = default!;
    }
}