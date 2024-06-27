namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The role right.
    /// </summary>
    public partial class RoleRight : Data
    {
        /// <summary>
        /// Gets or sets the role_id.
        /// </summary>
        [JsonPropertyName("role_id")]
        public int Role_id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `service` that is related to the resource `RoleRight`
        /// </summary>

        [JsonPropertyName("service_id")]
        public int Service_id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `product` that is related to the resource `RoleRight`
        /// </summary>

        [JsonPropertyName("product_id")]
        public int Product_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the product_unique_id.
        /// </summary>
        [JsonPropertyName("product_unique_id")]
        public int Product_unique_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the product_name.
        /// </summary>
        [JsonPropertyName("product_name")]
        public string Product_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the rights.
        /// </summary>
        [JsonPropertyName("rights")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Rights { get; set; } = default!;

        /// <summary>
        /// Timestamp `RoleRight` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;
    }
}