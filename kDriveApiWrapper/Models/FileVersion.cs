namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The file version.
    /// </summary>
    public partial class FileVersion : Data
    {
        /// <summary>
        /// Unique identifier of the resource `File Version`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Keep the resource `File Version` forever, otherwise will be delete in 120 days
        /// </summary>

        [JsonPropertyName("keep_forever")]
        public bool Keep_forever { get; set; } = default!;

        /// <summary>
        /// Mime type of the resource `File Version`
        /// </summary>

        [JsonPropertyName("mime_type")]
        public string? Mime_type { get; set; } = default!;

        /// <summary>
        /// Converted mime type
        /// </summary>

        [JsonPropertyName("converted_type")]
        public string? Converted_type { get; set; } = default!;

        /// <summary>
        /// Name of the resource `File Version`
        /// </summary>

        [JsonPropertyName("name")]
        public string? Name { get; set; } = default!;

        /// <summary>
        /// Size of the resource `File Version`
        /// </summary>

        [JsonPropertyName("size")]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_by.
        /// </summary>
        [JsonPropertyName("updated_by")]
        [System.ComponentModel.DataAnnotations.Required]
        public User Updated_by { get; set; } = new User();

        /// <summary>
        /// Timestamp `File Version` was created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `File Version` was updated at
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int? Updated_at { get; set; } = default!;

        /// <summary>
        /// The last modified date of the file version, null if unknown
        /// </summary>

        [JsonPropertyName("last_modified_at")]
        public int? Last_modified_at { get; set; } = default!;
    }
}