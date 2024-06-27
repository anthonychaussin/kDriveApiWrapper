namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The team.
    /// </summary>
    public partial class Team : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Team`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Team`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `color` of the resource `Team`
        /// </summary>

        [JsonPropertyName("color_id")]
        public int Color_id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `user` that owned the resource `Team`
        /// </summary>

        [JsonPropertyName("owned_by_id")]
        public int Owned_by_id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `user` that created the resource `Team`
        /// </summary>

        [JsonPropertyName("created_by_id")]
        public int Created_by_id { get; set; } = default!;

        /// <summary>
        /// Timestamp `Team` was created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Team` was updated at
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_by.
        /// </summary>
        [JsonPropertyName("created_by")]
        public User Created_by { get; set; } = default!;

        /// <summary>
        /// Gets or sets the owned_by.
        /// </summary>
        [JsonPropertyName("owned_by")]
        public User Owned_by { get; set; } = default!;

        /// <summary>
        /// User count related to the resource `Team`
        /// </summary>

        [JsonPropertyName("user_count")]
        public int User_count { get; set; } = default!;

        /// <summary>
        /// Product count related to the resource `Team`
        /// </summary>

        [JsonPropertyName("product_count")]
        public int Product_count { get; set; } = default!;

        /// <summary>
        /// Product by service count related to the resource `Team`
        /// </summary>

        [JsonPropertyName("product_by_service_count")]
        public int Product_by_service_count { get; set; } = default!;
    }
}