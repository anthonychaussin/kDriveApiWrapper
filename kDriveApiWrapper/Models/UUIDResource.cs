namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The u u i d resource.
    /// </summary>
    public partial class UUIDResource : Data
    {
        /// <summary>
        /// Universally unique identifier of the resource `UUID Resource`
        /// </summary>

        [JsonPropertyName("uuid")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Uuid { get; set; } = default!;
    }
}