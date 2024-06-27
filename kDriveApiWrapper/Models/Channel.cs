namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The channel.
    /// </summary>
    public partial class Channel : Data
    {
        /// <summary>
        /// Unique identifier of the `channel` that is related to the resource `Channel`
        /// </summary>

        [JsonPropertyName("channel_id")]
        public int Channel_id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Channel`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Timestamp `Channel` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Channel` has been updated
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Channel` has been deleted
        /// </summary>

        [JsonPropertyName("deleted_at")]
        public int Deleted_at { get; set; } = default!;

        /// <summary>
        /// Boolean `Channel` has been deleted
        /// </summary>

        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ChannelType Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the source_type.
        /// </summary>
        [JsonPropertyName("source_type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ChannelSource_type Source_type { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether remember_to_config.
        /// </summary>
        [JsonPropertyName("remember_to_config")]
        public bool Remember_to_config { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether free.
        /// </summary>
        [JsonPropertyName("free")]
        public bool Free { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether blocked.
        /// </summary>
        [JsonPropertyName("blocked")]
        public bool Blocked { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether maintained.
        /// </summary>
        [JsonPropertyName("maintained")]
        public bool Maintained { get; set; } = default!;

        /// <summary>
        /// Gets or sets the blocked_at.
        /// </summary>
        [JsonPropertyName("blocked_at")]
        public int Blocked_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the maintained_at.
        /// </summary>
        [JsonPropertyName("maintained_at")]
        public int Maintained_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether is_pulled.
        /// </summary>
        [JsonPropertyName("is_pulled")]
        public bool Is_pulled { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public string Tags { get; set; } = default!;

        /// <summary>
        /// Gets or sets the rights.
        /// </summary>
        [JsonPropertyName("rights")]
        public string Rights { get; set; } = default!;

        /// <summary>
        /// Gets or sets the live.
        /// </summary>
        [JsonPropertyName("live")]
        public Liveressource Live { get; set; } = default!;

        /// <summary>
        /// Gets or sets the real_type.
        /// </summary>
        [JsonPropertyName("real_type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Real_type { get; set; } = default!;

        /// <summary>
        /// Status of the resource `Channel`
        /// </summary>

        [JsonPropertyName("status")]
        public ICollection<object> Status { get; set; } = default!;

        /// <summary>
        /// Gets or sets the consumption.
        /// </summary>
        [JsonPropertyName("consumption")]
        public Fieldresource Consumption { get; set; } = default!;

        /// <summary>
        /// Gets or sets the classing_status.
        /// </summary>
        [JsonPropertyName("classing_status")]
        public string classing_status { get; set; } = default!;

        /// <summary>
        /// Gets or sets the options_orders.
        /// </summary>
        [JsonPropertyName("options_orders")]
        public string Options_orders { get; set; } = default!;

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        [JsonPropertyName("options")]
        public ICollection<object> Options { get; set; } = default!;

        /// <summary>
        /// Gets or sets the default_options.
        /// </summary>
        [JsonPropertyName("default_options")]
        public ICollection<object> Default_options { get; set; } = default!;

        /// <summary>
        /// Gets or sets the streams.
        /// </summary>
        [JsonPropertyName("streams")]
        public ICollection<Stream> Streams { get; set; } = default!;

        /// <summary>
        /// Gets or sets the restriction.
        /// </summary>
        [JsonPropertyName("restriction")]
        public ViewersRestrictions Restriction { get; set; } = default!;

        /// <summary>
        /// Gets or sets the machines.
        /// </summary>
        [JsonPropertyName("machines")]
        public ICollection<Machine> Machines { get; set; } = default!;

        /// <summary>
        /// Gets or sets the players.
        /// </summary>
        [JsonPropertyName("players")]
        public ICollection<Player> Players { get; set; } = default!;

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        [JsonPropertyName("order")]
        public string Order { get; set; } = default!;

        /// <summary>
        /// Gets or sets the account.
        /// </summary>
        [JsonPropertyName("account")]
        public string Account { get; set; } = default!;

        /// <summary>
        /// Gets or sets the pool.
        /// </summary>
        [JsonPropertyName("pool")]
        public string Pool { get; set; } = default!;
    }
}