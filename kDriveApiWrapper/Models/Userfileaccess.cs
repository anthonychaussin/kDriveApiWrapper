namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The userfileaccess.
    /// </summary>
    public partial class Userfileaccess : Data
    {
        /// <summary>
        /// User file access Identifier, can be team identifier, user identifier, invitation identifier
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Access type
        /// </summary>

        [JsonPropertyName("access")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UserfileaccessAccess Access { get; set; } = default!;

        /// <summary>
        /// User file access name
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
        public UserfileaccessStatus Status { get; set; } = default!;
    }
}