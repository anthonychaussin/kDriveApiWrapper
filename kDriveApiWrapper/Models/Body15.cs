namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body15.
    /// </summary>
    public partial class Body15 : Data
    {
        /// <summary>
        /// ID of the destination folder for the copy
        /// </summary>

        [JsonPropertyName("destination_folder_id")]
        public int Destination_folder_id { get; set; } = default!;

        /// <summary>
        /// Ids of files to be imported. If missing or empty, all files of the share link will be imported
        /// </summary>

        [JsonPropertyName("except_file_ids")]
        public ICollection<int>? Except_file_ids { get; set; } = default!;

        /// <summary>
        /// Ids of files to be imported. If missing or empty, all files of the share link will be imported
        /// </summary>

        [JsonPropertyName("file_ids")]
        public ICollection<int>? File_ids { get; set; } = default!;

        /// <summary>
        /// Password to access protected share link
        /// </summary>

        [JsonPropertyName("password")]
        public string? Password { get; set; } = default!;

        /// <summary>
        /// Rename the imported file (when importing only one file or folder)
        /// </summary>

        [JsonPropertyName("rename")]
        [System.ComponentModel.DataAnnotations.StringLength(256, MinimumLength = 1)]
        public string Rename { get; set; } = default!;

        /// <summary>
        /// UUID of the share link to import
        /// </summary>

        [JsonPropertyName("sharelink_uuid")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(36)]
        public string Sharelink_uuid { get; set; } = default!;

        /// <summary>
        /// ID of the kDrive containing the sharelink to copy
        /// </summary>

        [JsonPropertyName("source_drive_id")]
        public int Source_drive_id { get; set; } = default!;
    }
}