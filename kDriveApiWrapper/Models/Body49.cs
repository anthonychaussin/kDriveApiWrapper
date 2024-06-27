namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The body49.
    /// </summary>
    public partial class Body49 : Data
    {
        /// <summary>
        /// Select what to do when a file with the same name already exists. The default conflict mode is error.&lt;li&gt;&lt;small&gt;&lt;ul&gt;&lt;strong&gt;error&lt;/strong&gt; : An error is returned without creating the file/session.&lt;/ul&gt;&lt;ul&gt;&lt;strong&gt;rename&lt;/strong&gt; : Rename the new file with an available name (ex. `file.txt` to `file (3).txt`).&lt;/ul&gt;&lt;/small&gt;&lt;/li&gt;
        /// </summary>

        [JsonPropertyName("conflict")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Body49Conflict Conflict { get; set; } = default!;

        /// <summary>
        /// Name of the File/Directory
        /// </summary>

        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
    }
}