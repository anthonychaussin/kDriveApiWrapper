namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The drive default limits.
    /// </summary>
    public partial class DriveDefaultLimits : Data
    {
        /// <summary>
        /// Number of files/folders in the same folder
        /// </summary>

        [JsonPropertyName("files_by_folders")]
        public int Files_by_folders { get; set; } = default!;

        /// <summary>
        /// Max file size
        /// </summary>

        [JsonPropertyName("files_size")]
        public int Files_size { get; set; } = default!;

        /// <summary>
        /// Max depth of folder
        /// </summary>

        [JsonPropertyName("sub_folders")]
        public int Sub_folders { get; set; } = default!;

        /// <summary>
        /// Number of days a file is conserved when trashed
        /// </summary>

        [JsonPropertyName("empty_trash_days")]
        public int Empty_trash_days { get; set; } = default!;

        /// <summary>
        /// Number of days a version of a file is conserved
        /// </summary>

        [JsonPropertyName("versioning_days")]
        public int Versioning_days { get; set; } = default!;

        /// <summary>
        /// Number of version of a fail
        /// </summary>

        [JsonPropertyName("versioning")]
        public int Versioning { get; set; } = default!;

        /// <summary>
        /// Max number of file for one user
        /// </summary>

        [JsonPropertyName("files_by_user")]
        public int Files_by_user { get; set; } = default!;

        /// <summary>
        /// Max shared link
        /// </summary>

        [JsonPropertyName("shared_link")]
        public int Shared_link { get; set; } = default!;

        /// <summary>
        /// Bandwidth authorize for a user in 24 hours
        /// </summary>

        [JsonPropertyName("bandwidth")]
        public int Bandwidth { get; set; } = default!;

        /// <summary>
        /// Max files downloadable in a archive
        /// </summary>

        [JsonPropertyName("archive_files_download")]
        public int Archive_files_download { get; set; } = default!;

        /// <summary>
        /// Max number of comments per file
        /// </summary>

        [JsonPropertyName("comments_per_file")]
        public int Comments_per_file { get; set; } = default!;

        /// <summary>
        /// Minimum size of a file to be cached on kCache before moving to a "cold" storage
        /// </summary>

        [JsonPropertyName("min_size_for_hotcache")]
        public int Min_size_for_hotcache { get; set; } = default!;
    }
}