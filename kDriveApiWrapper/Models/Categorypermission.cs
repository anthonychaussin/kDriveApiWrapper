namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The categorypermission.
    /// </summary>
    public partial class Categorypermission : Data
    {
        /// <summary>
        /// User can create new categories
        /// </summary>

        [JsonPropertyName("can_create")]
        public bool Can_create { get; set; } = default!;

        /// <summary>
        /// User can edit existing categories
        /// </summary>

        [JsonPropertyName("can_edit")]
        public bool Can_edit { get; set; } = default!;

        /// <summary>
        /// User can delete categories and remove them from files
        /// </summary>

        [JsonPropertyName("can_delete")]
        public bool Can_delete { get; set; } = default!;

        /// <summary>
        /// User can read the categories that are present on files
        /// </summary>

        [JsonPropertyName("can_read_on_file")]
        public bool Can_read_on_file { get; set; } = default!;

        /// <summary>
        /// User can add categories to files
        /// </summary>

        [JsonPropertyName("can_put_on_file")]
        public bool Can_put_on_file { get; set; } = default!;
    }
}