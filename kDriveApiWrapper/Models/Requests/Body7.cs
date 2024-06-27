namespace kDriveApiWrapper.Models.Requests
{
    /// <summary>
    /// The body7.
    /// </summary>
    public partial class Body7 : Data
    {
        /// <summary>
        /// Gets or sets a value indicating whether activate.
        /// </summary>
        [JsonPropertyName("activate")]
        public bool Activate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the bg color.
        /// </summary>
        [JsonPropertyName("bgColor")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"/#[0-9a-fA-F]{3")]
        public string BgColor { get; set; } = default!;

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        [JsonPropertyName("images")]
        public ICollection<int> Images { get; set; } = default!;

        /// <summary>
        /// Gets or sets the txt color.
        /// </summary>
        [JsonPropertyName("txtColor")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"/#[0-9a-fA-F]{3")]
        public string TxtColor { get; set; } = default!;
    }
}