using kDriveApiWrapper.Models.Requests;

namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The client.
    /// </summary>

    public partial class Client : BaseClient
    {
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get File/Directory
        /// </summary>
        /// <remarks>
        /// Get File/Directory by file identifier.
        /// <br/>If you need to access the root directory, set the 'file_id' parameter to '1'; from there, you can navigate to other files and directories.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAsync(int drive_id, int file_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get files in directory
        /// </summary>
        /// <remarks>
        /// Get paginate children file/directory of specific directory (file identifier)
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesFilesAsync(int drive_id, int file_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous12>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, IEnumerable<FileTypeEnum>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/files"
                    var urlBuilder_ = new StringBuilder($"{BaseUrl}3/drive/{Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture))}/files/{Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture))}/files?");

                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (type != null)
                    {
                        foreach (var item_ in type) { urlBuilder_.Append(Uri.EscapeDataString("type")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Count element in directory
        /// </summary>
        /// <remarks>
        /// Get number of element in a directory by ID
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCountAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/count"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/count");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Create directory
        /// </summary>
        /// <remarks>
        /// Create directory in the specified directory (file identifier).
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesDirectoryAsync(int drive_id, int file_id, string? with = null, Body45? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/directory"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/directory");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Create default file
        /// </summary>
        /// <remarks>
        /// Create empty default file in the specified directory (file identifier).
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesFileAsync(int drive_id, int file_id, string? with = null, Body46? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/file"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/file");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Copy to Directory
        /// </summary>
        /// <remarks>
        /// Copy file to another directory.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="destination_directory_id">Destination Directory identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCopyAsync(int drive_id, int file_id, int destination_directory_id, string? with = null, Body47? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/copy/{destination_directory_id}"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/copy/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(destination_directory_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Duplicate
        /// </summary>
        /// <remarks>
        /// Duplicate file in the same directory
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesDuplicateAsync(int drive_id, int file_id, string? with = null, Body48? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/duplicate"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/duplicate");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Convert File
        /// </summary>
        /// <remarks>
        /// Convert file content
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesConvertAsync(int drive_id, int file_id, string? with = null, string? x_kdrive_file_password = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    if (x_kdrive_file_password != null)
                        request_.Headers.TryAddWithoutValidation("x-kdrive-file-password", ConvertToString(x_kdrive_file_password, CultureInfo.InvariantCulture));
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/convert"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/convert");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Move
        /// </summary>
        /// <remarks>
        /// Move a Directory or a File to a Directory
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="destination_directory_id">Destination Directory identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesMoveAsync(int drive_id, int file_id, int destination_directory_id, Body49? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/move/{destination_directory_id}"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/move/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(destination_directory_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// List
        /// </summary>
        /// <remarks>
        /// Get list of file versions
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="page">*Optional parameter* that define the page number&lt;br /&gt;
        /// <br/>Part of the `pagination` capacity</param>
        /// <param name="per_page">*Optional parameter* that define the number of items per page&lt;br /&gt;
        /// <br/>Part of the `pagination` capacity</param>
        /// <param name="total">If set to true, return the total number of items. Total pages (&lt;strong&gt;pages&lt;/strong&gt;) in response is also returned.
        /// <br/>&lt;note&gt;You can also use ?with=total parameter&lt;/note&gt;</param>
        /// <param name="order_by">*Optional parameter* that define the field used for sorting&lt;br /&gt;
        /// <br/>Part of the `sort` capacity</param>
        /// <param name="order">*Optional parameter* that define the default sort order&lt;br /&gt;
        /// <br/>Part of the `sort` capacity</param>
        /// <param name="order_for">*Optional parameter* that define the sorting order for a field&lt;br /&gt;
        /// <br/>By default **order** is used&lt;br /&gt;
        /// <br/>Part of the `sort` capacity</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesVersionsAsync(int drive_id, int file_id, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/versions"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/versions");
                    urlBuilder_.Append('?');
                    if (page != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("page")).Append('=').Append(Uri.EscapeDataString(ConvertToString(page, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (per_page != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("per_page")).Append('=').Append(Uri.EscapeDataString(ConvertToString(per_page, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (total != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("total")).Append('=').Append(Uri.EscapeDataString(ConvertToString(total, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order_by, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Restore
        /// </summary>
        /// <remarks>
        /// Restore a file version.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="version_id">Version identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesVersionsRestorePostAsync(int drive_id, int file_id, int version_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/versions/{version_id}/restore"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/versions/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(version_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/restore");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Restore to Directory
        /// </summary>
        /// <remarks>
        /// Restore a file version as a copy in target directory, keeping current original intact.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="version_id">Version identifier</param>
        /// <param name="destination_directory_id">Directory identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesVersionsRestorePostAsync(int drive_id, int file_id, int version_id, int destination_directory_id, string? with = null, Body50? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/versions/{version_id}/restore/{destination_directory_id}"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/versions/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(version_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/restore/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(destination_directory_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Search file/directory
        /// </summary>
        /// <remarks>
        /// Search files and directories with specific filters.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesSearchAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<SearchFileOrderParam>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, int? modified_after = null, Modified_at? modified_at = null, int? modified_before = null, string? query = null, IEnumerable<Anonymous19>? types = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/search"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/search");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (modified_after != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_after")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_after, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (modified_at != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_at")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_at, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (modified_before != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_before")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_before, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (query != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("query")).Append('=').Append(Uri.EscapeDataString(ConvertToString(query, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (types != null)
                    {
                        foreach (var item_ in types) { urlBuilder_.Append(Uri.EscapeDataString("types")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Search Dropbox
        /// </summary>
        /// <remarks>
        /// Search dropboxes with specific filters.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesSearchDropboxesAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<SearchFileOrderParam>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, int? author_id = null, string? category = null, int? created_after = null, Created_at? created_at = null, int? created_before = null, Expires? expires = null, Has_password? has_password = null, int? last_import_after = null, Last_import_at? last_import_at = null, int? last_import_before = null, string? query = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/search/dropboxes"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/search/dropboxes");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (author_id != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("author_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(author_id, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (category != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("category")).Append('=').Append(Uri.EscapeDataString(ConvertToString(category, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (created_after != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("created_after")).Append('=').Append(Uri.EscapeDataString(ConvertToString(created_after, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (created_at != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("created_at")).Append('=').Append(Uri.EscapeDataString(ConvertToString(created_at, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (created_before != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("created_before")).Append('=').Append(Uri.EscapeDataString(ConvertToString(created_before, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (expires != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("expires")).Append('=').Append(Uri.EscapeDataString(ConvertToString(expires, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (has_password != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("has_password")).Append('=').Append(Uri.EscapeDataString(ConvertToString(has_password, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (last_import_after != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("last_import_after")).Append('=').Append(Uri.EscapeDataString(ConvertToString(last_import_after, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (last_import_at != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("last_import_at")).Append('=').Append(Uri.EscapeDataString(ConvertToString(last_import_at, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (last_import_before != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("last_import_before")).Append('=').Append(Uri.EscapeDataString(ConvertToString(last_import_before, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (query != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("query")).Append('=').Append(Uri.EscapeDataString(ConvertToString(query, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Search Favorite
        /// </summary>
        /// <remarks>
        /// Search favorites with specific filters.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesSearchFavoritesAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<SearchFileOrderParam>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, int? author_id = null, string? category = null, DepthOption? depth = null, int? directory_id = null, IEnumerable<string>? extensions = null, int? modified_after = null, Anonymous27? modified_at = null, int? modified_before = null, string? name = null, string? query = null, IEnumerable<Anonymous28>? types = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/search/favorites"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/search/favorites");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (author_id != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("author_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(author_id, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (category != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("category")).Append('=').Append(Uri.EscapeDataString(ConvertToString(category, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (depth != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("depth")).Append('=').Append(Uri.EscapeDataString(ConvertToString(depth, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (directory_id != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("directory_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(directory_id, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (extensions != null)
                    {
                        foreach (var item_ in extensions) { urlBuilder_.Append(Uri.EscapeDataString("extensions")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (modified_after != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_after")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_after, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (modified_at != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_at")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_at, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (modified_before != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_before")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_before, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (name != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("name")).Append('=').Append(Uri.EscapeDataString(ConvertToString(name, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (query != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("query")).Append('=').Append(Uri.EscapeDataString(ConvertToString(query, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (types != null)
                    {
                        foreach (var item_ in types) { urlBuilder_.Append(Uri.EscapeDataString("types")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Search Sharelink
        /// </summary>
        /// <remarks>
        /// Search share links with specific filters.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesSearchLinksAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<SearchFileOrderParam>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, int? author_id = null, string? category = null, int? created_after = null, Anonymous32? created_at = null, int? created_before = null, Anonymous33? expires = null, Anonymous34? has_password = null, string? query = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/search/links"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/search/links");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (author_id != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("author_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(author_id, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (category != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("category")).Append('=').Append(Uri.EscapeDataString(ConvertToString(category, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (created_after != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("created_after")).Append('=').Append(Uri.EscapeDataString(ConvertToString(created_after, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (created_at != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("created_at")).Append('=').Append(Uri.EscapeDataString(ConvertToString(created_at, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (created_before != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("created_before")).Append('=').Append(Uri.EscapeDataString(ConvertToString(created_before, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (expires != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("expires")).Append('=').Append(Uri.EscapeDataString(ConvertToString(expires, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (has_password != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("has_password")).Append('=').Append(Uri.EscapeDataString(ConvertToString(has_password, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (query != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("query")).Append('=').Append(Uri.EscapeDataString(ConvertToString(query, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Search Shared
        /// </summary>
        /// <remarks>
        /// Search shared files with specific filters.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesSearchSharedWithMeAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<SearchFileOrderParam>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, int? author_id = null, string? category = null, DepthOption? depth = null, int? directory_id = null, IEnumerable<string>? extensions = null, int? modified_after = null, Anonymous39? modified_at = null, int? modified_before = null, string? name = null, string? query = null, IEnumerable<Anonymous40>? types = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/search/shared_with_me"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/search/shared_with_me");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (author_id != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("author_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(author_id, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (category != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("category")).Append('=').Append(Uri.EscapeDataString(ConvertToString(category, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (depth != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("depth")).Append('=').Append(Uri.EscapeDataString(ConvertToString(depth, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (directory_id != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("directory_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(directory_id, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (extensions != null)
                    {
                        foreach (var item_ in extensions) { urlBuilder_.Append(Uri.EscapeDataString("extensions")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (modified_after != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_after")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_after, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (modified_at != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_at")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_at, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (modified_before != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_before")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_before, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (name != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("name")).Append('=').Append(Uri.EscapeDataString(ConvertToString(name, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (query != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("query")).Append('=').Append(Uri.EscapeDataString(ConvertToString(query, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (types != null)
                    {
                        foreach (var item_ in types) { urlBuilder_.Append(Uri.EscapeDataString("types")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Search My Shared
        /// </summary>
        /// <remarks>
        /// Search my shared files with specific filters.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesSearchMySharedAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<SearchFileOrderParam>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, int? author_id = null, string? category = null, DepthOption? depth = null, int? directory_id = null, IEnumerable<string>? extensions = null, int? modified_after = null, Anonymous45? modified_at = null, int? modified_before = null, string? name = null, string? query = null, IEnumerable<Anonymous46>? types = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/search/my_shared"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/search/my_shared");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (author_id != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("author_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(author_id, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (category != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("category")).Append('=').Append(Uri.EscapeDataString(ConvertToString(category, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (depth != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("depth")).Append('=').Append(Uri.EscapeDataString(ConvertToString(depth, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (directory_id != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("directory_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(directory_id, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (extensions != null)
                    {
                        foreach (var item_ in extensions) { urlBuilder_.Append(Uri.EscapeDataString("extensions")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (modified_after != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_after")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_after, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (modified_at != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_at")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_at, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (modified_before != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("modified_before")).Append('=').Append(Uri.EscapeDataString(ConvertToString(modified_before, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (name != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("name")).Append('=').Append(Uri.EscapeDataString(ConvertToString(name, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (query != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("query")).Append('=').Append(Uri.EscapeDataString(ConvertToString(query, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (types != null)
                    {
                        foreach (var item_ in types) { urlBuilder_.Append(Uri.EscapeDataString("types")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Search TrashOption
        /// </summary>
        /// <remarks>
        /// Search trash with specific filters.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesSearchTrashAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<SearchFileOrderParam>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, int? author_id = null, string? category = null, int? deleted_after = null, Deleted_at? deleted_at = null, int? deleted_before = null, int? deleted_by = null, string? query = null, IEnumerable<Anonymous50>? types = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/search/trash"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/search/trash");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (author_id != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("author_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(author_id, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (category != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("category")).Append('=').Append(Uri.EscapeDataString(ConvertToString(category, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (deleted_after != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("deleted_after")).Append('=').Append(Uri.EscapeDataString(ConvertToString(deleted_after, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (deleted_at != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("deleted_at")).Append('=').Append(Uri.EscapeDataString(ConvertToString(deleted_at, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (deleted_before != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("deleted_before")).Append('=').Append(Uri.EscapeDataString(ConvertToString(deleted_before, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (deleted_by != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("deleted_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(deleted_by, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (query != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("query")).Append('=').Append(Uri.EscapeDataString(ConvertToString(query, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (types != null)
                    {
                        foreach (var item_ in types) { urlBuilder_.Append(Uri.EscapeDataString("types")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get drop-boxes
        /// </summary>
        /// <remarks>
        /// Get an array of all dropbox available in the drive.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesDropboxesAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous51>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, IEnumerable<FileTypeEnum>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/dropboxes"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/dropboxes");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (type != null)
                    {
                        foreach (var item_ in type) { urlBuilder_.Append(Uri.EscapeDataString("type")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get favorite files list
        /// </summary>
        /// <remarks>
        /// Return a list of favorite files
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesFavoritesAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous55>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, IEnumerable<FileTypeEnum>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/favorites"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/favorites");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (type != null)
                    {
                        foreach (var item_ in type) { urlBuilder_.Append(Uri.EscapeDataString("type")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get largest files
        /// </summary>
        /// <remarks>
        /// Get a paginated list of the largest files in the whole drive.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesLargestAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous59>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/largest"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/largest");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get last modified files
        /// </summary>
        /// <remarks>
        /// Get a paginated list of files last modified in the whole drive.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesLastModifiedAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous62>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/last_modified"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/last_modified");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get share-link files
        /// </summary>
        /// <remarks>
        /// Get list of File|Directory that has share link
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesLinksAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous65>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, IEnumerable<Anonymous68>? right = null, IEnumerable<FileTypeEnum>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/links"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/links");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (right != null)
                    {
                        foreach (var item_ in right) { urlBuilder_.Append(Uri.EscapeDataString("right")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (type != null)
                    {
                        foreach (var item_ in type) { urlBuilder_.Append(Uri.EscapeDataString("type")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get most versioned files
        /// </summary>
        /// <remarks>
        /// Get a paginated list of files most versioned in the whole drive.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesMostVersionsAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous70>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/most_versions"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/most_versions");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get my shared files
        /// </summary>
        /// <remarks>
        /// Get files that I shared
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesMySharedAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous73>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, IEnumerable<FileTypeEnum>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/my_shared"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/my_shared");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (type != null)
                    {
                        foreach (var item_ in type) { urlBuilder_.Append(Uri.EscapeDataString("type")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get shared files
        /// </summary>
        /// <remarks>
        /// Get shared files from given drive
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesSharedWithMeAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous77>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, IEnumerable<FileTypeEnum>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/shared_with_me"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/shared_with_me");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (type != null)
                    {
                        foreach (var item_ in type) { urlBuilder_.Append(Uri.EscapeDataString("type")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Create team directory
        /// </summary>
        /// <remarks>
        /// Create team directory.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesTeamDirectoryAsync(int drive_id, string? with = null, Body51? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/team_directory"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/team_directory");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// List the 5 more recent directories.
        /// </summary>
        /// <remarks>
        /// List the recent directories.
        /// </remarks>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesRecentsAsync(string drive_id, string? with = null, Type? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/recents"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/recents");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (type != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("type")).Append('=').Append(Uri.EscapeDataString(ConvertToString(type, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Build archive
        /// </summary>
        /// <remarks>
        /// Build an archive from selected files. The archive can then be downloaded using the &lt;a href="javascript:window.location = window.location.pathname.replace('post/3', 'get/2') + '/{archive_uuid}';"&gt;/2/drive/{drive_id}/files/archives/{archive_uuid}&lt;/a&gt; route.
        /// <br/>&lt;/br&gt;&lt;/br&gt;&lt;note&gt;
        /// <br/>The file identifiers should be in the same parent directory.
        /// <br/>&lt;/note&gt;
        /// <br/>&lt;/br&gt;&lt;note&gt;
        /// <br/>The archive should contain at least one file and may not contain more than 20,000 files.
        /// <br/>&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesArchivesAsync(int drive_id, Body52? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/archives"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/archives");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get files of trash
        /// </summary>
        /// <remarks>
        /// Get list of trashed files at the root of the trash
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveTrashGetAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<FileTypeEnum>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, IEnumerable<FileTypeEnum>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/trash"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/trash");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (type != null)
                    {
                        foreach (var item_ in type) { urlBuilder_.Append(Uri.EscapeDataString("type")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get trashed file
        /// </summary>
        /// <remarks>
        /// Get information of file/Directory from trash
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <param name="file_id">the file identifier</param>
        /// <param name="order_by">*Optional parameter* that define the field used for sorting&lt;br /&gt;
        /// <br/>Part of the `sort` capacity</param>
        /// <param name="order">*Optional parameter* that define the default sort order&lt;br /&gt;
        /// <br/>Part of the `sort` capacity</param>
        /// <param name="order_for">*Optional parameter* that define the sorting order for a field&lt;br /&gt;
        /// <br/>By default **order** is used&lt;br /&gt;
        /// <br/>Part of the `sort` capacity</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveTrashGetAsync(int drive_id, int file_id, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/trash/{file_id}"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/trash/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append('?');
                    if (order_by != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order_by, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Get files of trashed directory
        /// </summary>
        /// <remarks>
        /// Get paginate sub-file/sub-directory of trashed directory
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <param name="file_id">the file identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveTrashFilesAsync(int drive_id, int file_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous85>? order_by = null, Direction? order = null, IEnumerable<Direction>? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = new HttpMethod("GET") })
                {
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/trash/{file_id}/files"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/trash/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (cursor != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("cursor")).Append('=').Append(Uri.EscapeDataString(ConvertToString(cursor, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (limit != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("limit")).Append('=').Append(Uri.EscapeDataString(ConvertToString(limit, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_by != null)
                    {
                        foreach (var item_ in order_by) { urlBuilder_.Append(Uri.EscapeDataString("order_by")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (order != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("order")).Append('=').Append(Uri.EscapeDataString(ConvertToString(order, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (order_for != null)
                    {
                        foreach (var item_ in order_for) { urlBuilder_.Append(Uri.EscapeDataString("order_for")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Upload
        /// </summary>
        /// <remarks>
        /// Create a new file with the contents provided in the request.
        /// <br/>&lt;/br&gt;&lt;/br&gt;&lt;note&gt;
        /// <br/>Do not use this to upload a file larger than 1GB.
        /// <br/>Instead, create an &lt;a href="./upload/session/start"&gt;upload session and attach chunks&lt;/a&gt;.
        /// <br/>&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUploadAsync(int drive_id, int total_size, string? with = null, string? if_Match = null, string? client_token = null, Conflict? conflict = null, string? created_at = null, int? directory_id = null, string? directory_path = null, string? file_name = null, string? last_modified_at = null, string? symbolic_link = null, string? total_chunk_hash = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                        if (if_Match != null)
                            request_.Headers.TryAddWithoutValidation("If-Match", ConvertToString(if_Match, CultureInfo.InvariantCulture));
                        request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                        request_.Method = new HttpMethod("POST");
                        

                        var urlBuilder_ = new StringBuilder();
                        urlBuilder_.Append(BaseUrl);
                        // Operation Path: "3/drive/{drive_id}/upload"
                        urlBuilder_.Append("3/drive/");
                        urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                        urlBuilder_.Append("/upload");
                        urlBuilder_.Append('?');
                        urlBuilder_.Append(Uri.EscapeDataString("total_size")).Append('=').Append(Uri.EscapeDataString(ConvertToString(total_size, CultureInfo.InvariantCulture))).Append('&');
                        if (with != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                        }
                        if (client_token != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("client_token")).Append('=').Append(Uri.EscapeDataString(ConvertToString(client_token, CultureInfo.InvariantCulture))).Append('&');
                        }
                        if (conflict != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("conflict")).Append('=').Append(Uri.EscapeDataString(ConvertToString(conflict, CultureInfo.InvariantCulture))).Append('&');
                        }
                        if (created_at != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("created_at")).Append('=').Append(Uri.EscapeDataString(ConvertToString(created_at, CultureInfo.InvariantCulture))).Append('&');
                        }
                        if (directory_id != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("directory_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(directory_id, CultureInfo.InvariantCulture))).Append('&');
                        }
                        if (directory_path != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("directory_path")).Append('=').Append(Uri.EscapeDataString(ConvertToString(directory_path, CultureInfo.InvariantCulture))).Append('&');
                        }
                        if (file_name != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("file_name")).Append('=').Append(Uri.EscapeDataString(ConvertToString(file_name, CultureInfo.InvariantCulture))).Append('&');
                        }
                        if (last_modified_at != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("last_modified_at")).Append('=').Append(Uri.EscapeDataString(ConvertToString(last_modified_at, CultureInfo.InvariantCulture))).Append('&');
                        }
                        if (symbolic_link != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("symbolic_link")).Append('=').Append(Uri.EscapeDataString(ConvertToString(symbolic_link, CultureInfo.InvariantCulture))).Append('&');
                        }
                        if (total_chunk_hash != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("total_chunk_hash")).Append('=').Append(Uri.EscapeDataString(ConvertToString(total_chunk_hash, CultureInfo.InvariantCulture))).Append('&');
                        }
                        urlBuilder_.Length--;

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            
                            return await ProcessResponse(client_, response_, cancellationToken);
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Start session
        /// </summary>
        /// <remarks>
        /// Upload session allows you to upload a single file in one or more requests. It is the only way to upload a file larger than 1GB.
        /// <br/>This call creates a new upload session which can then be used to add the content of the file using &lt;a href="./{session_token}/chunk"&gt;upload/session/{session_token}/chunk&lt;/a&gt;. Finally, when all the data have been sent, you should call &lt;a href="./{session_token}/finish"&gt;upload/session/finish&lt;/a&gt; to close the session and save all the files in kDrive.
        /// <br/>&lt;br/&gt;&lt;br/&gt;&lt;note&gt;
        /// <br/>  You must use the value of upload_url given in the reply to perform your upload.
        /// <br/>&lt;/note&gt;
        /// <br/>&lt;br/&gt;&lt;note&gt;
        /// <br/>  The maximum size of a file for an upload session is 50 GB and the maximum size per chunk request is 1GB.
        /// <br/>&lt;/note&gt;
        /// <br/>&lt;br/&gt;&lt;note&gt;
        /// <br/>When a session is started, it can be used for a maximum of 12 hours.
        /// <br/>&lt;/note&gt;
        /// <br/>&lt;br/&gt;&lt;note&gt;
        /// <br/>You cannot send data with an &lt;a href="./start"&gt;upload/session/start&lt;/a&gt; or &lt;a href="./{session_token}/finish"&gt;upload/session/finish&lt;/a&gt; call, only with the &lt;a href="./{session_token}/chunk"&gt;upload/session/{session_token}/chunk&lt;/a&gt; request.
        /// <br/>&lt;/note&gt;
        /// <br/>&lt;br/&gt;&lt;note&gt;
        /// <br/>If your file is small (&lt;100MB) we recommend you to use the &lt;a href="../../upload"&gt;direct upload route&lt;/a&gt; to avoid multiple requests.&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUploadSessionStartAsync(int drive_id, string? with = null, string? if_Match = null, Body53? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                        if (if_Match != null)
                            request_.Headers.TryAddWithoutValidation("If-Match", ConvertToString(if_Match, CultureInfo.InvariantCulture));
                        var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                        var content_ = new ByteArrayContent(json_);
                        content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                        request_.Content = content_;
                        request_.Method = new HttpMethod("POST");
                        

                        var urlBuilder_ = new StringBuilder();
                        urlBuilder_.Append(BaseUrl);
                        // Operation Path: "3/drive/{drive_id}/upload/session/start"
                        urlBuilder_.Append("3/drive/");
                        urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                        urlBuilder_.Append("/upload/session/start");
                        urlBuilder_.Append('?');
                        if (with != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                        }
                        urlBuilder_.Length--;

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            
                            return await ProcessResponse(client_, response_, cancellationToken);
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Batch : start sessions
        /// </summary>
        /// <remarks>
        /// Batch of upload sessions allows you to start multiple sessions for multiples files in one request.
        /// <br/>Each input request is cast in the same way of &lt;a href="../start"&gt;upload/session/start&lt;/a&gt;.
        /// <br/>This call creates one or more upload(s) session(s) which can then be used to add the content of the file using &lt;a href="../{session_token}/chunk"&gt;upload/session/{session_token}/chunk&lt;/a&gt;.
        /// <br/>Finally, when all the data have been sent you should call &lt;a href="../{session_token}/finish"&gt;upload/session/{session_token}/finish&lt;/a&gt; or (&lt;a href="./finish"&gt;upload/session/batch/finish&lt;/a&gt;) to close the session(s) and save all the files in kDrive.
        /// <br/>&lt;br/&gt;&lt;br/&gt;&lt;note&gt;
        /// <br/>The maximum size of a file for an upload session is 50 GB and the maximum size per chunk request is 1GB.
        /// <br/>&lt;/note&gt;
        /// <br/>&lt;br/&gt;&lt;note&gt;
        /// <br/>When a session is started, it can be used for a maximum of 12 hours.
        /// <br/>&lt;/note&gt;
        /// <br/>&lt;br/&gt;&lt;note&gt;
        /// <br/>You cannot send data with an &lt;a href="../start"&gt;upload/session/start&lt;/a&gt; or &lt;a href="../{session_token}/finish"&gt;upload/session/finish&lt;/a&gt; call, only with the &lt;a href="../{session_token}/chunk"&gt;upload/session/{session_token}/chunk&lt;/a&gt; request.
        /// <br/>&lt;/note&gt;
        /// <br/>&lt;br/&gt;&lt;note&gt;
        /// <br/>The batch cannot exceed 1,000 sessions.
        /// <br/>&lt;/note&gt;
        /// <br/>&lt;br/&gt;&lt;note&gt;
        /// <br/>If your file is small (&lt;100MB) we recommend you to use the &lt;a href="../../"&gt;direct upload route&lt;/a&gt; to avoid multiple requests.
        /// <br/>&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUploadSessionBatchStartAsync(int drive_id, string? with = null, Body54? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                        var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                        var content_ = new ByteArrayContent(json_);
                        content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                        request_.Content = content_;
                        request_.Method = new HttpMethod("POST");
                        

                        var urlBuilder_ = new StringBuilder();
                        urlBuilder_.Append(BaseUrl);
                        // Operation Path: "3/drive/{drive_id}/upload/session/batch/start"
                        urlBuilder_.Append("3/drive/");
                        urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                        urlBuilder_.Append("/upload/session/batch/start");
                        urlBuilder_.Append('?');
                        if (with != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                        }
                        urlBuilder_.Length--;

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            
                            return await ProcessResponse(client_, response_, cancellationToken);
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Append chunk to session
        /// </summary>
        /// <remarks>
        /// Append more data to an upload session.
        /// <br/>&lt;br/&gt;&lt;br/&gt;&lt;note&gt;
        /// <br/>The maximum size per chunk request is 1GB.
        /// <br/>&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="session_token">Session token uuid</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUploadSessionChunkAsync(int drive_id, string session_token, int chunk_number, int chunk_size, string? chunk_hash = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                        request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                        request_.Method = new HttpMethod("POST");
                        

                        var urlBuilder_ = new StringBuilder();
                        urlBuilder_.Append(BaseUrl);
                        // Operation Path: "3/drive/{drive_id}/upload/session/{session_token}/chunk"
                        urlBuilder_.Append("3/drive/");
                        urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                        urlBuilder_.Append("/upload/session/");
                        urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(session_token, CultureInfo.InvariantCulture)));
                        urlBuilder_.Append("/chunk");
                        urlBuilder_.Append('?');
                        urlBuilder_.Append(Uri.EscapeDataString("chunk_number")).Append('=').Append(Uri.EscapeDataString(ConvertToString(chunk_number, CultureInfo.InvariantCulture))).Append('&');
                        urlBuilder_.Append(Uri.EscapeDataString("chunk_size")).Append('=').Append(Uri.EscapeDataString(ConvertToString(chunk_size, CultureInfo.InvariantCulture))).Append('&');
                        if (chunk_hash != null)
                        {
                            urlBuilder_.Append(Uri.EscapeDataString("chunk_hash")).Append('=').Append(Uri.EscapeDataString(ConvertToString(chunk_hash, CultureInfo.InvariantCulture))).Append('&');
                        }
                        urlBuilder_.Length--;

                        PrepareRequest(client_, request_, urlBuilder_);

                        var url_ = urlBuilder_.ToString();
                        request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                        PrepareRequest(client_, request_, url_);

                        var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                        var disposeResponse_ = true;
                        try
                        {
                            
                            return await ProcessResponse(client_, response_, cancellationToken);
                        }
                        finally
                        {
                            if (disposeResponse_)
                                response_.Dispose();
                        }
                    }
                }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Close session
        /// </summary>
        /// <remarks>
        /// Finish an upload session, verify and save the uploaded data to the kDrive.&lt;br/&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="session_token">Session token uuid</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUploadSessionFinishAsync(int drive_id, string session_token, string? with = null, Body55? body = null, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(session_token);

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/upload/session/{session_token}/finish"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/upload/session/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(session_token, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/finish");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Batch : close sessions
        /// </summary>
        /// <remarks>
        /// Finish one or more upload session, verify and save the uploaded data to the kDrive.&lt;br/&gt;
        /// <br/>&lt;br/&gt;&lt;note&gt;
        /// <br/>  The batch cannot exceed 1000 sessions.
        /// <br/>&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUploadSessionBatchFinishAsync(int drive_id, string? with = null, Body56? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Post })
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, JsonSerializerSettings);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    

                    var urlBuilder_ = new StringBuilder();
                    urlBuilder_.Append(BaseUrl);
                    // Operation Path: "3/drive/{drive_id}/upload/session/batch/finish"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/upload/session/batch/finish");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        
                        return await ProcessResponse(client_, response_, cancellationToken);
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }
    }
}