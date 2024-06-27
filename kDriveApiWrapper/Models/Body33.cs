namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body33.
    /// </summary>
    public partial class Body33 : Data
    {
        /// <summary>
        /// Access level of {name}.&lt;note&gt;&lt;strong&gt;manage&lt;/strong&gt;: Can share, write and read the file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;none&lt;/strong&gt;: Can not act on the file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;read&lt;/strong&gt;: Can only read the file.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;write&lt;/strong&gt;: Can write and read the file.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("right")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body33Right Right { get; set; } = default!;
    }
}