namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Media
    /// </summary>

    public partial class Api_Media
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; } = default!;

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
        /// Gets or sets the shot_boundaries.
        /// </summary>
        [JsonPropertyName("shot_boundaries")]
        public ICollection<int> Shot_boundaries { get; set; } = default!;

        /// <summary>
        /// duration in seconds
        /// </summary>

        [JsonPropertyName("duration")]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// Gets or sets the collected_at.
        /// </summary>
        [JsonPropertyName("collected_at")]
        public string Collected_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the published_at.
        /// </summary>
        [JsonPropertyName("published_at")]
        public string Published_at { get; set; } = default!;

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
        /// Gets or sets the discarded_at.
        /// </summary>
        [JsonPropertyName("discarded_at")]
        public string Discarded_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the deleted_at.
        /// </summary>
        [JsonPropertyName("deleted_at")]
        public string Deleted_at { get; set; } = default!;

        /// <summary>
        /// Gets or sets the manifests.
        /// </summary>
        [JsonPropertyName("manifests")]
        public Media_manifests Manifests { get; set; } = default!;

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        [JsonPropertyName("source")]
        public Api_Link Source { get; set; } = default!;

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [JsonPropertyName("state")]
        public double State { get; set; } = default!;

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
        /// Gets or sets the poster.
        /// </summary>
        [JsonPropertyName("poster")]
        public Api_Link Poster { get; set; } = default!;

        /// <summary>
        /// Gets or sets the encodings.
        /// </summary>
        [JsonPropertyName("encodings")]
        public ICollection<Api_Encoding> Encodings { get; set; } = default!;

        /// <summary>
        /// %
        /// </summary>

        [JsonPropertyName("progress")]
        public double Progress { get; set; } = default!;

        /// <summary>
        /// Gets or sets the playbacks.
        /// </summary>
        [JsonPropertyName("playbacks")]
        public Media_playbacks Playbacks { get; set; } = default!;

        /// <summary>
        /// Gets or sets the annotations.
        /// </summary>
        [JsonPropertyName("annotations")]
        public ICollection<Api_Annotation> Annotations { get; set; } = default!;

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; } = default!;

        /// <summary>
        /// Gets or sets the chapters.
        /// </summary>
        [JsonPropertyName("chapters")]
        public ICollection<Api_Chapter> Chapters { get; set; } = default!;

        /// <summary>
        /// Gets or sets the folder.
        /// </summary>
        [JsonPropertyName("folder")]
        public string Folder { get; set; } = default!;

        /// <summary>
        /// Gets or sets the country_restricted.
        /// </summary>
        [JsonPropertyName("country_restricted")]
        public string Country_restricted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the ip_restricted.
        /// </summary>
        [JsonPropertyName("ip_restricted")]
        public string Ip_restricted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the key_restricted.
        /// </summary>
        [JsonPropertyName("key_restricted")]
        public string Key_restricted { get; set; } = default!;

        /// <summary>
        /// Gets or sets the path.
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Gets or sets the journal.
        /// </summary>
        [JsonPropertyName("journal")]
        public ICollection<Api_MediaJournalLog> Journal { get; set; } = default!;

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        [JsonPropertyName("language")]
        public ICollection<Api_Language> Language { get; set; } = default!;

        /// <summary>
        /// Gets or sets the logos.
        /// </summary>
        [JsonPropertyName("logos")]
        public ICollection<Api_Logo> Logos { get; set; } = default!;

        /// <summary>
        /// Gets or sets the scenes.
        /// </summary>
        [JsonPropertyName("scenes")]
        public Api_Thumbnail Scenes { get; set; } = default!;

        /// <summary>
        /// Gets or sets the shares.
        /// </summary>
        [JsonPropertyName("shares")]
        public ICollection<Api_Share> Shares { get; set; } = default!;

        /// <summary>
        /// Gets or sets the subtitles.
        /// </summary>
        [JsonPropertyName("subtitles")]
        public ICollection<Api_Subtitle> Subtitles { get; set; } = default!;

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public ICollection<string> Tags { get; set; } = default!;

        /// <summary>
        /// Gets or sets the thumbstrip.
        /// </summary>
        [JsonPropertyName("thumbstrip")]
        public Api_Thumbnail Thumbstrip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the upload.
        /// </summary>
        [JsonPropertyName("upload")]
        public Api_Upload Upload { get; set; } = default!;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }
}