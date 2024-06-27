namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The entity2.
    /// </summary>
    public partial class Entity2 : Data
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