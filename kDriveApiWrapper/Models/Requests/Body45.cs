namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body45.
    /// </summary>
    public partial class Body45 : Data
    {
        /// <summary>
        /// Color of the directory for the user creating it
        /// </summary>

        [JsonPropertyName("color")]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"/#[0-9a-fA-F]{3}([0-9a-fA-F]{3})?/")]
        public string Color { get; set; } = default!;

        /// <summary>
        /// Name of the directory to create
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether only_for_me.
        /// </summary>
        [JsonPropertyName("only_for_me")]
        public bool Only_for_me { get; set; } = default!;

        /// <summary>
        /// relative path of the folder to create, from the destination directory
        /// </summary>

        [JsonPropertyName("relative_path")]
        public string Relative_path { get; set; } = default!;
    }
}