namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The rewind.
    /// </summary>
    public partial class Rewind : Data
    {
        /// <summary>
        /// Rewind identifier
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Rewind status.&lt;note&gt;&lt;strong&gt;canceled&lt;/strong&gt;: Rewind was canceled by the user and deleted.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;done&lt;/strong&gt;: Rewind completed successfully.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;drive_not_ready&lt;/strong&gt;: Rewind cannot start because the drive was not ready (uploads or actions in progress).&lt;/note&gt;&lt;note&gt;&lt;strong&gt;expired&lt;/strong&gt;: Rewind has expired and deleted.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;failed&lt;/strong&gt;: Rewind completed with errors.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;in_progress&lt;/strong&gt;: Rewind is currently in progress.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;new&lt;/strong&gt;: Rewind did not start.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;sanitizing&lt;/strong&gt;: Rewind find the activity to sanitize.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;waiting_approval&lt;/strong&gt;: Rewind waiting user approval to continue.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("status")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RewindStatus Status { get; set; } = default!;

        /// <summary>
        /// Rewind type.&lt;note&gt;&lt;strong&gt;directory&lt;/strong&gt;: Rewind only a directory.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;drive&lt;/strong&gt;: Rewind all the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;user&lt;/strong&gt;: Rewind a user's private folder.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("mode")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RewindMode Mode { get; set; } = default!;

        /// <summary>
        /// Rewind archive mode, all created files between now and the rewind date will be set to trash or to an archive depending on the mode selected.&lt;note&gt;&lt;strong&gt;all&lt;/strong&gt;: Keep in an archive folder the current or trashed files.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;current&lt;/strong&gt;: Keep in an archive folder the current files.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;none&lt;/strong&gt;: Don't build an archive, trash all created files.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("archiving")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RewindArchiving? Archiving { get; set; } = default!;

        /// <summary>
        /// The targeted directory of the rewind &lt;note&gt;Filled only in directory and user mode&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("directory_id")]
        public int? Directory_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the directory.
        /// </summary>
        [JsonPropertyName("directory")]
        public Directory Directory { get; set; } = default!;

        /// <summary>
        /// The name of the directory selected when the directory mode is selected
        /// </summary>

        [JsonPropertyName("directory_name")]
        public string Directory_name { get; set; } = default!;

        /// <summary>
        /// The targeted user of the rewind &lt;note&gt;Filled only in user mode&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("user_id")]
        public int? User_id { get; set; } = default!;

        /// <summary>
        /// Rewind at
        /// </summary>

        [JsonPropertyName("rewind_at")]
        public int Rewind_at { get; set; } = default!;

        /// <summary>
        /// created at
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// when the rewind is executed the finished process time is save here
        /// </summary>

        [JsonPropertyName("finished_at")]
        public int Finished_at { get; set; } = default!;

        /// <summary>
        /// Date of the rewind approval
        /// </summary>

        [JsonPropertyName("expires_at")]
        public int Expires_at { get; set; } = default!;

        /// <summary>
        /// created by the user
        /// </summary>

        [JsonPropertyName("created_by")]
        public int Created_by { get; set; } = default!;

        /// <summary>
        /// Rewind approved by the user
        /// </summary>

        [JsonPropertyName("is_approved")]
        public bool Is_approved { get; set; } = default!;

        /// <summary>
        /// Date of the rewind approval
        /// </summary>

        [JsonPropertyName("approval_at")]
        public int Approval_at { get; set; } = default!;

        /// <summary>
        /// The name of the directory choose during approval step
        /// </summary>

        [JsonPropertyName("rewind_name")]
        public string Rewind_name { get; set; } = default!;

        /// <summary>
        /// Sanitizer resume, returned only when the rewind has done the sanitizing process
        /// </summary>

        [JsonPropertyName("sanitizer")]
        public Sanitizer Sanitizer { get; set; } = default!;

        /// <summary>
        /// Rewind resume, returned only when the rewind is finished
        /// </summary>

        [JsonPropertyName("summary")]
        public Summary Summary { get; set; } = default!;
    }
}