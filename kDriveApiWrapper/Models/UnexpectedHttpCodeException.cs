namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The unexpected http code exception.
    /// </summary>
    public class UnexpectedHttpCodeException(int status, string? response, IReadOnlyDictionary<string, IEnumerable<string>> headers) : ApiException("The HTTP status code of the response was not expected (" + status + ").", status, response, headers, null)
    {
    }
}