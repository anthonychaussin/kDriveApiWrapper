namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The star2.
    /// </summary>
    public partial class Star2 : Data
    {
        /// <summary>
        /// Override the creation date metadata of the new file.
        /// </summary>

        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// Override the update date metadata of the new file.
        /// </summary>

        [JsonPropertyName("last_modified_at")]
        public string Last_modified_at { get; set; } = default!;

        /// <summary>
        /// xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxx
        /// </summary>

        [JsonPropertyName("token")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"/^[a-f0-9]{8}-[a-f0-9]{4}-4[a-f0-9]{3}-[89aAbB][a-f0-9]{3}-[a-f0-9]{12}$/i")]
        public string Token { get; set; } = default!;

        /// <summary>
        /// The hash of the content of the file. If provided and the uploaded content does not match this hash, an error will be returned. For a multi-chunk upload use the hash of the concatenation of the chunk's hashes.&lt;note&gt;Supported hashing algorithm: md5, sha1, sha256, sha512, xxh3, xxh32, xxh64, xxh128&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("total_chunk_hash")]
        [System.ComponentModel.DataAnnotations.RegularExpression(@"/^((md5|sha1|sha256|sha512|xxh3|xxh32|xxh64|xxh128):)?[a-f0-9]+$/i")]
        public string Total_chunk_hash { get; set; } = default!;

        /// <summary>
        /// The total number of chunks attached to the session.
        /// </summary>

        [JsonPropertyName("total_chunks")]
        [System.ComponentModel.DataAnnotations.Range(int.MinValue, 10000)]
        public int Total_chunks { get; set; } = default!;
    }
}