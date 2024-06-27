namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The extern invitation file access.
    /// </summary>
    public partial class ExternInvitationFileAccess : Data
    {
        /// <summary>
        /// Extern Invitation File Access Identifier, can be team identifier, user identifier, invitation identifier
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Access type
        /// </summary>

        [JsonPropertyName("access")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ExternInvitationFileAccessAccess Access { get; set; } = default!;

        /// <summary>
        /// Extern Invitation File Access name
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Access right
        /// </summary>

        [JsonPropertyName("right")]
        public string? Right { get; set; } = default!;

        /// <summary>
        /// Access color
        /// </summary>

        [JsonPropertyName("color")]
        public int? Color { get; set; } = default!;

        /// <summary>
        /// Status of access
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ExternInvitationFileAccessStatus Status { get; set; } = default!;
    }
}