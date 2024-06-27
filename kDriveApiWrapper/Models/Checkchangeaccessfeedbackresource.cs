namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The checkchangeaccessfeedbackresource.
    /// </summary>
    public partial class Checkchangeaccessfeedbackresource : Data
    {
        /// <summary>
        /// User identifier
        /// </summary>

        [JsonPropertyName("user_id")]
        public int User_id { get; set; } = default!;

        /// <summary>
        /// The current user right for the File/Directory
        /// </summary>

        [JsonPropertyName("current_right")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CheckchangeaccessfeedbackresourceCurrent_right Current_right { get; set; } = default!;

        /// <summary>
        /// If the right asked need to be applied to this user, return false if the right is the same level or not applicable.&lt;/br&gt; &lt;b&gt;Note:&lt;/b&gt; A user with limited file access don't need to change his right
        /// </summary>

        [JsonPropertyName("need_change")]
        public bool Need_change { get; set; } = default!;

        /// <summary>
        /// Additional information about why the right need to be applied or not : &lt;/br&gt;user_right_need_change: If the right need to be changed&lt;/br&gt;user_right_is_same_level: If the right is the same level&lt;/br&gt;user_not_connected_to_drive: If the user did not connected to the drive yet&lt;/br&gt;error: If the right cannot be changed for other reason
        /// </summary>

        [JsonPropertyName("message")]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CheckchangeaccessfeedbackresourceMessage Message { get; set; } = default!;
    }
}