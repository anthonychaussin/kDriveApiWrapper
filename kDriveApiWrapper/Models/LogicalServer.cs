namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a logical server, could be a main server or a VM.
    /// </summary>

    public partial class LogicalServer : Data
    {
        /// <summary>
        /// Gets or sets the server_id.
        /// </summary>
        [JsonPropertyName("server_id")]
        public int Server_id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `LogicalServer`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the resource `LogicalServer`
        /// </summary>

        [JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public LogicalServerType Type { get; set; } = default!;

        /// <summary>
        /// count of allowed CPU
        /// </summary>

        [JsonPropertyName("cpu")]
        public int Cpu { get; set; } = default!;

        /// <summary>
        /// quantity of allowed RAM
        /// </summary>

        [JsonPropertyName("ram")]
        public int Ram { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ipv4.
        /// </summary>
        [JsonPropertyName("ipv4")]
        public string? Ipv4 { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ipv6.
        /// </summary>
        [JsonPropertyName("ipv6")]
        public string? Ipv6 { get; set; } = default!;

        /// <summary>
        /// Gets or sets the parent_id.
        /// </summary>
        [JsonPropertyName("parent_id")]
        public int Parent_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        [JsonPropertyName("parent")]
        public LogicalServer Parent { get; set; } = default!;

        /// <summary>
        /// Gets or sets the parent_equipment.
        /// </summary>
        [JsonPropertyName("parent_equipment")]
        public EquipmentServer Parent_equipment { get; set; } = default!;

        /// <summary>
        /// Timestamp `LogicalServer` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;
    }
}