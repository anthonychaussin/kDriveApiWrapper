namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The sanitized file access request.
    /// </summary>
    public partial class SanitizedFileAccessRequest : Data
    {
        /// <summary>
        /// ID of the request
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Status of the request
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Message to provide to the validator
        /// </summary>

        [JsonPropertyName("message")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// ID of the user requesting access to the file
        /// </summary>

        [JsonPropertyName("user_id")]
        public int User_id { get; set; } = default!;

        /// <summary>
        /// ID of the user whom validate the request
        /// </summary>

        [JsonPropertyName("validated_by")]
        public int Validated_by { get; set; } = default!;

        /// <summary>
        /// ID of the file the user request access to
        /// </summary>

        [JsonPropertyName("file_id")]
        public int File_id { get; set; } = default!;

        /// <summary>
        /// Date of the request's validation
        /// </summary>

        [JsonPropertyName("validated_at")]
        public int Validated_at { get; set; } = default!;

        /// <summary>
        /// Date of the request's creation
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Date of the request's expiration
        /// </summary>

        [JsonPropertyName("expired_at")]
        public int Expired_at { get; set; } = default!;
    }
}