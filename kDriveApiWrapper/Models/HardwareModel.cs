namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The hardware model.
    /// </summary>
    public partial class HardwareModel : Data
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

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
        /// Gets or sets the generation.
        /// </summary>
        [JsonPropertyName("generation")]
        public string Generation { get; set; } = default!;

        /// <summary>
        /// Gets or sets the equipment_type_id.
        /// </summary>
        [JsonPropertyName("equipment_type_id")]
        public int Equipment_type_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the manufacturer_id.
        /// </summary>
        [JsonPropertyName("manufacturer_id")]
        public int Manufacturer_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the shortname_alias.
        /// </summary>
        [JsonPropertyName("shortname_alias")]
        public string Shortname_alias { get; set; } = default!;

        /// <summary>
        /// Gets or sets the site_id.
        /// </summary>
        [JsonPropertyName("site_id")]
        public int Site_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the schema_id.
        /// </summary>
        [JsonPropertyName("schema_id")]
        public int Schema_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the factory_path.
        /// </summary>
        [JsonPropertyName("factory_path")]
        public string Factory_path { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the skip_serial.
        /// </summary>
        [JsonPropertyName("skip_serial")]
        public string Skip_serial { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_at.
        /// </summary>
        [JsonPropertyName("updated_at")]
        [JsonConverter(typeof(DateFormatConverter))]
        public DateTimeOffset Updated_at { get; set; } = default!;
    }
}