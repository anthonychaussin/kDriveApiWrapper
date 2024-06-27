namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The userauthdevice.
    /// </summary>
    public partial class Userauthdevice : Data
    {
        /// <summary>
        /// Unique identifier of the resource `User auth device`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `User auth device`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the last_connexion.
        /// </summary>
        [JsonPropertyName("last_connexion")]
        public int Last_connexion { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_agent.
        /// </summary>
        [JsonPropertyName("user_agent")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string User_agent { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_ip.
        /// </summary>
        [JsonPropertyName("user_ip")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string User_ip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the device.
        /// </summary>
        [JsonPropertyName("device")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Device { get; set; } = default!;

        /// <summary>
        /// Timestamp `User auth device` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `User auth device` has been updated
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `User auth device` has been deleted
        /// </summary>

        [JsonPropertyName("deleted_at")]
        public int Deleted_at { get; set; } = default!;
    }
}