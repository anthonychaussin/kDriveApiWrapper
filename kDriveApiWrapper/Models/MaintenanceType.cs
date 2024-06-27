namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The maintenance type.
    /// </summary>
    public partial class MaintenanceType : Data
    {
        /// <summary>
        /// Name of active Maintenance Type
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Active Maintenance Type
        /// </summary>

        [JsonPropertyName("code")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Short explanation of active Maintenance Type
        /// </summary>

        [JsonPropertyName("description")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Description { get; set; } = default!;
    }
}