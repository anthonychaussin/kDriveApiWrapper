namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body12.
    /// </summary>
    public partial class Body12 : Data
    {
        /// <summary>
        /// Gets or sets the roles.
        /// </summary>
        [JsonPropertyName("roles")]

        // TODO(json): Add string enum item converter
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<Roles> Roles { get; set; } = [];
    }
}