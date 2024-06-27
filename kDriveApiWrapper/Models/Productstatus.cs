namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The productstatus.
    /// </summary>
    public partial class Productstatus : Data
    {
        /// <summary>
        /// Gets or sets the maintenance.
        /// </summary>
        [JsonPropertyName("maintenance")]
        [System.ComponentModel.DataAnnotations.Required]
        public Maintenance Maintenance { get; set; } = new Maintenance();

        /// <summary>
        /// Gets or sets the locked.
        /// </summary>
        [JsonPropertyName("locked")]
        [System.ComponentModel.DataAnnotations.Required]
        public Locked Locked { get; set; } = new Locked();

        /// <summary>
        /// Gets or sets the activated_by.
        /// </summary>
        [JsonPropertyName("activated_by")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<int> Activated_by { get; set; } = [];

        /// <summary>
        /// Gets or sets the activated_at.
        /// </summary>
        [JsonPropertyName("activated_at")]
        public int Activated_at { get; set; } = default!;
    }
}