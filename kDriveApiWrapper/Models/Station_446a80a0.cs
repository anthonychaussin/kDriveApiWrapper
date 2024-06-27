namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The station_446a80a0.
    /// </summary>
    public partial class Station_446a80a0
    {
        /// <summary>
        /// Unique identifier of the resource `Station`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Universally unique identifier of the resource `Station`
        /// </summary>

        [JsonPropertyName("uuid")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Station`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The url to the thumbnail of the `Station`
        /// </summary>

        [JsonPropertyName("thumbnail")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Thumbnail { get; set; } = default!;

        /// <summary>
        /// The password use to access to protected pages
        /// </summary>

        [JsonPropertyName("password")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Password { get; set; } = default!;

        /// <summary>
        /// Is the daily restart enabled?
        /// </summary>

        [JsonPropertyName("is_daily_restart")]
        public bool Is_daily_restart { get; set; } = default!;

        /// <summary>
        /// The time use for daily restart
        /// </summary>

        [JsonPropertyName("time_daily_restart")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Time_daily_restart { get; set; } = default!;

        /// <summary>
        /// The timezone to use for daily restart
        /// </summary>

        [JsonPropertyName("timezone_daily_restart")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Timezone_daily_restart { get; set; } = default!;

        /// <summary>
        /// Is the resource `Station` enabled?
        /// </summary>

        [JsonPropertyName("is_enabled")]
        public bool Is_enabled { get; set; } = default!;

        /// <summary>
        /// Is the ACPM stats enabled?
        /// </summary>

        [JsonPropertyName("is_acpm")]
        public bool Is_acpm { get; set; } = default!;

        /// <summary>
        /// Is the logs sending enabled?
        /// </summary>

        [JsonPropertyName("is_send_logs")]
        public bool Is_send_logs { get; set; } = default!;

        /// <summary>
        /// The server name to connect to the log server
        /// </summary>

        [JsonPropertyName("log_server")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Log_server { get; set; } = default!;

        /// <summary>
        /// The login to connect to the log server
        /// </summary>

        [JsonPropertyName("log_login")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Log_login { get; set; } = default!;

        /// <summary>
        /// The password to connect to the log server
        /// </summary>

        [JsonPropertyName("log_password")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Log_password { get; set; } = default!;

        /// <summary>
        /// The path where the log is store
        /// </summary>

        [JsonPropertyName("log_path")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Log_path { get; set; } = default!;

        /// <summary>
        /// The number of currently listeners listen all `Stream`
        /// </summary>

        [JsonPropertyName("listeners")]
        public int Listeners { get; set; } = default!;

        /// <summary>
        /// The name of the `Cluster`
        /// </summary>

        [JsonPropertyName("cluster_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Cluster_name { get; set; } = default!;

        /// <summary>
        /// The current monthly consumption (Byte)
        /// </summary>

        [JsonPropertyName("monthly_consumption")]
        public int Monthly_consumption { get; set; } = default!;

        /// <summary>
        /// The current count of streams online
        /// </summary>

        [JsonPropertyName("count_streams_up")]
        public int Count_streams_up { get; set; } = default!;

        /// <summary>
        /// Gets or sets the streams.
        /// </summary>
        [JsonPropertyName("streams")]
        public ICollection<string> Streams { get; set; } = default!;

        /// <summary>
        /// Gets or sets the hls_stream.
        /// </summary>
        [JsonPropertyName("hls_stream")]
        public HlsStream Hls_stream { get; set; } = default!;

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        [JsonPropertyName("options")]
        public string Options { get; set; } = default!;

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        [JsonPropertyName("stats")]
        public ICollection<object> Stats { get; set; } = default!;

        /// <summary>
        /// Timestamp `Station` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `Station` has been updated
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;
    }
}