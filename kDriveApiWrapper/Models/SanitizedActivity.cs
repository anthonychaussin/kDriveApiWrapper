namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The sanitized activity.
    /// </summary>
    public partial class SanitizedActivity : Data
    {
        /// <summary>
        /// Path of the activity
        /// </summary>

        [JsonPropertyName("target")]
        public string Target { get; set; } = default!;

        /// <summary>
        /// Target date of the activity
        /// </summary>

        [JsonPropertyName("target_at")]
        public int Target_at { get; set; } = default!;

        /// <summary>
        /// Action to do in rewind situation.&lt;note&gt;&lt;strong&gt;archive&lt;/strong&gt;: File needs to be archived in a specific directory.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;archive_in_trash&lt;/strong&gt;: File needs to be archived in trash root.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_deleted&lt;/strong&gt;: File does not exist.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;move&lt;/strong&gt;: File needs to be moved.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;rename&lt;/strong&gt;: File needs to be renamed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;restore&lt;/strong&gt;: File needs to be restored from trash.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;trash&lt;/strong&gt;: File needs to be trashed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;update&lt;/strong&gt;: File content need to be updated.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;version_deleted&lt;/strong&gt;: File content does not exist.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("action")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SanitizedActivityAction Action { get; set; } = default!;

        /// <summary>
        /// State one action in the rewind process.&lt;note&gt;&lt;strong&gt;not_executed&lt;/strong&gt;: Action was not executed yet.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;not_handled&lt;/strong&gt;: Action cannot be rewound.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;on_conflict&lt;/strong&gt;: Action lead to a conflict with another file/directory, this item was moved to a specific directory.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;on_error&lt;/strong&gt;: Action lead to a fatal error, for instance the targeted version of a file was unable to be restored.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;success&lt;/strong&gt;: Action was executed correctly.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("state")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SanitizedActivityState State { get; set; } = default!;

        /// <summary>
        /// Gets or sets the special_parent_id.
        /// </summary>
        [JsonPropertyName("special_parent_id")]
        public int? Special_parent_id { get; set; } = default!;
    }
}