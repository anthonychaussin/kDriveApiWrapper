using kDriveApiWrapper.Models.Trash;

namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body8.
    /// </summary>
    public partial class Body8 : Data
    {
        /// <summary>
        /// Number of days to keep file in trash. &lt;note&gt;The unit is in days&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("max_duration")]
        public TrashMaxduration Max_duration { get; set; } = default!;
    }
}