namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The equipment tag.
    /// </summary>
    public partial class EquipmentTag : Data
    {
        /// <summary>
        /// Unique identifier of the resource `EquipmentTag`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of tag
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Category of tag
        /// </summary>

        [JsonPropertyName("category")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Category { get; set; } = default!;
    }
}