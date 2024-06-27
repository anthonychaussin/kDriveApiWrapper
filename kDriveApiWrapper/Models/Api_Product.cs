namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Product
    /// </summary>

    public partial class Api_Product
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public double Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the auto_empty_trash.
        /// </summary>
        [JsonPropertyName("auto_empty_trash")]
        public string Auto_empty_trash { get; set; } = default!;

        /// <summary>
        /// Gets or sets the channel_name.
        /// </summary>
        [JsonPropertyName("channel_name")]
        public string Channel_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the channel_description.
        /// </summary>
        [JsonPropertyName("channel_description")]
        public string Channel_description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the player.
        /// </summary>
        [JsonPropertyName("player")]
        public Api_Player Player { get; set; } = default!;

        /// <summary>
        /// Gets or sets the statistic_ignored_ip.
        /// </summary>
        [JsonPropertyName("statistic_ignored_ip")]
        public ICollection<string> Statistic_ignored_ip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ftp_prefix.
        /// </summary>
        [JsonPropertyName("ftp_prefix")]
        public string Ftp_prefix { get; set; } = default!;

        /// <summary>
        /// Gets or sets the pack.
        /// </summary>
        [JsonPropertyName("pack")]
        public string Pack { get; set; } = default!;

        /// <summary>
        /// Gets or sets the medias_count.
        /// </summary>
        [JsonPropertyName("medias_count")]
        public int Medias_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the medias_uploaded.
        /// </summary>
        [JsonPropertyName("medias_uploaded")]
        public double Medias_uploaded { get; set; } = default!;

        /// <summary>
        /// Gets or sets the medias_uploaded_last_hour.
        /// </summary>
        [JsonPropertyName("medias_uploaded_last_hour")]
        public double Medias_uploaded_last_hour { get; set; } = default!;

        /// <summary>
        /// Gets or sets the parameters.
        /// </summary>
        [JsonPropertyName("parameters")]
        public ICollection<string> Parameters { get; set; } = default!;

        /// <summary>
        /// Gets or sets the rights.
        /// </summary>
        [JsonPropertyName("rights")]
        public ICollection<string> Rights { get; set; } = default!;

        /// <summary>
        /// Gets or sets the bill_reference.
        /// </summary>
        [JsonPropertyName("bill_reference")]
        public string Bill_reference { get; set; } = default!;

        /// <summary>
        /// Gets or sets the available_quota.
        /// </summary>
        [JsonPropertyName("available_quota")]
        public string Available_quota { get; set; } = default!;

        /// <summary>
        /// Gets or sets the legacy_product_id.
        /// </summary>
        [JsonPropertyName("legacy_product_id")]
        public double Legacy_product_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the suspended_at.
        /// </summary>
        [JsonPropertyName("suspended_at")]
        public string Suspended_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the customer_name.
        /// </summary>
        [JsonPropertyName("customer_name")]
        public string Customer_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the expired_at.
        /// </summary>
        [JsonPropertyName("expired_at")]
        public string Expired_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the internal_name.
        /// </summary>
        [JsonPropertyName("internal_name")]
        public string Internal_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the service_id.
        /// </summary>
        [JsonPropertyName("service_id")]
        public double Service_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the slug.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether special.
        /// </summary>
        [JsonPropertyName("special")]
        public bool Special { get; set; } = default!;

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        [JsonPropertyName("version")]
        public double Version { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public ICollection<Api_Tag> Tags { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;
    }
}