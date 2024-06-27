namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a Pass
    /// </summary>

    public partial class Pass : Data
    {
        /// <summary>
        /// Unique id of a pass
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        [JsonPropertyName("price")]
        public Pricecategory Price { get; set; } = default!;

        /// <summary>
        /// Barcode of a pass
        /// </summary>

        [JsonPropertyName("barcode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Barcode { get; set; } = default!;

        /// <summary>
        /// Firstname filled in pass informations
        /// </summary>

        [JsonPropertyName("firstname")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Firstname { get; set; } = default!;

        /// <summary>
        /// Lastname filled in pass informations
        /// </summary>

        [JsonPropertyName("lastname")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Lastname { get; set; } = default!;

        /// <summary>
        /// Email filled in pass informations
        /// </summary>

        [JsonPropertyName("email")]
        public string? Email { get; set; } = default!;

        /// <summary>
        /// Gets or sets the reservation.
        /// </summary>
        [JsonPropertyName("reservation")]
        public Reservation Reservation { get; set; } = default!;

        /// <summary>
        /// Gets or sets the renewed_from.
        /// </summary>
        [JsonPropertyName("renewed_from")]
        public Pass Renewed_from { get; set; } = default!;

        /// <summary>
        /// Gets or sets the renewed_to.
        /// </summary>
        [JsonPropertyName("renewed_to")]
        public Pass Renewed_to { get; set; } = default!;

        /// <summary>
        /// Gets or sets the period.
        /// </summary>
        [JsonPropertyName("period")]
        public Period Period { get; set; } = default!;

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        [JsonPropertyName("category")]
        public PassCategory Category { get; set; } = default!;

        /// <summary>
        /// Gets or sets the picture_url.
        /// </summary>
        [JsonPropertyName("picture_url")]
        public string Picture_url { get; set; } = default!;

        /// <summary>
        /// Gets or sets the zones.
        /// </summary>
        [JsonPropertyName("zones")]
        public ICollection<TariffZone> Zones { get; set; } = default!;
    }
}