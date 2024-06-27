namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The external import file.
    /// </summary>
    public partial class ExternalImportFile : Data
    {
        /// <summary>
        /// External file import identifier
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// External file name
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// External file import status.&lt;note&gt;&lt;strong&gt;downloading&lt;/strong&gt;: External file is currently downloading.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;error&lt;/strong&gt;: External file import failed, additional information in the message field.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;finished&lt;/strong&gt;: External file was successfully imported.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;uploading&lt;/strong&gt;: External file is currently uploading.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;waiting&lt;/strong&gt;: External file is not upload, waiting to be imported.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ExternalImportFileStatus Status { get; set; } = default!;

        /// <summary>
        /// Message when error occur
        /// </summary>

        [JsonPropertyName("message")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// External file creation date
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;
    }
}