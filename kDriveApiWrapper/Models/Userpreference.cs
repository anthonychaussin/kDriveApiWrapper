namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The userpreference.
    /// </summary>
    public partial class Userpreference : Data
    {
        /// <summary>
        /// Layout density of user interface elements
        /// </summary>

        [JsonPropertyName("density")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UserpreferenceDensity Density { get; set; } = default!;

        /// <summary>
        /// Should lists sort by recent
        /// </summary>

        [JsonPropertyName("sort_recent_file")]
        public bool Sort_recent_file { get; set; } = default!;

        /// <summary>
        /// Date format
        /// </summary>

        [JsonPropertyName("date_format")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Date_format { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether use_shortcut.
        /// </summary>
        [JsonPropertyName("use_shortcut")]
        public bool Use_shortcut { get; set; } = default!;

        /// <summary>
        /// Drive identifier of default drive to open when none is explicitly chosen in url
        /// </summary>

        [JsonPropertyName("default_drive")]
        public int? Default_drive { get; set; } = default!;

        /// <summary>
        /// Identifiers of tutorials that were already played
        /// </summary>

        [JsonPropertyName("tutorials")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<int> Tutorials { get; set; } = [];

        /// <summary>
        /// Gets or sets the connected_app.
        /// </summary>
        [JsonPropertyName("connected_app")]
        [System.ComponentModel.DataAnnotations.Required]
        public ICollection<int> Connected_app { get; set; } = [];

        /// <summary>
        /// Gets or sets the list.
        /// </summary>
        [JsonPropertyName("list")]
        public List List { get; set; } = default!;
    }
}