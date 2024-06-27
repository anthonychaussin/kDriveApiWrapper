namespace kDriveApiWrapper.Models.Trash
{
    /// <summary>
    /// The trash.
    /// </summary>
    public partial class TrashOption : Data
    {
        /// <summary>
        /// Number of days the files are kept in trash. &lt;note&gt;Unit is in days&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("max_duration")]
        public TrashMaxduration Max_duration { get; set; } = TrashMaxduration._90;
    }
}