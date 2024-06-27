namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents an address
    /// </summary>

    public partial class Address : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Address`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the designation.
        /// </summary>
        [JsonPropertyName("designation")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Designation { get; set; } = default!;

        /// <summary>
        /// Gets or sets the address1.
        /// </summary>
        [JsonPropertyName("address")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Address1 { get; set; } = default!;

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        [JsonPropertyName("number")]
        public int Number { get; set; } = default!;

        /// <summary>
        /// Gets or sets the s zip code.
        /// </summary>
        [JsonPropertyName("sZipCode")]
        public int SZipCode { get; set; } = default!;
    }
}