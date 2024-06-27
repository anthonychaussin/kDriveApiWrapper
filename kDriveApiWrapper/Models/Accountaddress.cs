namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The accountaddress.
    /// </summary>
    public partial class Accountaddress : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Account address`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        [JsonPropertyName("street")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Street { get; set; } = default!;

        /// <summary>
        /// Gets or sets the street2.
        /// </summary>
        [JsonPropertyName("street2")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Street2 { get; set; } = default!;

        /// <summary>
        /// Gets or sets the zip.
        /// </summary>
        [JsonPropertyName("zip")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Zip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        [JsonPropertyName("city")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string City { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Timestamp `Account address` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [JsonPropertyName("country")]
        [System.ComponentModel.DataAnnotations.Required]
        public Geolocationressource Country { get; set; } = new Geolocationressource();

        /// <summary>
        /// Gets or sets a value indicating whether for_invoice.
        /// </summary>
        [JsonPropertyName("for_invoice")]
        public bool For_invoice { get; set; } = default!;
    }
}