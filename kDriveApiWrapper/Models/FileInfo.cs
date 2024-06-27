namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The file info.
    /// </summary>
    public partial class FileInfo : Data
    {
        /// <summary>
        /// The unique identifier for this file
        /// </summary>

        [JsonPropertyName("id")]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the user that uploaded this file
        /// </summary>

        [JsonPropertyName("user_id")]
        public string User_id { get; set; } = default!;

        /// <summary>
        /// If this file is attached to a post, the ID of that post
        /// </summary>

        [JsonPropertyName("post_id")]
        public string Post_id { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds a file was created
        /// </summary>

        [JsonPropertyName("create_at")]
        public long Create_at { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds a file was last updated
        /// </summary>

        [JsonPropertyName("update_at")]
        public long Update_at { get; set; } = default!;

        /// <summary>
        /// The time in milliseconds a file was deleted
        /// </summary>

        [JsonPropertyName("delete_at")]
        public long Delete_at { get; set; } = default!;

        /// <summary>
        /// The name of the file
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The extension at the end of the file name
        /// </summary>

        [JsonPropertyName("extension")]
        public string Extension { get; set; } = default!;

        /// <summary>
        /// The size of the file in bytes
        /// </summary>

        [JsonPropertyName("size")]
        public int Size { get; set; } = default!;

        /// <summary>
        /// The MIME type of the file
        /// </summary>

        [JsonPropertyName("mime_type")]
        public string Mime_type { get; set; } = default!;

        /// <summary>
        /// If this file is an image, the width of the file
        /// </summary>

        [JsonPropertyName("width")]
        public int Width { get; set; } = default!;

        /// <summary>
        /// If this file is an image, the height of the file
        /// </summary>

        [JsonPropertyName("height")]
        public int Height { get; set; } = default!;

        /// <summary>
        /// If this file is an image, whether or not it has a preview-sized version
        /// </summary>

        [JsonPropertyName("has_preview_image")]
        public bool Has_preview_image { get; set; } = default!;
    }
}