namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The hls stream.
    /// </summary>
    public partial class HlsStream : Data
    {
        /// <summary>
        /// Unique identifier of the resource `HlsStream`
        /// </summary>

        [JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Universally unique identifier of the resource `HlsStream`
        /// </summary>

        [JsonPropertyName("uuid")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Uuid { get; set; } = default!;

        /// <summary>
        /// Define unique name used in url
        /// </summary>

        [JsonPropertyName("name")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The bitrates used in the `HlsStream`
        /// </summary>

        [JsonPropertyName("bitrates")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Bitrates { get; set; } = default!;

        /// <summary>
        /// The size of the buffer in the `HlsStream`
        /// </summary>

        [JsonPropertyName("buffer_size")]
        public int Buffer_size { get; set; } = default!;

        /// <summary>
        /// The size of the fragment in the `HlsStream` use for buffer size
        /// </summary>

        [JsonPropertyName("fragment_size")]
        public int Fragment_size { get; set; } = default!;

        /// <summary>
        /// Is hash restriction enabled?
        /// </summary>

        [JsonPropertyName("is_hash_restriction")]
        public bool Is_hash_restriction { get; set; } = default!;

        /// <summary>
        /// The hash key used for hash protection
        /// </summary>

        [JsonPropertyName("hash_key")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Hash_key { get; set; } = default!;

        /// <summary>
        /// The ip list allows to access to the hls stream
        /// </summary>

        [JsonPropertyName("ip_include_list")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Ip_include_list { get; set; } = default!;

        /// <summary>
        /// The ip list not allows to access to the hls stream
        /// </summary>

        [JsonPropertyName("ip_exclude_list")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Ip_exclude_list { get; set; } = default!;

        /// <summary>
        /// Define if the hls stream used the restriction rules
        /// </summary>

        [JsonPropertyName("is_allow_country")]
        public bool Is_allow_country { get; set; } = default!;

        /// <summary>
        /// The country list not allows to access to the hls stream
        /// </summary>

        [JsonPropertyName("country_list")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Country_list { get; set; } = default!;

        /// <summary>
        /// The public url for `HlsStream`
        /// </summary>

        [JsonPropertyName("url")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Is the `HlsStream` is online?
        /// </summary>

        [JsonPropertyName("is_up")]
        public bool Is_up { get; set; } = default!;

        /// <summary>
        /// The list of domains allow to access
        /// </summary>

        [JsonPropertyName("domains")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Domains { get; set; } = default!;

        /// <summary>
        /// The source `Stream` of the `HlsStream`
        /// </summary>

        [JsonPropertyName("source_id")]
        public int Source_id { get; set; } = default!;

        /// <summary>
        /// Timestamp `HlsStream` has been created
        /// </summary>

        [JsonPropertyName("created_at")]
        public int Created_at { get; set; } = default!;

        /// <summary>
        /// Timestamp `HlsStream` has been updated
        /// </summary>

        [JsonPropertyName("updated_at")]
        public int Updated_at { get; set; } = default!;
    }
}