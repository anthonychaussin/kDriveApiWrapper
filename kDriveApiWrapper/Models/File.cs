namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The file.
    /// </summary>
    public partial class File : Data
    {
        /// <summary>
        /// Unique identifier of the resource `File`
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
        /// Full path of the File
        /// </summary>

        [JsonPropertyName("path")]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Type of returned element either a dir (Directory) or file (File)
        /// </summary>

        [JsonPropertyName("type")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FileTypeEnum? Type { get; set; } = default!;

        /// <summary>
        /// Current state of File. The state can be null meaning that the File has no specific state.&lt;note&gt;&lt;strong&gt;erasing&lt;/strong&gt;: File is currently being erased from the drive.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;locked&lt;/strong&gt;: File is currently locked. No action can be made except unlocking by the application which locked the File (such as office, webdav or external import).&lt;/note&gt;&lt;note&gt;&lt;strong&gt;trash_inherited&lt;/strong&gt;: File is currently in trash because a parent directory was trashed.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;trashed&lt;/strong&gt;: File is currently in trash and specifically trashed by the user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;uploading&lt;/strong&gt;: File is currently being uploaded. The File is locked and no action can be done excepting upload actions.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("status")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FileStatus? Status { get; set; } = default!;

        /// <summary>
        /// Visibility of File, empty string if no specific visibility. Add additional information about File to show different icons or more.&lt;note&gt;&lt;strong&gt;&lt;/strong&gt;: Empty visibility mean no special visibility.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_in_private_space&lt;/strong&gt;: Is a File inside the private directory of the user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_in_shared_space&lt;/strong&gt;: Is a File inside the shared root directory, a special directory where the files inside are the private files of other user shared with the logged user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_in_team_space_folder&lt;/strong&gt;: Is a File inside a Common Documents directory.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_private_space&lt;/strong&gt;: Is the private directory of the user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_root&lt;/strong&gt;: Is the root directory of the user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_shared_space&lt;/strong&gt;: Is the shared root directory, a special directory where the files inside are the private files of other user shared with the logged user.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_team_space&lt;/strong&gt;: Is the Common Documents directory, a special directory where the files inside are common to all users by default.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;is_team_space_folder&lt;/strong&gt;: Is the root directory inside the Common Documents.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("visibility")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public FileVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// Drive identifier
        /// </summary>

        [JsonPropertyName("drive_id")]
        public int Drive_id { get; set; } = default!;

        /// <summary>
        /// Current path depth of File
        /// </summary>

        [JsonPropertyName("depth")]
        public int Depth { get; set; } = default!;

        /// <summary>
        /// The identifier of the user who first uploaded the File
        /// </summary>

        [JsonPropertyName("created_by")]
        public int? Created_by { get; set; } = default!;

        /// <summary>
        /// File creation timestamp (in seconds), if available in its metadata or specified on upload
        /// </summary>

        [JsonPropertyName("created_at")]
        public int? Created_at { get; set; } = default!;

        /// <summary>
        /// The timestamp (in seconds) at which the File has been uploaded for the first time
        /// </summary>

        [JsonPropertyName("added_at")]
        public int Added_at { get; set; } = default!;

        /// <summary>
        /// File creation timestamp (in seconds), if available in its metadata or specified on upload
        /// </summary>

        [JsonPropertyName("last_modified_at")]
        public int Last_modified_at { get; set; } = default!;

        /// <summary>
        /// Id of the user who last modified the File
        /// </summary>

        [JsonPropertyName("last_modified_by")]
        public int? Last_modified_by { get; set; } = default!;

        /// <summary>
        /// The last time the content of the File was revised
        /// </summary>

        [JsonPropertyName("revised_at")]
        public int Revised_at { get; set; } = default!;

        /// <summary>
        /// The last time the File was updated
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;

        /// <summary>
        /// Parent directory identifier
        /// </summary>

        [JsonPropertyName("parent_id")]
        public int Parent_id { get; set; } = default!;

        /// <summary>
        /// Timestamp of deleted resource File, only visible when the File is trashed
        /// </summary>

        [JsonPropertyName("deleted_at")]
        public int Deleted_at { get; set; } = default!;

        /// <summary>
        /// User identifier of deleted resource File, only visible when the File is trashed
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
        /// Array of users identifiers that has access to the File
        /// </summary>

        [JsonPropertyName("users")]
        public ICollection<int> Users { get; set; } = default!;

        /// <summary>
        /// Array of teams identifiers that has access to the File
        /// </summary>

        [JsonPropertyName("teams")]
        public ICollection<int> Teams { get; set; } = default!;

        /// <summary>
        /// Is File pinned as favorite
        /// </summary>

        [JsonPropertyName("is_favorite")]
        public bool Is_favorite { get; set; } = default!;

        /// <summary>
        /// Activities information about the File
        /// </summary>

        [JsonPropertyName("activity")]
        public Activity.Activity Activity { get; set; } = default!;

        /// <summary>
        /// Gets or sets the sharelink.
        /// </summary>
        [JsonPropertyName("sharelink")]
        public ShareLink Sharelink { get; set; } = default!;

        /// <summary>
        /// Capabilities of File
        /// </summary>

        [JsonPropertyName("capabilities")]
        public Capabilities5 Capabilities { get; set; } = default!;

        /// <summary>
        /// When File is locked, locked information
        /// </summary>

        [JsonPropertyName("lock")]
        public Lock Lock { get; set; } = default!;

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
        /// Size of File &lt;note&gt;The unit of size is defined in Bytes&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("size")]
        public int? Size { get; set; } = default!;

        /// <summary>
        /// Mime-type of file
        /// </summary>

        [JsonPropertyName("mime_type")]
        public string? Mime_type { get; set; } = default!;

        /// <summary>
        /// File type
        /// </summary>

        [JsonPropertyName("extension_type")]
        public string? Extension_type { get; set; } = default!;

        /// <summary>
        /// Symlink target path if the file was uploaded as a symlink
        /// </summary>

        [JsonPropertyName("symbolic_link")]
        public string Symbolic_link { get; set; } = default!;

        /// <summary>
        /// List of app of where the file can be opened.&lt;note&gt;&lt;strong&gt;drawio&lt;/strong&gt;: File is handled by the drawio app webview.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;kmail&lt;/strong&gt;: File is handled by the kmail app webview.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;onlyoffice&lt;/strong&gt;: File is handled by only-office route.&lt;/note&gt;&lt;note&gt;&lt;strong&gt;thumbnail&lt;/strong&gt;: File is handled by preview and thumbnail route.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("supported_by")]
        public ICollection<object> Supported_by { get; set; } = default!;

        /// <summary>
        /// Information when file has multi-version
        /// </summary>

        [JsonPropertyName("version")]
        public Version Version { get; set; } = default!;

        /// <summary>
        /// The available ways to convert the file
        /// </summary>

        [JsonPropertyName("conversion_capabilities")]
        public Conversion_capabilities Conversion_capabilities { get; set; } = default!;

        /// <summary>
        /// Hash of the file content
        /// </summary>

        [JsonPropertyName("hash")]
        public string? Hash { get; set; } = default!;
    }
}