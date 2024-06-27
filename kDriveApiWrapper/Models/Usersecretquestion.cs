namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The usersecretquestion.
    /// </summary>
    public partial class Usersecretquestion : Data
    {
        /// <summary>
        /// Gets or sets the secret_question_id.
        /// </summary>
        [JsonPropertyName("secret_question_id")]
        public int Secret_question_id { get; set; } = default!;

        /// <summary>
        /// Gets or sets the secret_answer.
        /// </summary>
        [JsonPropertyName("secret_answer")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Secret_answer { get; set; } = default!;
    }
}