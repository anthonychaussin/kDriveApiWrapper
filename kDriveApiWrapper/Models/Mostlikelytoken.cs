namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// most likely token and their log probability
    /// </summary>

    public partial class Mostlikelytoken : Data
    {
        /// <summary>
        /// The token.
        /// </summary>

        [JsonPropertyName("token")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be null if there is no bytes representation for the token.
        /// </summary>

        [JsonPropertyName("bytes")]
        public ICollection<int>? Bytes { get; set; } = default!;

        /// <summary>
        /// The log probability of this token
        /// </summary>

        [JsonPropertyName("logprob")]
        public double Logprob { get; set; } = default!;
    }
}