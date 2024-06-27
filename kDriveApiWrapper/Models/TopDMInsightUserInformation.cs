namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The top d m insight user information.
    /// </summary>
    public partial class TopDMInsightUserInformation : InsightUserInformation
    {
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [JsonPropertyName("position")]
        public string Position { get; set; } = default!;
    }
}