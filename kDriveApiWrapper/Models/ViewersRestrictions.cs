namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The viewers restrictions.
    /// </summary>
    public partial class ViewersRestrictions : Data
    {
        /// <summary>
        /// Unique identifier of the `restriction` that is related to the resource `ViewersRestrictions`
        /// </summary>

        [JsonPropertyName("restrictions_id")]
        public int Restrictions_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the access_country.
        /// </summary>
        [JsonPropertyName("access_country")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Access_country { get; set; } = default!;

        /// <summary>
        /// Gets or sets the allow_domain.
        /// </summary>
        [JsonPropertyName("allow_domain")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Allow_domain { get; set; } = default!;

        /// <summary>
        /// Gets or sets the exception_ip.
        /// </summary>
        [JsonPropertyName("exception_ip")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Exception_ip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the forbidden_ip.
        /// </summary>
        [JsonPropertyName("forbidden_ip")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Forbidden_ip { get; set; } = default!;

        /// <summary>
        /// Gets or sets the shared_key.
        /// </summary>
        [JsonPropertyName("shared_key")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Shared_key { get; set; } = default!;

        /// <summary>
        /// Gets or sets a value indicating whether authorize_country.
        /// </summary>
        [JsonPropertyName("authorize_country")]
        public bool Authorize_country { get; set; } = default!;

        /// <summary>
        /// Gets or sets the player_token.
        /// </summary>
        [JsonPropertyName("player_token")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Player_token { get; set; } = default!;
    }
}