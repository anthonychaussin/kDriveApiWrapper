namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The directory.
    /// </summary>
    public partial class Directory : Data
    {
        /// <summary>
        /// Unique identifier of the resource `Directory`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// File name
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Specific sortable name
        /// </summary>

        [JsonPropertyName("sorted_name")]
        public string Sorted_name { get; set; } = default!;

        /// <summary>
        /// Full path of the Directory
        /// </summary>

        [JsonPropertyName("path")]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Type of returned element either a dir (Directory) or file (File)
        /// </summary>

        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DirectoryType? Type { get; set; } = default!;

        /// <summary>
        /// Current state of Directory. The state can be null meaning that the Directory has no specific state.&lt;note&gt;&lt;strong&gt;erasing&lt;/strong&gt;: Directory is currently being erased from the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;locked&lt;/strong&gt;: Directory is currently locked. No action can be made except unlocking by the application which locked the File (such as office, webdav or external import).&lt;/note&gt;&lt;note&gt;&lt;strong&gt;trash_inherited&lt;/strong&gt;: Directory is currently in trash because a parent directory was trashed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;trashed&lt;/strong&gt;: Directory is currently in trash and specifically trashed by the user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;uploading&lt;/strong&gt;: Directory is currently being uploaded. The Directory is locked and no action can be done excepting upload actions.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("status")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DirectoryStatus? Status { get; set; } = default!;

        /// <summary>
        /// Visibility of Directory, empty string if no specific visibility. Add additional information about Directory to show different icons or more.&lt;note&gt;&lt;strong&gt;&lt;/strong&gt;: Empty visibility mean no special visibility.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_in_team_space_folder&lt;/strong&gt;: Is a Directory inside a Common Documents directory.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_root&lt;/strong&gt;: Is the root directory of the user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_shared_space&lt;/strong&gt;: Is the shared root directory, a special directory where the files inside are the private files of other user shared with the logged user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_team_space&lt;/strong&gt;: Is the Common Documents directory, a special directory where the files inside are common to all users by default.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_team_space_folder&lt;/strong&gt;: Is the root directory inside the Common Documents.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("visibility")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DirectoryVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// Drive identifier
        /// </summary>

        [JsonPropertyName("drive_id")]
        public int Drive_id { get; set; } = default!;

        /// <summary>
        /// Current path depth of Directory
        /// </summary>

        [JsonPropertyName("depth")]
        public int Depth { get; set; } = default!;

        /// <summary>
        /// The identifier of the user who first uploaded the Directory
        /// </summary>

        [JsonPropertyName("created_by")]
        public int? Created_by { get; set; } = default!;

        /// <summary>
        /// Directory creation timestamp (in seconds), if available in its metadata or specified on upload
        /// </summary>

        [JsonPropertyName("created_at")]
        public int? Created_at { get; set; } = default!;

        /// <summary>
        /// The timestamp (in seconds) at which the Directory has been uploaded for the first time
        /// </summary>

        [JsonPropertyName("added_at")]
        public int Added_at { get; set; } = default!;

        /// <summary>
        /// Directory creation timestamp (in seconds), if available in its metadata or specified on upload
        /// </summary>

        [JsonPropertyName("last_modified_at")]
        public int Last_modified_at { get; set; } = default!;

        /// <summary>
        /// Parent directory identifier
        /// </summary>

        [JsonPropertyName("parent_id")]
        public int Parent_id { get; set; } = default!;

        /// <summary>
        /// Timestamp of deleted resource Directory, only visible when the Directory is trashed
        /// </summary>

        [JsonPropertyName("deleted_at")]
        public int Deleted_at { get; set; } = default!;

        /// <summary>
        /// User identifier of deleted resource Directory, only visible when the Directory is trashed
        /// </summary>

        [JsonPropertyName("deleted_by")]
        public int Deleted_by { get; set; } = default!;

        /// <summary>
        /// Root Directory identifier, only visible for shared user
        /// </summary>

        [JsonPropertyName("shared_root_id")]
        public int? Shared_root_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the parents.
        /// </summary>
        [JsonPropertyName("parents")]
        public ICollection<Directory> Parents { get; set; } = default!;

        /// <summary>
        /// Array of users identifiers that has access to the Directory
        /// </summary>

        [JsonPropertyName("users")]
        public ICollection<int> Users { get; set; } = default!;

        /// <summary>
        /// Array of teams identifiers that has access to the Directory
        /// </summary>

        [JsonPropertyName("teams")]
        public ICollection<int> Teams { get; set; } = default!;

        /// <summary>
        /// Is Directory pinned as favorite
        /// </summary>

        [JsonPropertyName("is_favorite")]
        public bool Is_favorite { get; set; } = default!;

        /// <summary>
        /// Activities information about the Directory
        /// </summary>

        [JsonPropertyName("activity")]
        public Activity3 Activity { get; set; } = default!;

        /// <summary>
        /// Gets or sets the sharelink.
        /// </summary>
        [JsonPropertyName("sharelink")]
        public ShareLink Sharelink { get; set; } = default!;

        /// <summary>
        /// Directory rights
        /// </summary>

        [JsonPropertyName("capabilities")]
        public Capabilities7 Capabilities { get; set; } = default!;

        /// <summary>
        /// When Directory is locked, locked information
        /// </summary>

        [JsonPropertyName("lock")]
        public Lock2 Lock { get; set; } = default!;

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        [JsonPropertyName("categories")]
        public ICollection<FileCategory> Categories { get; set; } = default!;

        /// <summary>
        /// ETag of the file
        /// </summary>

        [JsonPropertyName("etag")]
        public string? Etag { get; set; } = default!;

        /// <summary>
        /// Color of the directory for the user requesting it
        /// </summary>

        [JsonPropertyName("color")]
        public string? Color { get; set; } = default!;

        /// <summary>
        /// Gets or sets the dropbox.
        /// </summary>
        [JsonPropertyName("dropbox")]
        public Dropbox Dropbox { get; set; } = default!;

        /// <summary>
        /// Gets or sets the external_import.
        /// </summary>
        [JsonPropertyName("external_import")]
        public ExternalImportFile External_import { get; set; } = default!;

        /// <summary>
        /// Gets or sets the rewind.
        /// </summary>
        [JsonPropertyName("rewind")]
        public Rewind Rewind { get; set; } = default!;
    }
}