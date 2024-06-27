namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The usersession.
    /// </summary>
    public partial class Usersession : Data
    {
        /// <summary>
        /// Gets or sets the browser.
        /// </summary>
        [JsonPropertyName("browser")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Browser { get; set; } = default!;

        /// <summary>
        /// Gets or sets the last_accessed_at.
        /// </summary>
        [JsonPropertyName("last_accessed_at")]
        public int Last_accessed_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the device.
        /// </summary>
        [JsonPropertyName("device")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Device { get; set; } = default!;

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        [JsonPropertyName("location")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Location { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ip.
        /// </summary>
        [JsonPropertyName("ip")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Ip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the user_agent.
        /// </summary>
        [JsonPropertyName("user_agent")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string User_agent { get; set; } = default!;
    }
}