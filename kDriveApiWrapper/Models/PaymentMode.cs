namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// This model represents a payment modes
    /// </summary>

    public partial class PaymentMode : Data
    {
        /// <summary>
        /// Unique id
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Name of the resource `Payment Mode`
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the validation_id.
        /// </summary>
        [JsonPropertyName("validation_id")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Validation_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the group_mode.
        /// </summary>
        [JsonPropertyName("group_mode")]
        public string Group_mode { get; set; } = default!;
    }
}