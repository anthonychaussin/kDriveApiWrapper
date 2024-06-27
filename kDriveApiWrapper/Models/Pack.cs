namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The pack.
    /// </summary>
    public partial class Pack : Data
    {
        /// <summary>
        /// Unique identifier of the `pack` that is related to the resource `Pack`
        /// </summary>

        [JsonPropertyName("pack_id")]
        public int Pack_id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Pack`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the order_info.
        /// </summary>
        [JsonPropertyName("order_info")]
        public int Order_info { get; set; } = default!;

        /// <summary>
        /// The archive storage space, is in GB
        /// </summary>

        [JsonPropertyName("available_space_vod")]
        public int Available_space_vod { get; set; } = default!;

        /// <summary>
        /// The max `Channel` Number of stream is included
        /// </summary>

        [JsonPropertyName("max_channel")]
        public int Max_channel { get; set; } = default!;

        /// <summary>
        /// The cost per extra GB consumed
        /// </summary>

        [JsonPropertyName("monthly_fee")]
        public int Monthly_fee { get; set; } = default!;

        /// <summary>
        /// The max 'bandwidth' available by month, is in To
        /// </summary>

        [JsonPropertyName("bandwidth")]
        public int Bandwidth { get; set; } = default!;

        /// <summary>
        /// The max 'auditors' available.
        /// </summary>

        [JsonPropertyName("max_auditors")]
        public int Max_auditors { get; set; } = default!;

        /// <summary>
        /// Pack available
        /// </summary>

        [JsonPropertyName("hide")]
        public bool Hide { get; set; } = default!;

        /// <summary>
        /// Gets or sets the prices.
        /// </summary>
        [JsonPropertyName("prices")]
        public Pricesressource Prices { get; set; } = default!;
    }
}