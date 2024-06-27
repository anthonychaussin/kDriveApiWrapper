namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The machine.
    /// </summary>
    public partial class Machine : Data
    {
        /// <summary>
        /// Name of the resource `Machine`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ip.
        /// </summary>
        [JsonPropertyName("ip")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Ip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonPropertyName("url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Type of server
        /// </summary>

        [JsonPropertyName("type")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MachineType Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the pool_id.
        /// </summary>
        [JsonPropertyName("pool_id")]
        public MachinePool_id Pool_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the url_domain.
        /// </summary>
        [JsonPropertyName("url_domain")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url_domain { get; set; } = default!;
    }
}