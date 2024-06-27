namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The fieldresource.
    /// </summary>
    public partial class Fieldresource : Data
    {
        /// <summary>
        /// the current monthly consumption (Byte)
        /// </summary>

        [JsonPropertyName("consumption")]
        public double Consumption { get; set; } = default!;

        /// <summary>
        /// Timestamp `Field resource` from
        /// </summary>

        [JsonPropertyName("from")]
        public int From { get; set; } = default!;

        /// <summary>
        /// Timestamp `Field resource` to
        /// </summary>

        [JsonPropertyName("to")]
        public int To { get; set; } = default!;
    }
}