namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The user uuid.
    /// </summary>
    public partial class UserUuid : Data
    {
        /// <summary>
        /// Uuid v4
        /// </summary>

        [JsonPropertyName("uuid")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// Validity of the Uuid
        /// </summary>

        [JsonPropertyName("valid_until")]
        public int Valid_until { get; set; } = default!;
    }
}