namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The physical server.
    /// </summary>
    public partial class PhysicalServer : Data
    {
        /// <summary>
        /// Unique identifier of the resource `PhysicalServer`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the cpu_description.
        /// </summary>
        [JsonPropertyName("cpu_description")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Cpu_description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the memory_description.
        /// </summary>
        [JsonPropertyName("memory_description")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Memory_description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the storage_description.
        /// </summary>
        [JsonPropertyName("storage_description")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Storage_description { get; set; } = default!;

        /// <summary>
        /// Gets or sets the main_server.
        /// </summary>
        [JsonPropertyName("main_server")]
        [System.ComponentModel.DataAnnotations.Required]
        public LogicalServer Main_server { get; set; } = new LogicalServer();

        /// <summary>
        /// Gets or sets the servers.
        /// </summary>
        [JsonPropertyName("servers")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<LogicalServer> Servers { get; set; } = [];
    }
}