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
    /// <param name="result">The result.</param>
    public partial class SwaggerResponse<TResult>(int statusCode, IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result) : SwaggerResponse(statusCode, headers)
    {
        /// <summary>
        /// Gets the result.
        /// </summary>
        public TResult Result { get; private set; } = result;
    }
}