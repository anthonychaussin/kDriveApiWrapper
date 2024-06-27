namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The trash.
    /// </summary>
    public partial class Trash : Data
    {
        /// <summary>
        /// Number of days the files are kept in trash. &lt;note&gt;Unit is in days&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("max_duration")]
        public int Max_duration { get; set; } = default!;
    }
}