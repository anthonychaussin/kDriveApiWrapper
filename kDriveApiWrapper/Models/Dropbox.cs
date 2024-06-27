namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The dropbox.
    /// </summary>
    public partial class Dropbox : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Dropbox`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Dropbox unique identifier
        /// </summary>

        [JsonPropertyName("uuid")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// Name of the dropbox
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Public URL of the dropbox
        /// </summary>

        [JsonPropertyName("url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Number of classed users that uploaded in the dropbox
        /// </summary>

        [JsonPropertyName("users_count")]
        public int Users_count { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the creator of the resource `Dropbox`
        /// </summary>

        [JsonPropertyName("created_by")]
        public int Created_by { get; set; } = default!;

        /// <summary>
        /// Timestamp `Dropbox` was created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int? Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Dropbox` was updated at
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int? Updated_at { get; set; } = default!;

        /// <summary>
        /// Last time someone uploaded a file in the dropbox
        /// </summary>

        [JsonPropertyName("last_uploaded_at")]
        public int? Last_uploaded_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the capabilities.
        /// </summary>
        [JsonPropertyName("capabilities")]
        [System.ComponentModel.DataAnnotations.Required]
        public Capabilities6 Capabilities { get; set; } = new Capabilities6();

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; } = default!;
    }
}