namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// Diagnostic dns
    /// </summary>

    public partial class MailDiagnosticDns : Data
    {
        /// <summary>
        /// Has error
        /// <br/>
        /// <br/>
        /// </summary>

        [JsonPropertyName("has_error")]
        public bool Has_error { get; set; } = default!;
    }
}