namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The api exception.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ApiException"/> class.
    /// </remarks>
    /// <param name="message">The message.</param>
    /// <param name="statusCode">The status code.</param>
    /// <param name="response">The response.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="innerException">The inner exception.</param>

    public partial class ApiException(string message, int statusCode, string? response, IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception? innerException) : Exception(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + (response == null ? "(null)" : response[..(response.Length >= 512 ? 512 : response.Length)]), innerException)
    {
        /// <summary>
        /// Gets the status code.
        /// </summary>
        public int StatusCode { get; private set; } = statusCode;

        /// <summary>
        /// Gets the response.
        /// </summary>
        public string? Response { get; private set; } = response;

        /// <summary>
        /// Gets the headers.
        /// </summary>
        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; } = headers;

        /// <summary>
        /// Tos the string.
        /// </summary>
        /// <returns>A string.</returns>
        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    /// <summary>
    /// The api exception.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ApiException"/> class.
    /// </remarks>
    /// <param name="message">The message.</param>
    /// <param name="statusCode">The status code.</param>
    /// <param name="response">The response.</param>
    /// <param name="headers">The headers.</param>
    /// <param name="result">The result.</param>
    /// <param name="innerException">The inner exception.</param>
    public partial class ApiException<TResult>(string message, int statusCode, string? response, IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result, Exception? innerException) : ApiException(message, statusCode, response, headers, innerException)
    {
        /// <summary>
        /// Gets the result.
        /// </summary>
        public TResult Result { get; private set; } = result;
    }
}