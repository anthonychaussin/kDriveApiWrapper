namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body51.
    /// </summary>
    public partial class Body51 : Data
    {
        /// <summary>
        /// Color of the directory for the user creating it
        /// </summary>

        [JsonPropertyName("color")]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"/#[0-9a-fA-F]{3}([0-9a-fA-F]{3})?/")]
        public string Color { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether for_all_user.
        /// </summary>
        [JsonPropertyName("for_all_user")]
        public bool For_all_user { get; set; } = default!;

        /// <summary>
        /// Name of the resource `{name}`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;
    }
}