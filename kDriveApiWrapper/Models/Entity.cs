namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The entity.
    /// </summary>
    public partial class Entity : Data
    {
        /// <summary>
        /// Id of the object
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Type of the object
        /// </summary>

        [JsonPropertyName("type")]
        public int Type { get; set; } = default!;
    }
}