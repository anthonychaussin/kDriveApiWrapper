namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The swagger response.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="SwaggerResponse"/> class.
    /// </remarks>
    /// <param name="statusCode">The status code.</param>
    /// <param name="headers">The headers.</param>
    public partial class SwaggerResponse(int statusCode, IReadOnlyDictionary<string, IEnumerable<string>> headers) : Data
    {
        /// <summary>
        /// Gets the status code.
        /// </summary>
        public int StatusCode { get; private set; } = statusCode;

        /// <summary>
        /// Gets the headers.
        /// </summary>
        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; } = headers;
    }
}