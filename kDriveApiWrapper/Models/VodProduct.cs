namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The vod product.
    /// </summary>
    public partial class VodProduct : Data
    {
        /// <summary>
        /// Unique identifier of the `vodProduct` that is related to the resource `VodProduct`
        /// </summary>

        [JsonPropertyName("vod_id")]
        public int Vod_id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `VodProduct`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;
    }
}