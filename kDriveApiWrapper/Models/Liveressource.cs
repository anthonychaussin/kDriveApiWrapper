namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The liveressource.
    /// </summary>
    public partial class Liveressource : Data
    {
        /// <summary>
        /// Gets or sets the server_name.
        /// </summary>
        [JsonPropertyName("server_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Server_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the application_instance.
        /// </summary>
        [JsonPropertyName("application_instance")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Application_instance { get; set; } = default!;

        /// <summary>
        /// Gets or sets the bytes_in.
        /// </summary>
        [JsonPropertyName("bytes_in")]
        public int Bytes_in { get; set; } = default!;

        /// <summary>
        /// Gets or sets the bytes_out.
        /// </summary>
        [JsonPropertyName("bytes_out")]
        public int Bytes_out { get; set; } = default!;

        /// <summary>
        /// Gets or sets the bytes_in_rate.
        /// </summary>
        [JsonPropertyName("bytes_in_rate")]
        public int Bytes_in_rate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the bytes_out_rate.
        /// </summary>
        [JsonPropertyName("bytes_out_rate")]
        public int Bytes_out_rate { get; set; } = default!;

        /// <summary>
        /// Gets or sets the total_connections.
        /// </summary>
        [JsonPropertyName("total_connections")]
        public int Total_connections { get; set; } = default!;
    }
}