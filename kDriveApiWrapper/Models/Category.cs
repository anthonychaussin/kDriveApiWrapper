namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The category.
    /// </summary>
    public partial class Category : Data
    {
        /// <summary>
        /// Category identifier
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Category name
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Color the Category displays in
        /// </summary>

        [JsonPropertyName("color")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Color { get; set; } = default!;

        /// <summary>
        /// If the Category is system or user defined
        /// </summary>

        [JsonPropertyName("is_predefined")]
        public bool Is_predefined { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the creator of the resource `Category`
        /// </summary>

        [JsonPropertyName("created_by")]
        public int Created_by { get; set; } = default!;

        /// <summary>
        /// Timestamp `Category` was created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Number of uses of the Category
        /// </summary>

        [JsonPropertyName("user_uses")]
        public int User_uses { get; set; } = default!;
    }
}