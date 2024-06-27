namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// BrowsableVirtualFile
    /// </summary>

    public partial class Api_BrowsableVirtualFile
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether validated.
        /// </summary>
        [JsonPropertyName("validated")]
        public bool Validated { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether published.
        /// </summary>
        [JsonPropertyName("published")]
        public bool Published { get; set; } = default!;

        /// <summary>
        /// Gets or sets the streams.
        /// </summary>
        [JsonPropertyName("streams")]
        public ICollection<string> Streams { get; set; } = default!;

        /// <summary>
        /// duration in seconds
        /// </summary>

        [JsonPropertyName("duration")]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        [JsonPropertyName("size")]
        public double Size { get; set; } = default!;

        /// <summary>
        /// Gets or sets the created_at.
        /// </summary>
        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the updated_at.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public string Updated_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the discarded_at.
        /// </summary>
        [JsonPropertyName("discarded_at")]
        public string Discarded_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the folders_count.
        /// </summary>
        [JsonPropertyName("folders_count")]
        public int Folders_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the files_count.
        /// </summary>
        [JsonPropertyName("files_count")]
        public int Files_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Gets or sets the preview.
        /// </summary>
        [JsonPropertyName("preview")]
        public Api_Preview Preview { get; set; } = default!;

        /// <summary>
        /// Gets or sets the sample.
        /// </summary>
        [JsonPropertyName("sample")]
        public Api_Sample Sample { get; set; } = default!;

        /// <summary>
        /// Gets or sets the thumbnail.
        /// </summary>
        [JsonPropertyName("thumbnail")]
        public Api_Link Thumbnail { get; set; } = default!;

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [JsonPropertyName("state")]
        public double State { get; set; } = default!;

        /// <summary>
        /// %
        /// </summary>

        [JsonPropertyName("progress")]
        public double Progress { get; set; } = default!;

        /// <summary>
        /// Gets or sets the playlists_attached_count.
        /// </summary>
        [JsonPropertyName("playlists_attached_count")]
        public double Playlists_attached_count { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public ICollection<string> Tags { get; set; } = default!;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;
    }
}