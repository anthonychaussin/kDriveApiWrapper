namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The feedbackaccessresource.
    /// </summary>
    public partial class Feedbackaccessresource : Data
    {
        /// <summary>
        /// The email,team or user identifier filled in the parameters
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = new int();

        /// <summary>
        /// The invitation send
        /// </summary>

        [JsonPropertyName("result")]
        public bool Result { get; set; } = default!;

        /// <summary>
        /// The invitation send, null if access was not found
        /// </summary>

        [JsonPropertyName("access")]
        public ExternInvitationFileAccess? Access { get; set; } = default!;

        /// <summary>
        /// Additional message about why email fail to be sent
        /// </summary>

        [JsonPropertyName("message")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; } = default!;
    }
}