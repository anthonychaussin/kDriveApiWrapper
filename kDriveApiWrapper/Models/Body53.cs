namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body53.
    /// </summary>
    public partial class Body53 : Data
    {
        /// <summary>
        /// Select what to do when a file with the same name already exists. The default conflict mode is error.&lt;li&gt;&lt;small&gt;&lt;ul&gt;&lt;strong&gt;error&lt;/strong&gt; : An error is returned without creating the file/session.&lt;/ul&gt;&lt;ul&gt;&lt;strong&gt;rename&lt;/strong&gt; : Rename the new file with an available name (ex. `file.txt` to `file(3).txt`).&lt;/ul&gt;&lt;ul&gt;&lt;strong&gt;version&lt;/strong&gt; : Replace the content of the existing file (create a new version of the file).&lt;/ul&gt;&lt;/small&gt;&lt;/li&gt;
        /// </summary>

        [JsonPropertyName("conflict")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body53Conflict Conflict { get; set; } = default!;

        /// <summary>
        /// Override the creation date metadata of the new file.
        /// </summary>

        [JsonPropertyName("created_at")]
        public string Created_at { get; set; } = default!;

        /// <summary>
        /// The directory destination root of the new file. Must be a directory.
        /// <br/>                        &lt;note&gt;If the identifier is unknown you can use only &lt;strong&gt;directory_path&lt;/strong&gt;.&lt;/note&gt;
        /// <br/>                        &lt;note&gt;The identifier &lt;strong&gt;1&lt;/strong&gt; is the user root folder.&lt;/note&gt;
        /// <br/>                        &lt;note&gt;Required without &lt;strong&gt;directory_path&lt;/strong&gt;&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("directory_id")]
        public int Directory_id { get; set; } = default!;

        /// <summary>
        /// The destination path of the new file. If the &lt;strong&gt; directory_id&lt;/strong&gt; is provided the directory path is used as a relative path, otherwise it will be used as an absolute path. The destination should be a directory.
        /// <br/>                        &lt;note&gt;If the directory path does not exist, folders are created automatically.&lt;/note&gt;
        /// <br/>                        &lt;note&gt;The path is a destination path, the file name should not be provided at the end.&lt;/note&gt;
        /// <br/>                        &lt;note&gt;Required without &lt;strong&gt;directory_id&lt;/strong&gt;.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("directory_path")]
        public string? Directory_path { get; set; } = default!;

        /// <summary>
        /// File identifier of uploaded file.
        /// <br/>                        &lt;note&gt;This is an alternative to replace a file by its identifier, if this mode is used &lt;strong&gt;file_name&lt;/strong&gt;, &lt;strong&gt;directory_id&lt;/strong&gt;, &lt;strong&gt;conflict&lt;/strong&gt; and &lt;strong&gt;directory_path&lt;/strong&gt; params are automatically computed and cannot be provided.&lt;/note&gt;
        /// <br/>                        &lt;note&gt;If you don't know the identifier, or you want to upload a new file, you should provide a filename and a directory destination.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("file_id")]
        public int File_id { get; set; } = default!;

        /// <summary>
        /// The name of the file to create.
        /// <br/>                        &lt;note&gt;Slashes will be replaced by colons.&lt;/note&gt;
        /// <br/>                        &lt;note&gt;Maximum bytes size is 255&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("file_name")]
        public string File_name { get; set; } = default!;

        /// <summary>
        /// Override the update date metadata of the new file.
        /// </summary>

        [JsonPropertyName("last_modified_at")]
        public string Last_modified_at { get; set; } = default!;

        /// <summary>
        /// The total number of chunks attached to the session.
        /// </summary>

        [JsonPropertyName("total_chunks")]
        [System.ComponentModel.DataAnnotations.Range(int.MinValue, 10000)]
        public int Total_chunks { get; set; } = default!;

        /// <summary>
        /// Expected total size of the file to upload. If the uploaded content does not match this size, an error will be returned.&lt;note&gt;the unit of size is defined in Bytes.&lt;/note&gt;
        /// </summary>

        [JsonPropertyName("total_size")]
        [System.ComponentModel.DataAnnotations.Range(1D, 10000000000000D)]
        public long Total_size { get; set; } = default!;
    }
}