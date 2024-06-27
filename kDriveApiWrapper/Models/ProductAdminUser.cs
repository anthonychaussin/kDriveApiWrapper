namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The product admin user.
    /// </summary>
    public partial class ProductAdminUser : Data
    {
        /// <summary>
        /// Gets or sets the user_id.
        /// </summary>
        [JsonPropertyName("user_id")]
        public int User_id { get; set; } = default!;

        /// <summary>
        /// Email
        /// </summary>

        [JsonPropertyName("email")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Email { get; set; } = default!;

        /// <summary>
        /// Display name
        /// </summary>

        [JsonPropertyName("display_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Display_name { get; set; } = default!;
    }
}