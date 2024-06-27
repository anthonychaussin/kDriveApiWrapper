namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The storage machine.
    /// </summary>
    public partial class StorageMachine : Data
    {
        /// <summary>
        /// Unique identifier of the `channel` that is related to the resource `StorageMachine`
        /// </summary>

        [JsonPropertyName("storage_machine_id")]
        public int Storage_machine_id { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `vodProduct` that is related to the resource `StorageMachine`
        /// </summary>

        [JsonPropertyName("vod_id")]
        public int Vod_id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `StorageMachine`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the protocol.
        /// </summary>
        [JsonPropertyName("protocol")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Protocol { get; set; } = default!;

        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        [JsonPropertyName("host")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Host { get; set; } = default!;

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        [JsonPropertyName("port")]
        public int Port { get; set; } = default!;

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        [JsonPropertyName("path")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Login
        /// </summary>

        [JsonPropertyName("login")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// Gets or sets the pass.
        /// </summary>
        [JsonPropertyName("pass")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Pass { get; set; } = default!;

        /// <summary>
        /// Gets or sets the url_http.
        /// </summary>
        [JsonPropertyName("url_http")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url_http { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether full.
        /// </summary>
        [JsonPropertyName("full")]
        public bool Full { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether valid.
        /// </summary>
        [JsonPropertyName("valid")]
        public bool Valid { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether use_path.
        /// </summary>
        [JsonPropertyName("use_path")]
        public bool Use_path { get; set; } = default!;

        /// <summary>
        /// Unique identifier of the `classing config` that is related to the resource `StorageMachine`
        /// </summary>

        [JsonPropertyName("classing_config_id")]
        public int classing_config_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether default.
        /// </summary>
        [JsonPropertyName("default")]
        public bool Default { get; set; } = default!;

        /// <summary>
        /// Gets or sets the auto_fragment_duration.
        /// </summary>
        [JsonPropertyName("auto_fragment_duration")]
        public int Auto_fragment_duration { get; set; } = default!;

        /// <summary>
        /// Timestamp `StorageMachine` has been deleted
        /// </summary>

        [JsonPropertyName("deleted_at")]
        public int Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the auto_class_name.
        /// </summary>
        [JsonPropertyName("auto_class_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Auto_class_name { get; set; } = default!;
    }
}