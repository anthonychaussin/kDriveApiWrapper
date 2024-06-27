namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The upload session feedback.
    /// </summary>
    public partial class UploadSessionFeedback : Data
    {
        /// <summary>
        /// Directory destination identifier requested on upload
        /// </summary>

        [JsonPropertyName("file_id")]
        public int File_id { get; set; } = default!;

        /// <summary>
        /// Directory destination identifier requested on upload
        /// </summary>

        [JsonPropertyName("directory_id")]
        public int? Directory_id { get; set; } = default!;

        /// <summary>
        /// Directory destination path requested on upload
        /// </summary>

        [JsonPropertyName("directory_path")]
        public string? Directory_path { get; set; } = default!;

        /// <summary>
        /// File name requested on upload
        /// </summary>

        [JsonPropertyName("file_name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string File_name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        [JsonPropertyName("file")]
        [System.ComponentModel.DataAnnotations.Required]
        public File File { get; set; } = new File();

        /// <summary>
        /// New upload session token
        /// </summary>

        [JsonPropertyName("token")]
        public string? Token { get; set; } = default!;

        /// <summary>
        /// Upload session was created
        /// </summary>

        [JsonPropertyName("result")]
        public bool Result { get; set; } = default!;

        /// <summary>
        /// The error code returned, null if no error happens.&lt;note&gt;&lt;strong&gt;conflict_error&lt;/strong&gt;: Conflict detected. In the upload another &lt;strong&gt;conflict&lt;/strong&gt; mode can be used to handle it.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;file_already_exists_error&lt;/strong&gt;: Action impossible. The file already exist.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;forbidden_error&lt;/strong&gt;: Triggered when user does not have the file permission.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;quota_exceeded_error&lt;/strong&gt;: Triggered when the quota storage of the drive is reached.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;upload_by_another_user_not_terminated_error&lt;/strong&gt;: Another user upload the same file, the upload should be handle with another &lt;strong&gt;conflict&lt;/strong&gt; mode or the user should wait the current upload.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;upload_error&lt;/strong&gt;: Triggered when the upload did not finish, you should retry the upload.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;upload_failed_error&lt;/strong&gt;: Something is wrong, the received file did not match with the expected parameters (hash, size...), the upload should be restarted.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;upload_not_terminated_error&lt;/strong&gt;: Triggered when the upload did not receive all the expected chunks or the file is currently uploading.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;lock_error&lt;/strong&gt;: Action impossible. There is a lock on the file/directory.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("message")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UploadSessionFeedbackMessage? Message { get; set; } = default!;

        /// <summary>
        /// Upload url to use for uploading chunks.
        /// </summary>

        [JsonPropertyName("upload_url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Upload_url { get; set; } = default!;
    }
}