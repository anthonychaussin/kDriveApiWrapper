namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The equipment server.
    /// </summary>
    public partial class EquipmentServer : Data
    {
        /// <summary>
        /// Unique identifier of the resource `EquipmentServer`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the serial_number.
        /// </summary>
        [JsonPropertyName("serial_number")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Serial_number { get; set; } = default!;

        /// <summary>
        /// Name of equipment
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Type of equipment
        /// </summary>

        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Status of equipment
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Date of creation
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the hardware_model.
        /// </summary>
        [JsonPropertyName("hardware_model")]
        public HardwareModel Hardware_model { get; set; } = default!;

        /// <summary>
        /// Gets or sets the specification.
        /// </summary>
        [JsonPropertyName("specification")]
        public ICollection<object> Specification { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ancestors.
        /// </summary>
        [JsonPropertyName("ancestors")]
        public ICollection<EquipmentBase> Ancestors { get; set; } = default!;

        /// <summary>
        /// Description of the resource `EquipmentServer`
        /// </summary>

        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Some equipments have 2 SN
        /// </summary>

        [JsonPropertyName("serial_number_2")]
        public string Serial_number_2 { get; set; } = default!;

        /// <summary>
        /// Order details
        /// </summary>

        [JsonPropertyName("order")]
        public string Order { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public ICollection<EquipmentTag> Tags { get; set; } = default!;

        /// <summary>
        /// Name of datacenter
        /// </summary>

        [JsonPropertyName("root_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Root_name { get; set; } = default!;

        /// <summary>
        /// Name of installed rack if is in production
        /// </summary>

        [JsonPropertyName("rack_name")]
        public string? Rack_name { get; set; } = default!;

        /// <summary>
        /// Id of installed rack if is in production
        /// </summary>

        [JsonPropertyName("rack_id")]
        public int? Rack_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [JsonPropertyName("position")]
        public string? Position { get; set; } = default!;

        /// <summary>
        /// Size of server on rack (1U,2U)
        /// </summary>

        [JsonPropertyName("size")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Size { get; set; } = default!;

        /// <summary>
        /// Gets or sets the components.
        /// </summary>
        [JsonPropertyName("components")]
        public ICollection<EquipmentBase> Components { get; set; } = default!;

        /// <summary>
        /// Gets or sets the network_infos.
        /// </summary>
        [JsonPropertyName("network_infos")]
        public PhysicalServer Network_infos { get; set; } = default!;

        /// <summary>
        /// Gets or sets the interfaces.
        /// </summary>
        [JsonPropertyName("interfaces")]
        public string Interfaces { get; set; } = default!;
    }
}