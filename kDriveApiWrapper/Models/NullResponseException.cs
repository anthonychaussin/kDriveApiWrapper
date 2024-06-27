namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The null response exception.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="NullReferenceException"/> class.
    /// </remarks>
    /// <param name="status">The status.</param>
    /// <param name="response">The response.</param>
    /// <param name="headers">The headers.</param>
    public partial class NullResponseException(int status, string? response, IReadOnlyDictionary<string, IEnumerable<string>> headers) : ApiException("Response was null which was not expected.", status, response, headers, null)
    {
    }
}