namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body9.
    /// </summary>
    public partial class Body9 : Data
    {
        /// <summary>
        /// Gets or sets the bill_reference.
        /// </summary>
        [JsonPropertyName("bill_reference")]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 2)]
        public string? Bill_reference { get; set; } = default!;

        /// <summary>
        /// Gets or sets the customer_name.
        /// </summary>
        [JsonPropertyName("customer_name")]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 2)]
        public string Customer_name { get; set; } = default!;

        /// <summary>
        /// Description of the resource `{name}`
        /// </summary>

        [JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 2)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_name.
        /// </summary>
        [JsonPropertyName("updated_name")]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 2)]
        public string Updated_name { get; set; } = default!;
    }
}