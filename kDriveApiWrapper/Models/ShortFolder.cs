namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// folder
    /// </summary>

    public partial class ShortFolder : Data
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether validated.
        /// </summary>
        [JsonPropertyName("validated")]
        public bool Validated { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether published.
        /// </summary>
        [JsonPropertyName("published")]
        public bool Published { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether auto_validate.
        /// </summary>
        [JsonPropertyName("auto_validate")]
        public bool Auto_validate { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether auto_publish.
        /// </summary>
        [JsonPropertyName("auto_publish")]
        public bool Auto_publish { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether restricted.
        /// </summary>
        [JsonPropertyName("restricted")]
        public bool Restricted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Gets or sets the allowed_ip.
        /// </summary>
        [JsonPropertyName("allowed_ip")]
        public ICollection<string> Allowed_ip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the disallowed_ip.
        /// </summary>
        [JsonPropertyName("disallowed_ip")]
        public ICollection<string> Disallowed_ip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the allowed_country.
        /// </summary>
        [JsonPropertyName("allowed_country")]
        public ICollection<Api_Country> Allowed_country { get; set; } = default!;

        /// <summary>
        /// Gets or sets the disallowed_country.
        /// </summary>
        [JsonPropertyName("disallowed_country")]
        public ICollection<Api_Country> Disallowed_country { get; set; } = default!;

        /// <summary>
        /// Gets or sets the discarded.
        /// </summary>
        [JsonPropertyName("discarded")]
        public string Discarded { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_at.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the discarded_at.
        /// </summary>
        [JsonPropertyName("discarded_at")]
        public string Discarded_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        [JsonPropertyName("image")]
        public string Image { get; set; } = default!;

        /// <summary>
        /// Gets or sets the media_count.
        /// </summary>
        [JsonPropertyName("media_count")]
        public int Media_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the media_duration.
        /// </summary>
        [JsonPropertyName("media_duration")]
        public double Media_duration { get; set; } = default!;
    }
}