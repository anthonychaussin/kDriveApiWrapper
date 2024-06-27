namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The data.
    /// </summary>
    public partial class Data
    {
        /// <summary>
        /// Gets or sets the format.
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; } = default!;

        private IDictionary<string, object>? _additionalProperties;

        /// <summary>
        /// Gets or sets the additional properties.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties ??= new Dictionary<string, object>(); }
            set { _additionalProperties = value; }
        }
    }
}