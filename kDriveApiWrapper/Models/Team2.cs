namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The team2.
    /// </summary>
    public partial class Team2 : Data
    {
        /// <summary>
        /// Gets or sets the to_execute.
        /// </summary>
        [JsonPropertyName("to_execute")]
        public int To_execute { get; set; } = default!;

        /// <summary>
        /// Gets or sets the files_found.
        /// </summary>
        [JsonPropertyName("files_found")]
        public int Files_found { get; set; } = default!;

        /// <summary>
        /// Gets or sets the to_move.
        /// </summary>
        [JsonPropertyName("to_move")]
        public int To_move { get; set; } = default!;

        /// <summary>
        /// Gets or sets the to_rename.
        /// </summary>
        [JsonPropertyName("to_rename")]
        public int To_rename { get; set; } = default!;

        /// <summary>
        /// Gets or sets the to_update.
        /// </summary>
        [JsonPropertyName("to_update")]
        public int To_update { get; set; } = default!;

        /// <summary>
        /// Gets or sets the to_restore.
        /// </summary>
        [JsonPropertyName("to_restore")]
        public int To_restore { get; set; } = default!;

        /// <summary>
        /// Gets or sets the to_trash.
        /// </summary>
        [JsonPropertyName("to_trash")]
        public int To_trash { get; set; } = default!;

        /// <summary>
        /// Gets or sets the to_archive.
        /// </summary>
        [JsonPropertyName("to_archive")]
        public int To_archive { get; set; } = default!;

        /// <summary>
        /// Gets or sets the not_handled_versions.
        /// </summary>
        [JsonPropertyName("not_handled_versions")]
        public int Not_handled_versions { get; set; } = default!;

        /// <summary>
        /// Gets or sets the not_handled_files.
        /// </summary>
        [JsonPropertyName("not_handled_files")]
        public int Not_handled_files { get; set; } = default!;
    }
}