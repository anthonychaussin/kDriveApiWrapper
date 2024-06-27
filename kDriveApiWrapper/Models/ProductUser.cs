namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The product user.
    /// </summary>
    public partial class ProductUser : Data
    {
        /// <summary>
        /// Gets or sets the user_id.
        /// </summary>
        [JsonPropertyName("user_id")]
        public int User_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the rights.
        /// </summary>
        [JsonPropertyName("rights")]
        [System.ComponentModel.DataAnnotations.Required]
        public Right Rights { get; set; } = new Right();
    }
}