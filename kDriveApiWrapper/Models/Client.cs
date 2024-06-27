namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The client.
    /// </summary>

    public partial class Client
    {
        private string _baseUrl = "/";
        private HttpClient _httpClient;
        private static Lazy<JsonSerializerOptions> _settings = new(CreateSerializerSettings, true);

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="httpClient">The http client.</param>
        public Client(HttpClient httpClient)
        {
            BaseUrl = "https://api.infomaniak.com";
            _httpClient = httpClient;
        }

        /// <summary>
        /// Creates the serializer settings.
        /// </summary>
        /// <returns>A JsonSerializerOptions.</returns>
        private static JsonSerializerOptions CreateSerializerSettings()
        {
            var settings = new JsonSerializerOptions();
            UpdateJsonSerializerSettings(settings);
            return settings;
        }

        /// <summary>
        /// Gets or sets the base url.
        /// </summary>
        public string BaseUrl
        {
            get { return _baseUrl; }
            set
            {
                _baseUrl = value;
                if (!string.IsNullOrEmpty(_baseUrl) && !_baseUrl.EndsWith('/'))
                    _baseUrl += '/';
            }
        }

        /// <summary>
        /// Gets the json serializer settings.
        /// </summary>
        public JsonSerializerOptions JsonSerializerSettings
        { get { return _settings.Value; } }

        /// <summary>
        /// Updates the json serializer settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        static partial void UpdateJsonSerializerSettings(JsonSerializerOptions settings);

        /// <summary>
        /// Prepares the request.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="request">The request.</param>
        /// <param name="url">The url.</param>
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url);

        /// <summary>
        /// Prepares the request.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="request">The request.</param>
        /// <param name="urlBuilder">The url builder.</param>
        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder);

        /// <summary>
        /// Processes the response.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="response">The response.</param>
        partial void ProcessResponse(HttpClient client, HttpResponseMessage response);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Accessible drives
        /// </summary>
        /// <remarks>
        /// List of accessible drive for the current connected user
        /// </remarks>
        /// <param name="account_id">Account identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <param name="page">*Optional parameter* that define the page number&lt;br /&gt;
        /// <br/>Part of the `pagination` capacity</param>
        /// <param name="per_page">*Optional parameter* that define the number of items per page&lt;br /&gt;
        /// <br/>Part of the `pagination` capacity</param>
        /// <param name="total">If set to true, return the total number of items. Total pages (&lt;strong&gt;pages&lt;/strong&gt;) in response is also returned.
        /// <br/>&lt;note&gt;You can also use ?with=total parameter&lt;/note&gt;</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response2>> TwoDriveGetAsync(int account_id, string? with = null, bool? in_maintenance = null, IEnumerable<Item>? maintenance_reasons = null, IEnumerable<int>? tags = null, int? page = null, int? per_page = null, bool? total = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Get })
                {
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive"
                    urlBuilder_.Append("2/drive");
                    urlBuilder_.Append('?');
                    urlBuilder_.Append(Uri.EscapeDataString("account_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(account_id, CultureInfo.InvariantCulture))).Append('&');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (in_maintenance != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("in_maintenance")).Append('=').Append(Uri.EscapeDataString(ConvertToString(in_maintenance, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (maintenance_reasons != null)
                    {
                        foreach (var item_ in maintenance_reasons) { urlBuilder_.Append(Uri.EscapeDataString("maintenance_reasons")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (tags != null)
                    {
                        foreach (var item_ in tags) { urlBuilder_.Append(Uri.EscapeDataString("tags")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
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
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response2>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response2>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response3>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response3>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get users
        /// </summary>
        /// <remarks>
        /// Get all the users of each drive
        /// </remarks>
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
        public virtual async Task<SwaggerResponse<Response4>> TwoDriveUsersGetAsync(string? search = null, IEnumerable<int>? user_ids = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Get })
                {
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/users"
                    urlBuilder_.Append("2/drive/users");
                    urlBuilder_.Append('?');
                    if (search != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("search")).Append('=').Append(Uri.EscapeDataString(ConvertToString(search, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (user_ids != null)
                    {
                        foreach (var item_ in user_ids) { urlBuilder_.Append(Uri.EscapeDataString("user_ids")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response4>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response4>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get Drives
        /// </summary>
        /// <remarks>
        /// List of accessible drive of a specific user
        /// </remarks>
        /// <param name="user_id">User identifier</param>
        /// <param name="account_id">The account identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <param name="page">*Optional parameter* that define the page number&lt;br /&gt;
        /// <br/>Part of the `pagination` capacity</param>
        /// <param name="per_page">*Optional parameter* that define the number of items per page&lt;br /&gt;
        /// <br/>Part of the `pagination` capacity</param>
        /// <param name="total">If set to true, return the total number of items. Total pages (&lt;strong&gt;pages&lt;/strong&gt;) in response is also returned.
        /// <br/>&lt;note&gt;You can also use ?with=total parameter&lt;/note&gt;</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response5>> TwoDriveUsersDrivesAsync(int user_id, int account_id, string? with = null, IEnumerable<Anonymous>? roles = null, IEnumerable<Anonymous2>? status = null, int? page = null, int? per_page = null, bool? total = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Get })
                {
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/users/{user_id}/drives"
                    urlBuilder_.Append("2/drive/users/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(user_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/drives?");
                    urlBuilder_.Append(Uri.EscapeDataString("account_id")).Append('=').Append(Uri.EscapeDataString(ConvertToString(account_id, CultureInfo.InvariantCulture))).Append('&');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (roles != null)
                    {
                        foreach (var item_ in roles) { urlBuilder_.Append(Uri.EscapeDataString("roles")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (status != null)
                    {
                        foreach (var item_ in status) { urlBuilder_.Append(Uri.EscapeDataString("status")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
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
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response5>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response5>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 404)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response6>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response6>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get user's preference
        /// </summary>
        /// <remarks>
        /// Get the user drive preference ex: notification, date-format, list order etc...
        /// </remarks>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response7>> TwoDrivePreferencesGetAsync(string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Get })
                {
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/preferences"
                    urlBuilder_.Append("2/drive/preferences");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response7>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response7>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Set user's preference
        /// </summary>
        /// <remarks>
        /// Update the user drive preference ex: notification, date-format, list order etc...
        /// </remarks>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response8>> TwoDrivePreferencesPatchAsync(Body? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PATCH");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/preferences"
                    urlBuilder_.Append("2/drive/preferences");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response8>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response8>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get
        /// </summary>
        /// <remarks>
        /// Returns all rights related to categories on drive
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response9>> TwoDriveCategoriesRightsGetAsync(int drive_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Get })
                {
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/categories/rights"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/categories/rights");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response9>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response9>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response10>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response10>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response11>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response11>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update/Create
        /// </summary>
        /// <remarks>
        /// Update or Create rights for categories
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response12>> TwoDriveCategoriesRightsPostAsync(int drive_id, Body2? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/categories/rights"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/categories/rights");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response12>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response12>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response13>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response13>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response14>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response14>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response15>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response15>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get All Categories
        /// </summary>
        /// <remarks>
        /// Return a list of all categories
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response16>> TwoDriveCategoriesGetAsync(int drive_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/categories"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/categories");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response16>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response16>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response17>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response17>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Create Category
        /// </summary>
        /// <remarks>
        /// Creates a new category with name and color
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response18>> TwoDriveCategoriesPostAsync(int drive_id, Body3? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/categories"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/categories");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response18>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response18>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response19>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response19>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Edit Category
        /// </summary>
        /// <remarks>
        /// Edits the name and color of a category by identifier
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <param name="category_id">Category Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response20>> TwoDriveCategoriesPutAsync(int drive_id, int category_id, Body4? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/categories/{category_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/categories/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(category_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response20>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response20>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response21>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response21>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Delete Category
        /// </summary>
        /// <remarks>
        /// Deletes a category by identifier
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <param name="category_id">Category Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response22>> TwoDriveCategoriesDeleteAsync(int drive_id, int category_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/categories/{category_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/categories/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(category_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response22>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response22>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response23>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response23>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Add Category on File
        /// </summary>
        /// <remarks>
        /// Add an existing Category on a file
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <param name="file_id">File Identifier</param>
        /// <param name="category_id">Category Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response24>> TwoDriveFilesCategoriesPostAsync(int drive_id, int file_id, int category_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/categories/{category_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/categories/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(category_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response24>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response24>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response25>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response25>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Remove Category on File
        /// </summary>
        /// <remarks>
        /// Remove a category on a file
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <param name="file_id">File Identifier</param>
        /// <param name="category_id">Category Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response26>> TwoDriveFilesCategoriesDeleteAsync(int drive_id, int file_id, int category_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/categories/{category_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/categories/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(category_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response26>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response26>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response27>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response27>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response28>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response28>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Remove Categories on File
        /// </summary>
        /// <remarks>
        /// Removes all categories on a file
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <param name="file_id">File Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response29>> TwoDriveFilesCategoriesDeleteAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/categories"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/categories");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response29>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response29>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response30>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response30>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Validates an AI generated Category
        /// </summary>
        /// <remarks>
        /// Validates the category as correct or incorrect, according to `valid` parameter.
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <param name="file_id">File Identifier</param>
        /// <param name="category_id">Category Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response31>> TwoDriveFilesCategoriesAiFeedbackAsync(int drive_id, int file_id, int category_id, Body5? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/categories/{category_id}/ai-feedback"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/categories/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(category_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/ai-feedback");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response31>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response31>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response32>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response32>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// List user in drive
        /// </summary>
        /// <remarks>
        /// List of `Users` by drive identifier
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response33>> TwoDriveAccountUserAsync(int drive_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/account/user"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/account/user");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response33>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response33>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get drive's settings
        /// </summary>
        /// <remarks>
        /// Get drive's settings
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response34>> TwoDriveSettingsAsync(int drive_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/settings"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/settings");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response34>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response34>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response35>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response35>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update IA settings
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response36>> TwoDriveSettingsAiAsync(int drive_id, Body6? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/settings/ai"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/settings/ai");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response36>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response36>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response37>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response37>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response38>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response38>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 404)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response39>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response39>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 417)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response40>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response40>("Response", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response41>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response41>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response42>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response42>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update ShareLink settings
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response43>> TwoDriveSettingsLinkAsync(int drive_id, Body7? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/settings/link"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/settings/link");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response43>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response43>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response44>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response44>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 404)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response45>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response45>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response46>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response46>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response47>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response47>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update trash settings
        /// </summary>
        /// <remarks>
        /// Update the trash settings, including the retention period of trashed files
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response48>> TwoDriveSettingsTrashAsync(int drive_id, Body8? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/settings/trash"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/settings/trash");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response48>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response48>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response49>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response49>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 404)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response50>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response50>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response51>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response51>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response52>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response52>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update Drive
        /// </summary>
        /// <remarks>
        /// Update Drive from a Drive identifier
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response53>> TwoDrivePutAsync(int drive_id, Body9? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response53>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response53>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response54>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response54>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get users
        /// </summary>
        /// <remarks>
        /// Get all users in a drive
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
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
        public virtual async Task<SwaggerResponse<Response55>> TwoDriveUsersGetAsync(int drive_id, string? with = null, string? search = null, IEnumerable<Anonymous3>? status = null, IEnumerable<Anonymous4>? types = null, IEnumerable<int>? user_ids = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/users"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/users");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (search != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("search")).Append('=').Append(Uri.EscapeDataString(ConvertToString(search, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (status != null)
                    {
                        foreach (var item_ in status) { urlBuilder_.Append(Uri.EscapeDataString("status")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (types != null)
                    {
                        foreach (var item_ in types) { urlBuilder_.Append(Uri.EscapeDataString("types")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (user_ids != null)
                    {
                        foreach (var item_ in user_ids) { urlBuilder_.Append(Uri.EscapeDataString("user_ids")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response55>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response55>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Create user
        /// </summary>
        /// <remarks>
        /// Create a new user resource
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <param name="lang">Override the language of the request, in most cases when an e-mail is triggered in the request.</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response56>> TwoDriveUsersPostAsync(int drive_id, string? with = null, Lang? lang = null, Body10? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/users"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/users");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (lang != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("lang")).Append('=').Append(Uri.EscapeDataString(ConvertToString(lang, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response56>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response56>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response57>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response57>("One email or user at least required", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response58>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response58>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get user
        /// </summary>
        /// <remarks>
        /// Returns a user resource. When no resource is found, the data is empty.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response59>> TwoDriveUsersGetAsync(int drive_id, int user_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/users/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(user_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response59>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response59>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response60>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response60>("User not associated with drive", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response61>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response61>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update user
        /// </summary>
        /// <remarks>
        /// Update an existing user resource
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response62>> TwoDriveUsersPutAsync(int drive_id, int user_id, Body11? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/users/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(user_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response62>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response62>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response63>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response63>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Delete user
        /// </summary>
        /// <remarks>
        /// Deletes a drive user resource. Also removes all access, share links and invitations associated with the user.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response64>> TwoDriveUsersDeleteAsync(int drive_id, int user_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/users/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(user_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response64>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response64>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response65>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response65>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update user manager right
        /// </summary>
        /// <remarks>
        /// Update the role in the manager
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response66>> TwoDriveUsersManagerAsync(int drive_id, int user_id, Body12? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PATCH");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}/manager"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/users/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(user_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/manager");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response66>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response66>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response67>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response67>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Lock user
        /// </summary>
        /// <remarks>
        /// Sets status to locked, preventing access to drive.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response68>> TwoDriveUsersLockAsync(int drive_id, int user_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}/lock"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/users/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(user_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/lock");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response68>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response68>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response69>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response69>("User not associated with drive", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response70>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response70>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Unlock user
        /// </summary>
        /// <remarks>
        /// Sets status to active, restoring access to drive.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response71>> TwoDriveUsersUnlockAsync(int drive_id, int user_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}/unlock"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/users/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(user_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/unlock");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response71>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response71>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response72>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response72>("User not associated with drive", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response73>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response73>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// List reports
        /// </summary>
        /// <remarks>
        /// List of activity reports.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
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
        public virtual async Task<SwaggerResponse<Response76>> TwoDriveActivitiesReportsGetAsync(int drive_id, string? with = null, IEnumerable<int>? users = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/activities/reports"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/activities/reports");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (users != null)
                    {
                        foreach (var item_ in users) { urlBuilder_.Append(Uri.EscapeDataString("users")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response76>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response76>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response77>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response77>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Create report
        /// </summary>
        /// <remarks>
        /// Create a new report.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="lang">Override the language of the request, in most cases when an e-mail is triggered in the request.</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response78>> TwoDriveActivitiesReportsPostAsync(int drive_id, Lang3? lang = null, Body13? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/activities/reports"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/activities/reports");
                    urlBuilder_.Append('?');
                    if (lang != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("lang")).Append('=').Append(Uri.EscapeDataString(ConvertToString(lang, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response78>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response78>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response79>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response79>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get report
        /// </summary>
        /// <remarks>
        /// Get activity report.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="report_id">Report identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <param name="page">*Optional parameter* that define the page number&lt;br /&gt;
        /// <br/>Part of the `pagination` capacity</param>
        /// <param name="per_page">*Optional parameter* that define the number of items per page&lt;br /&gt;
        /// <br/>Part of the `pagination` capacity</param>
        /// <param name="total">If set to true, return the total number of items. Total pages (&lt;strong&gt;pages&lt;/strong&gt;) in response is also returned.
        /// <br/>&lt;note&gt;You can also use ?with=total parameter&lt;/note&gt;</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response80>> TwoDriveActivitiesReportsGetAsync(int drive_id, int report_id, string? with = null, int? page = null, int? per_page = null, bool? total = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/activities/reports/{report_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/activities/reports/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(report_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
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
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response80>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response80>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response81>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response81>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Delete report
        /// </summary>
        /// <remarks>
        /// Delete report.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="report_id">Report identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response82>> TwoDriveActivitiesReportsDeleteAsync(int drive_id, int report_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/activities/reports/{report_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/activities/reports/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(report_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response82>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response82>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response83>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response83>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 404)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response84>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response84>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response85>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response85>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Export report
        /// </summary>
        /// <remarks>
        /// Download/Export report.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="report_id">Report identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> TwoDriveActivitiesReportsExportAsync(int drive_id, int report_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/csv"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/activities/reports/{report_id}/export"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/activities/reports/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(report_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/export");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<string>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<string>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response86>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response86>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response87>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response87>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Chart : files size
        /// </summary>
        /// <remarks>
        /// Chart data, list files size value over time
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response88>> TwoDriveStatisticsSizesAsync(int drive_id, int from, int interval, IEnumerable<Anonymous6> metrics, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/statistics/sizes"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/statistics/sizes");
                    urlBuilder_.Append('?');
                    urlBuilder_.Append(Uri.EscapeDataString("from")).Append('=').Append(Uri.EscapeDataString(ConvertToString(from, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("interval")).Append('=').Append(Uri.EscapeDataString(ConvertToString(interval, CultureInfo.InvariantCulture))).Append('&');
                    foreach (var item_ in metrics) { urlBuilder_.Append(Uri.EscapeDataString("metrics")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    urlBuilder_.Append(Uri.EscapeDataString("until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(until, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response88>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response88>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response89>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response89>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response90>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response90>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Export : files size
        /// </summary>
        /// <remarks>
        /// Exports sizes statistics as csv file
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> TwoDriveStatisticsSizesExportAsync(int drive_id, int from, int interval, IEnumerable<Anonymous7> metrics, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/csv"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/statistics/sizes/export"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/statistics/sizes/export");
                    urlBuilder_.Append('?');
                    urlBuilder_.Append(Uri.EscapeDataString("from")).Append('=').Append(Uri.EscapeDataString(ConvertToString(from, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("interval")).Append('=').Append(Uri.EscapeDataString(ConvertToString(interval, CultureInfo.InvariantCulture))).Append('&');
                    foreach (var item_ in metrics) { urlBuilder_.Append(Uri.EscapeDataString("metrics")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    urlBuilder_.Append(Uri.EscapeDataString("until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(until, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<string>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<string>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response91>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response91>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response92>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response92>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Activities : Users
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response93>> TwoDriveStatisticsActivitiesUsersAsync(int drive_id, int from, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/statistics/activities/users"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/statistics/activities/users");
                    urlBuilder_.Append('?');
                    urlBuilder_.Append(Uri.EscapeDataString("from")).Append('=').Append(Uri.EscapeDataString(ConvertToString(from, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(until, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response93>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response93>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response94>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response94>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Activities : Shared files
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response95>> TwoDriveStatisticsActivitiesSharedFilesAsync(int drive_id, int from, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/statistics/activities/shared_files"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/statistics/activities/shared_files");
                    urlBuilder_.Append('?');
                    urlBuilder_.Append(Uri.EscapeDataString("from")).Append('=').Append(Uri.EscapeDataString(ConvertToString(from, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(until, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response95>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response95>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response96>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response96>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Chart : Activities
        /// </summary>
        /// <remarks>
        /// Chart data of activities metrics over time
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response97>> TwoDriveStatisticsActivitiesAsync(int drive_id, int from, int interval, Metric metric, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/statistics/activities"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/statistics/activities");
                    urlBuilder_.Append('?');
                    urlBuilder_.Append(Uri.EscapeDataString("from")).Append('=').Append(Uri.EscapeDataString(ConvertToString(from, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("interval")).Append('=').Append(Uri.EscapeDataString(ConvertToString(interval, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("metric")).Append('=').Append(Uri.EscapeDataString(ConvertToString(metric, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(until, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response97>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response97>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response98>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response98>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Export : Activities
        /// </summary>
        /// <remarks>
        /// Exports activities statistics
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> TwoDriveStatisticsActivitiesExportAsync(int drive_id, int from, int interval, Anonymous8 metric, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/csv"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/statistics/activities/export"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/statistics/activities/export");
                    urlBuilder_.Append('?');
                    urlBuilder_.Append(Uri.EscapeDataString("from")).Append('=').Append(Uri.EscapeDataString(ConvertToString(from, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("interval")).Append('=').Append(Uri.EscapeDataString(ConvertToString(interval, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("metric")).Append('=').Append(Uri.EscapeDataString(ConvertToString(metric, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(until, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Length--;

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<string>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<string>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response99>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response99>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Activities : ShareLinks
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
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
        public virtual async Task<SwaggerResponse<Response100>> TwoDriveStatisticsActivitiesLinksAsync(int drive_id, int from, int until, string? with = null, int? max_view = null, int? min_view = null, IEnumerable<Anonymous9>? rights = null, string? search = null, string? valid_until = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/statistics/activities/links"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/statistics/activities/links");
                    urlBuilder_.Append('?');
                    urlBuilder_.Append(Uri.EscapeDataString("from")).Append('=').Append(Uri.EscapeDataString(ConvertToString(from, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(until, CultureInfo.InvariantCulture))).Append('&');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (max_view != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("max_view")).Append('=').Append(Uri.EscapeDataString(ConvertToString(max_view, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (min_view != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("min_view")).Append('=').Append(Uri.EscapeDataString(ConvertToString(min_view, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (rights != null)
                    {
                        foreach (var item_ in rights) { urlBuilder_.Append(Uri.EscapeDataString("rights")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (search != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("search")).Append('=').Append(Uri.EscapeDataString(ConvertToString(search, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (valid_until != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("valid_until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(valid_until, CultureInfo.InvariantCulture))).Append('&');
                    }
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response100>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response100>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response101>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response101>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Export : ShareLinks Activities
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response102>> TwoDriveStatisticsActivitiesLinksExportAsync(int drive_id, int from, int until, int? max_view = null, int? min_view = null, IEnumerable<Anonymous10>? rights = null, string? valid_until = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/statistics/activities/links/export"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/statistics/activities/links/export");
                    urlBuilder_.Append('?');
                    urlBuilder_.Append(Uri.EscapeDataString("from")).Append('=').Append(Uri.EscapeDataString(ConvertToString(from, CultureInfo.InvariantCulture))).Append('&');
                    urlBuilder_.Append(Uri.EscapeDataString("until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(until, CultureInfo.InvariantCulture))).Append('&');
                    if (max_view != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("max_view")).Append('=').Append(Uri.EscapeDataString(ConvertToString(max_view, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (min_view != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("min_view")).Append('=').Append(Uri.EscapeDataString(ConvertToString(min_view, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (rights != null)
                    {
                        foreach (var item_ in rights) { urlBuilder_.Append(Uri.EscapeDataString("rights")).Append('=').Append(Uri.EscapeDataString(ConvertToString(item_, CultureInfo.InvariantCulture))).Append('&'); }
                    }
                    if (valid_until != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("valid_until")).Append('=').Append(Uri.EscapeDataString(ConvertToString(valid_until, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response102>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response102>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response103>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response103>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update Preferences
        /// </summary>
        /// <remarks>
        /// Updates the connected user preference for a drive.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response104>> TwoDrivePreferencesPutAsync(int drive_id, Body14? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/preferences"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/preferences");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response104>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response104>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response105>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response105>("User not associated with drive", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response106>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response106>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Undo action
        /// </summary>
        /// <remarks>
        /// Cancel an action with a token or cancel actions with tokens.
        /// <br/>An action token is a token returned with a CancelResource.
        /// <br/>Used in bulk processes or specific actions like renaming a file.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response132>> TwoDriveCancelAsync(int drive_id, Body19? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/cancel"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/cancel");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response132>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response132>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 404)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response133>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response133>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response134>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response134>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get requested file access from its id
        /// </summary>
        /// <remarks>
        /// Show a given requested file access
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="request_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response135>> TwoDriveAccessRequestsAsync(int drive_id, int request_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/access/requests/{request_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/requests/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(request_id, CultureInfo.InvariantCulture)));
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response135>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response135>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response136>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response136>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Trash
        /// </summary>
        /// <remarks>
        /// Trash a file, move it to the trash can.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response141>> TwoDriveFilesAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response141>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response141>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response142>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response142>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Favorite file
        /// </summary>
        /// <remarks>
        /// Add a file in the favorites
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response143>> TwoDriveFilesFavoritePostAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/favorite"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/favorite");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response143>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response143>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response144>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response144>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Download
        /// </summary>
        /// <remarks>
        /// Download file content or directory as Zip file.
        /// <br/>
        /// <br/>&lt;note&gt;
        /// <br/>Please note that this may respond a 302 to actually download the requested content.
        /// <br/>&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> TwoDriveFilesDownloadAsync(int drive_id, int file_id, As? @as = null, string? x_kdrive_file_password = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    if (x_kdrive_file_password != null)
                        request_.Headers.TryAddWithoutValidation("x-kdrive-file-password", ConvertToString(x_kdrive_file_password, CultureInfo.InvariantCulture));
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/download"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/download");
                    urlBuilder_.Append('?');
                    if (@as != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("as")).Append('=').Append(Uri.EscapeDataString(ConvertToString(@as, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<string>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<string>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response151>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response151>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response152>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response152>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Rename
        /// </summary>
        /// <remarks>
        /// Rename a file/directory
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response153>> TwoDriveFilesRenameAsync(int drive_id, int file_id, Body20? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/rename"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/rename");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response153>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response153>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response154>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response154>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response155>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response155>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response156>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response156>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get size
        /// </summary>
        /// <remarks>
        /// Get the size and storage_size of the File/Directory with children, up to $depth.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response157>> TwoDriveFilesSizesAsync(int drive_id, int file_id, Anonymous11? depth = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/sizes"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/sizes");
                    urlBuilder_.Append('?');
                    if (depth != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("depth")).Append('=').Append(Uri.EscapeDataString(ConvertToString(depth, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response157>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response157>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response158>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response158>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response159>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response159>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Hash
        /// </summary>
        /// <remarks>
        /// Get file hash.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response160>> TwoDriveFilesHashAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/hash"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/hash");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response160>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response160>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response161>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response161>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response162>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response162>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response163>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response163>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Copy to Drive
        /// </summary>
        /// <remarks>
        /// Copy source file in source drive to destination drive at destination folder.
        /// </remarks>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response164>> TwoDriveFilesCopyToDriveAsync(string drive_id, string file_id, Body21? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/copy-to-drive"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/copy-to-drive");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response164>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response164>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response165>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response165>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get a Temporary URL
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response166>> TwoDriveFilesTemporaryUrlAsync(int drive_id, int file_id, int? duration = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/temporary_url"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/temporary_url");
                    urlBuilder_.Append('?');
                    if (duration != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("duration")).Append('=').Append(Uri.EscapeDataString(ConvertToString(duration, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response166>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response166>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response167>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response167>("Cannot get a temporary url for a directory", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response168>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response168>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response169>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response169>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Delete all
        /// </summary>
        /// <remarks>
        /// Delete all version for file.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response174>> TwoDriveFilesVersionsDeleteAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/versions");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);
                        return await GetObjectResponse(response_, headers_, cancellationToken).ConfigureAwait(false);
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

        /// <summary>
        /// Gets the object response.
        /// </summary>
        /// <param name="response_">The response_.</param>
        /// <param name="headers_">The headers_.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task.</returns>
        private async Task<SwaggerResponse<Response174>> GetObjectResponse(HttpResponseMessage response_, Dictionary<String, IEnumerable<String>> headers_, CancellationToken cancellationToken)
        {
            var status_ = (int)response_.StatusCode;
            switch (status_)
            {
                case 200:
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<Response174>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        CheckNullResponse(status_, objectResponse_, headers_);

                        return new SwaggerResponse<Response174>(status_, headers_, objectResponse_.Object);
                    }

                case 400:
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<Response167>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        CheckNullResponse(status_, objectResponse_, headers_);

                        throw new ApiException<Response167>("Cannot get a temporary url for a directory", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }

                case 403:
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<Response175>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        CheckNullResponse(status_, objectResponse_, headers_);

                        throw new ApiException<Response175>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }

                case 500:
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<Response176>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        CheckNullResponse(status_, objectResponse_, headers_);

                        throw new ApiException<Response176>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }

                case 503:
                    {
                        var objectResponse_ = await ReadObjectResponseAsync<Response177>(response_, headers_, cancellationToken).ConfigureAwait(false);
                        CheckNullResponse(status_, objectResponse_, headers_);

                        throw new ApiException<Response177>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }

                default:
                    {
                        var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                    }
            }
        }

        /// <summary>
        /// Checks the null response.
        /// </summary>
        /// <param name="status_">The status_.</param>
        /// <param name="objectResponse_">The object response_.</param>
        /// <param name="headers_">The headers_.</param>
        private static void CheckNullResponse<T>(Int32 status_, ObjectResponseResult<T> objectResponse_, Dictionary<String, IEnumerable<String>> headers_)
        {
            if (objectResponse_.Object == null)
            {
                throw new NullResponseException(status_, objectResponse_.Text, headers_);
            }
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>
        /// Update
        /// </summary>
        /// <remarks>
        /// Update current file version
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response178>> TwoDriveFilesVersionsCurrentAsync(int drive_id, int file_id, Body22? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions/current"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/versions/current");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response178>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response178>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response179>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response179>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response180>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response180>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response181>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response181>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get
        /// </summary>
        /// <remarks>
        /// Get file version information.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="version_id">Version identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response182>> TwoDriveFilesVersionsGetAsync(int drive_id, int file_id, int version_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions/{version_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/versions/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(version_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response182>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response182>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response183>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response183>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response184>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response184>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response185>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response185>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update
        /// </summary>
        /// <remarks>
        /// Update file version
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="version_id">Version identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response186>> TwoDriveFilesVersionsPutAsync(int drive_id, int file_id, int version_id, Body23? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions/{version_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/versions/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(version_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response186>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response186>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response187>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response187>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response188>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response188>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response189>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response189>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Delete
        /// </summary>
        /// <remarks>
        /// Delete a file version.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="version_id">Version identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response190>> TwoDriveFilesVersionsDeleteAsync(int drive_id, int file_id, int version_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions/{version_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/versions/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(version_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response190>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response190>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response191>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response191>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response192>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response192>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response193>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response193>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Download
        /// </summary>
        /// <remarks>
        /// Download file version.
        /// <br/>
        /// <br/>&lt;note&gt;
        /// <br/>Please note that this may respond a 302 to actually download the requested content.
        /// <br/>&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="version_id">Version identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> TwoDriveFilesVersionsDownloadAsync(int drive_id, int file_id, int version_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions/{version_id}/download"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/versions/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(version_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/download");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<string>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<string>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response194>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response194>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response195>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response195>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response196>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response196>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get requested file access from a file id
        /// </summary>
        /// <remarks>
        /// Show requested file access for a given file
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response203>> TwoDriveFilesAccessRequestsGetAsync(int drive_id, int file_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/requests"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/requests");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response203>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response203>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response204>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response204>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Create a new file access request
        /// </summary>
        /// <remarks>
        /// Create a new file access request
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response205>> TwoDriveFilesAccessRequestsPostAsync(int drive_id, int file_id, string? with = null, Body25? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/requests"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/requests");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response205>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response205>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response206>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response206>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get multi-access
        /// </summary>
        /// <remarks>
        /// Show access file information
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response207>> TwoDriveFilesAccessGetAsync(int drive_id, int file_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response207>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response207>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response208>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response208>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response209>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response209>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response210>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response210>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Add multi-access
        /// </summary>
        /// <remarks>
        /// Add multi-access to file
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <param name="lang">Override the language of the request, in most cases when an e-mail is triggered in the request.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response211>> TwoDriveFilesAccessPostAsync(int drive_id, int file_id, string? with = null, Lang4? lang = null, Body26? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (lang != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("lang")).Append('=').Append(Uri.EscapeDataString(ConvertToString(lang, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response211>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response211>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response212>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response212>("Permission denied", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response213>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response213>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response214>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response214>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Check access change
        /// </summary>
        /// <remarks>
        /// Analyzes each user that has access to the drive by team, email or user identifier.
        /// <br/>This method tries to find users for the given inputs:&lt;/br&gt;
        /// <br/>&gt; The emails are parsed to user identifiers if possible.&lt;/br&gt;
        /// <br/>&gt; The teams identifiers are parsed to multiple user identifiers.&lt;/br&gt;
        /// <br/>&gt; The users identifiers are parsed accordingly.&lt;/br&gt;&lt;/br&gt;
        /// <br/>A right is required to simulate if a user needs to change their permissions to match it.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response215>> TwoDriveFilesAccessCheckAsync(int drive_id, int file_id, Body27? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/check"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/check");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response215>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response215>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response216>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response216>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Invitation &gt; get access
        /// </summary>
        /// <remarks>
        /// Show invitation send and that has access to the File|Directory, pending and accepted invitation
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response217>> TwoDriveFilesAccessInvitationsGetAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/invitations"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/invitations");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response217>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response217>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response218>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response218>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Add access
        /// </summary>
        /// <remarks>
        /// Give access to the File|Directory by email
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <param name="lang">Override the language of the request, in most cases when an e-mail is triggered in the request.</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response219>> TwoDriveFilesAccessInvitationsPostAsync(int drive_id, int file_id, string? with = null, Lang5? lang = null, Body28? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/invitations"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/invitations");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (lang != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("lang")).Append('=').Append(Uri.EscapeDataString(ConvertToString(lang, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response219>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response219>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response220>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response220>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response221>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response221>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Check access
        /// </summary>
        /// <remarks>
        /// Check if an invitation exists or a drive invitation is currently pending
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response222>> TwoDriveFilesAccessInvitationsCheckAsync(int drive_id, int file_id, Body29? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/invitations/check"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/invitations/check");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response222>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response222>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response223>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response223>("Permission denied", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response224>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response224>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response225>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response225>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get access
        /// </summary>
        /// <remarks>
        /// Show team that has access to the File|Directory
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response226>> TwoDriveFilesAccessTeamsGetAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/teams"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/teams");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response226>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response226>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response227>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response227>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response228>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response228>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Add access
        /// </summary>
        /// <remarks>
        /// Give teams access to the File|Directory
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <param name="lang">Override the language of the request, in most cases when an e-mail is triggered in the request.</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response229>> TwoDriveFilesAccessTeamsPostAsync(int drive_id, int file_id, string? with = null, Lang6? lang = null, Body30? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/teams"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/teams");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (lang != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("lang")).Append('=').Append(Uri.EscapeDataString(ConvertToString(lang, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response229>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response229>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response230>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response230>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response231>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response231>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update access
        /// </summary>
        /// <remarks>
        /// Update the access permission of a team access
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="team_id">Team identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response232>> TwoDriveFilesAccessTeamsPutAsync(int drive_id, int file_id, int team_id, Body31? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/teams/{team_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/teams/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(team_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response232>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response232>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response233>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response233>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response234>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response234>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response235>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response235>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Remove access
        /// </summary>
        /// <remarks>
        /// Delete the access permission of a team access
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="team_id">Team identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response236>> TwoDriveFilesAccessTeamsDeleteAsync(int drive_id, int file_id, int team_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/teams/{team_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/teams/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(team_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response236>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response236>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response237>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response237>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response238>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response238>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response239>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response239>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// get access
        /// </summary>
        /// <remarks>
        /// Show user that has access to the File|Directory
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response240>> TwoDriveFilesAccessUsersGetAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/users"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/users");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response240>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response240>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response241>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response241>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response242>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response242>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// add access
        /// </summary>
        /// <remarks>
        /// Give users access to the File|Directory
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <param name="lang">Override the language of the request, in most cases when an e-mail is triggered in the request.</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response243>> TwoDriveFilesAccessUsersPostAsync(int drive_id, int file_id, string? with = null, Lang7? lang = null, Body32? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/users"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/users");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (lang != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("lang")).Append('=').Append(Uri.EscapeDataString(ConvertToString(lang, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response243>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response243>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 404)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response244>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response244>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response245>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response245>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response246>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response246>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update access
        /// </summary>
        /// <remarks>
        /// Update the access permission of an access
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="user_id">User identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response247>> TwoDriveFilesAccessUsersPutAsync(int drive_id, int file_id, int user_id, Body33? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/users/{user_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/users/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(user_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response247>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response247>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response248>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response248>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response249>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response249>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Remove access
        /// </summary>
        /// <remarks>
        /// Delete access of a File/Directory
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="user_id">User identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response250>> TwoDriveFilesAccessUsersDeleteAsync(int drive_id, int file_id, int user_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/users/{user_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/users/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(user_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response250>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response250>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response251>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response251>("User not associated with drive", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response252>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response252>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Force write access
        /// </summary>
        /// <remarks>
        /// Claim write access in a shared file
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response253>> TwoDriveFilesAccessForceAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/force"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/access/force");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response253>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response253>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response254>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response254>("Unsupported file type", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response255>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response255>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response256>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response256>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get share-link
        /// </summary>
        /// <remarks>
        /// Get a share link information
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response257>> TwoDriveFilesLinkGetAsync(int drive_id, int file_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/link"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/link");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response257>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response257>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response258>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response258>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response259>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response259>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update share-link
        /// </summary>
        /// <remarks>
        /// Update a share-link
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response260>> TwoDriveFilesLinkPutAsync(int drive_id, int file_id, Body34? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/link"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/link");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response260>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response260>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response261>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response261>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response262>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response262>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Create share-link
        /// </summary>
        /// <remarks>
        /// Create a share link
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response263>> TwoDriveFilesLinkPostAsync(int drive_id, int file_id, string? with = null, Body35? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/link"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/link");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response263>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response263>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response264>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response264>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response265>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response265>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Remove share-link
        /// </summary>
        /// <remarks>
        /// Delete a share link
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response266>> TwoDriveFilesLinkDeleteAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/link"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/link");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response266>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response266>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response267>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response267>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Share link invite
        /// </summary>
        /// <remarks>
        /// Send an email with the share link, to allow an user to upload files.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response268>> TwoDriveFilesLinkInviteAsync(int drive_id, int file_id, Body36? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/link/invite"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/link/invite");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response268>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response268>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response269>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response269>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get dropbox
        /// </summary>
        /// <remarks>
        /// Get dropbox by the directory identifier.
        /// <br/>&lt;note&gt;A dropbox allows no logged users to upload files to this directory via an external dropbox link (see Drive &gt; External Access &gt; Dropbox).&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response270>> TwoDriveFilesDropboxGetAsync(int drive_id, int file_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/dropbox"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/dropbox");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response270>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response270>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response271>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response271>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response272>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response272>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Update dropbox
        /// </summary>
        /// <remarks>
        /// Update and manage a dropbox.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response273>> TwoDriveFilesDropboxPutAsync(int drive_id, int file_id, Body37? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/dropbox"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/dropbox");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response273>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response273>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response274>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response274>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Create dropbox
        /// </summary>
        /// <remarks>
        /// Create a new dropbox Directory.
        /// <br/>&lt;note&gt;A dropbox allow not logged user to upload file in this directory via an external dropbox link (see Drive &gt; External Access &gt; Dropbox).&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response275>> TwoDriveFilesDropboxPostAsync(int drive_id, int file_id, Body38? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/dropbox"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/dropbox");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response275>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response275>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response276>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response276>("Collaborative folder already exists for file", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response277>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response277>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response278>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response278>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Delete dropbox
        /// </summary>
        /// <remarks>
        /// Delete a Dropbox Directory resource
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response279>> TwoDriveFilesDropboxDeleteAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/dropbox"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/dropbox");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response279>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response279>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response280>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response280>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Dropbox invite
        /// </summary>
        /// <remarks>
        /// Send an email with the dropbox external link, to allow an user to upload files.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response281>> TwoDriveFilesDropboxInviteAsync(int drive_id, int file_id, Body39? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/dropbox/invite"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/dropbox/invite");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response281>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response281>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response282>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response282>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get file comments
        /// </summary>
        /// <remarks>
        /// Retrieve all Comments from a file
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
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
        public virtual async Task<SwaggerResponse<Response283>> TwoDriveFilesCommentsGetAsync(int drive_id, int file_id, string? with = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/comments");
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response283>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response283>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response284>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response284>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Add comment
        /// </summary>
        /// <remarks>
        /// Add a comment to a file.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response285>> TwoDriveFilesCommentsPostAsync(int drive_id, int file_id, string? with = null, Body40? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/comments");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response285>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response285>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response286>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response286>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get comment reply
        /// </summary>
        /// <remarks>
        /// Retrieve reply responding to a comment on file.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
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
        public virtual async Task<SwaggerResponse<Response287>> TwoDriveFilesCommentsGetAsync(int drive_id, int file_id, string comment_id, string? with = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/comments/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(comment_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append('?');
                    if (with != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("with")).Append('=').Append(Uri.EscapeDataString(ConvertToString(with, CultureInfo.InvariantCulture))).Append('&');
                    }
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response287>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response287>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response288>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response288>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Modify comment
        /// </summary>
        /// <remarks>
        /// Modify a comment on a file.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response289>> TwoDriveFilesCommentsPutAsync(int drive_id, int file_id, string comment_id, string? with = null, Body41? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("PUT");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/comments/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(comment_id, CultureInfo.InvariantCulture)));
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response289>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response289>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response290>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response290>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Add comment reply
        /// </summary>
        /// <remarks>
        /// Add a reply to a comment.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response291>> TwoDriveFilesCommentsPostAsync(int drive_id, int file_id, string comment_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/comments/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(comment_id, CultureInfo.InvariantCulture)));
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response291>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response291>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response292>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response292>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Delete comment
        /// </summary>
        /// <remarks>
        /// Delete a comment from a file.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response293>> TwoDriveFilesCommentsDeleteAsync(int drive_id, int file_id, string comment_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/comments/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(comment_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response293>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response293>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response294>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response294>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Like comment
        /// </summary>
        /// <remarks>
        /// Add a like to the comment
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response295>> TwoDriveFilesCommentsLikeAsync(int drive_id, int file_id, string comment_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}/like"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/comments/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(comment_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/like");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response295>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response295>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response296>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response296>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Unlike comment
        /// </summary>
        /// <remarks>
        /// Remove a like from the Comment
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response297>> TwoDriveFilesCommentsUnlikeAsync(int drive_id, int file_id, string comment_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}/unlike"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/comments/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(comment_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/unlike");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response297>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response297>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response298>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response298>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Check file' existence
        /// </summary>
        /// <remarks>
        /// Check if some files ids still exists in the drive
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response299>> TwoDriveFilesExistsAsync(int drive_id, Body42? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/exists"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/exists");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response299>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response299>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response300>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response300>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Download archive
        /// </summary>
        /// <remarks>
        /// You can download an archive/zip with the token provided by the route &lt;a href="javascript:window.location = window.location.pathname.replace('get/2', 'post/3') + '/..'"&gt;drive/{drive_id}/files/archives&lt;/a&gt;.
        /// <br/>
        /// <br/>&lt;note&gt;Please note that this may respond a 302 to actually download the requested content.&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="archive_uuid">Archive uuid</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> TwoDriveFilesArchivesAsync(int drive_id, string archive_uuid, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/zip"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/files/archives/{archive_uuid}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/archives/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(archive_uuid, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<string>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<string>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response301>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response301>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response302>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response302>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response303>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response303>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response304>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response304>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Empty trash
        /// </summary>
        /// <remarks>
        /// Empty all trashed files
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response305>> TwoDriveTrashDeleteAsync(int drive_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/trash"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/trash");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response305>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response305>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response306>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response306>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Count Directory/File in Trash
        /// </summary>
        /// <remarks>
        /// Count the number of Directory and File in trash
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response307>> TwoDriveTrashCountGetAsync(int drive_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/trash/count"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/trash/count");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response307>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response307>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response308>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response308>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Remove file
        /// </summary>
        /// <remarks>
        /// Delete a file from trash (remove it completely)
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <param name="file_id">the file identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response309>> TwoDriveTrashDeleteAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/trash/{file_id}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/trash/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response309>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response309>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response310>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response310>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Restore file
        /// </summary>
        /// <remarks>
        /// Restore a specific Directory or File from the trash
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <param name="file_id">the file identifier</param>
        /// <param name="body">Request body of the called URI</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response311>> TwoDriveTrashRestoreAsync(int drive_id, int file_id, Body43 body, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/trash/{file_id}/restore"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/trash/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/restore");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response311>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response311>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response312>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response312>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response313>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response313>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response314>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response314>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response315>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response315>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Get thumbnail
        /// </summary>
        /// <remarks>
        /// Get thumbnail of trashed file
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <param name="file_id">the file identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> TwoDriveTrashThumbnailAsync(int drive_id, int file_id, int? height = null, int? width = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("image/*"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/trash/{file_id}/thumbnail"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/trash/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(file_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/thumbnail");
                    urlBuilder_.Append('?');
                    if (height != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("height")).Append('=').Append(Uri.EscapeDataString(ConvertToString(height, CultureInfo.InvariantCulture))).Append('&');
                    }
                    if (width != null)
                    {
                        urlBuilder_.Append(Uri.EscapeDataString("width")).Append('=').Append(Uri.EscapeDataString(ConvertToString(width, CultureInfo.InvariantCulture))).Append('&');
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<string>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<string>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response316>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response316>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Count Directory/File in trashed Directory
        /// </summary>
        /// <remarks>
        /// Count the number of Directory and File
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <param name="file_id">the file identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response317>> TwoDriveTrashCountGetAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/trash/{file_id}/count"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/trash/");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response317>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response317>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response318>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response318>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Cancel session
        /// </summary>
        /// <remarks>
        /// Cancel an upload by its token. If you want to stop the upload and close the session to explicitly erase the file/upload.
        /// <br/>&lt;br/&gt;&lt;br/&gt;&lt;note&gt;
        /// <br/>When a session is started, it can be used for a maximum of 12 hours, so it's cancelled automatically after 12 hours.
        /// <br/>&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="session_token">Session token uuid</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response319>> TwoDriveUploadSessionAsync(int drive_id, int session_token, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/drive/{drive_id}/upload/session/{session_token}"
                    urlBuilder_.Append("2/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/upload/session/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(session_token, CultureInfo.InvariantCulture)));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response319>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response319>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response320>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response320>("Destination not writable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response321>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response321>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response322>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response322>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Build an archive from files in the share link. The archive can then be downloaded using the &lt;a href="/docs/api/get/2/drive/{drive_id}/share/{sharelink_uuid}/download"&gt;drive/{drive_id}/share/{sharelink_uuid}/download&lt;/a&gt; route.
        /// <br/>&lt;/br&gt;&lt;/br&gt;&lt;note&gt;
        /// <br/>The file identifiers should be in the same parent directory.
        /// <br/>&lt;/note&gt;
        /// <br/>&lt;/br&gt;&lt;note&gt;
        /// <br/>The archive should contain at least one file and may not contain more than 20,000 files.
        /// <br/>&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="sharelink_uuid">Sharelink token</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response323>> TwoAppShareArchiveAsync(int drive_id, int sharelink_uuid, Body44? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/app/{drive_id}/share/{sharelink_uuid}/archive"
                    urlBuilder_.Append("2/app/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/share/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(sharelink_uuid, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/archive");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response323>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response323>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response324>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response324>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response325>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response325>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Download sharelink archive
        /// </summary>
        /// <remarks>
        /// You can download an archive/zip with the archive token provided by the route &lt;a href="/docs/api/post/2/drive/{drive_id}/share/{sharelink_uuid}/download"&gt;drive/{drive_id}/share/{sharelink_uuid}/download&lt;/a&gt;.
        /// <br/>&lt;note&gt;Please note that this may respond a 302 to actually download the requested content.&lt;/note&gt;
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="sharelink_uuid">Sharelink token</param>
        /// <param name="archive_uuid">Archive token</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> TwoAppShareArchiveDownloadAsync(int drive_id, string sharelink_uuid, string archive_uuid, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/zip"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "2/app/{drive_id}/share/{sharelink_uuid}/archive/{archive_uuid}/download"
                    urlBuilder_.Append("2/app/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/share/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(sharelink_uuid, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/archive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(archive_uuid, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/download");

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<string>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<string>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response326>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response326>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response327>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response327>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response328>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response328>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response329>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response329>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response330>> ThreeDriveFilesAsync(int drive_id, int file_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response330>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response330>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response331>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response331>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response332>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response332>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response333>> ThreeDriveFilesFilesAsync(int drive_id, int file_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous12>? order_by = null, Anonymous13? order = null, IEnumerable<Anonymous14>? order_for = null, IEnumerable<Anonymous15>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
                    // Operation Path: "3/drive/{drive_id}/files/{file_id}/files"
                    urlBuilder_.Append("3/drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));
                    urlBuilder_.Append("/files/");
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response333>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response333>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response334>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response334>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response335>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response335>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response336>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response336>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response337>> ThreeDriveFilesCountAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response337>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response337>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response338>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response338>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response339>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response339>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response340>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response340>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response341>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response341>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response342>> ThreeDriveFilesDirectoryAsync(int drive_id, int file_id, string? with = null, Body45? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response342>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response342>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response343>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response343>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response344>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response344>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response345>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response345>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response346>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response346>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response347>> ThreeDriveFilesFileAsync(int drive_id, int file_id, string? with = null, Body46? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response347>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response347>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response348>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response348>("Destination not a directory", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response349>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response349>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response350>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response350>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response351>> ThreeDriveFilesCopyAsync(int drive_id, int file_id, int destination_directory_id, string? with = null, Body47? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response351>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response351>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response352>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response352>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response353>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response353>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response354>> ThreeDriveFilesDuplicateAsync(int drive_id, int file_id, string? with = null, Body48? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response354>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response354>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response355>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response355>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response356>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response356>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response357>> ThreeDriveFilesConvertAsync(int drive_id, int file_id, string? with = null, string? x_kdrive_file_password = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    if (x_kdrive_file_password != null)
                        request_.Headers.TryAddWithoutValidation("x-kdrive-file-password", ConvertToString(x_kdrive_file_password, CultureInfo.InvariantCulture));
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response357>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response357>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response358>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response358>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response359>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response359>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response360>> ThreeDriveFilesMoveAsync(int drive_id, int file_id, int destination_directory_id, Body49? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response360>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response360>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response361>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response361>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response362>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response362>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response363>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response363>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response364>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response364>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response365>> ThreeDriveFilesVersionsAsync(int drive_id, int file_id, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response365>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response365>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response366>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response366>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response367>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response367>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response368>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response368>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response369>> ThreeDriveFilesVersionsRestorePostAsync(int drive_id, int file_id, int version_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response369>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response369>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response370>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response370>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response371>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response371>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response372>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response372>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response373>> ThreeDriveFilesVersionsRestorePostAsync(int drive_id, int file_id, int version_id, int destination_directory_id, string? with = null, Body50? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response373>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response373>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response374>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response374>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response375>> ThreeDriveFilesSearchAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous16>? order_by = null, Anonymous17? order = null, IEnumerable<Anonymous18>? order_for = null, int? modified_after = null, Modified_at? modified_at = null, int? modified_before = null, string? query = null, IEnumerable<Anonymous19>? types = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response375>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response375>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response376>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response376>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response377>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response377>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response378>> ThreeDriveFilesSearchDropboxesAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous20>? order_by = null, Anonymous21? order = null, IEnumerable<Anonymous22>? order_for = null, int? author_id = null, string? category = null, int? created_after = null, Created_at? created_at = null, int? created_before = null, Expires? expires = null, Has_password? has_password = null, int? last_import_after = null, Last_import_at? last_import_at = null, int? last_import_before = null, string? query = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response378>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response378>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response379>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response379>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response380>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response380>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response381>> ThreeDriveFilesSearchFavoritesAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous23>? order_by = null, Anonymous24? order = null, IEnumerable<Anonymous25>? order_for = null, int? author_id = null, string? category = null, Anonymous26? depth = null, int? directory_id = null, IEnumerable<string>? extensions = null, int? modified_after = null, Anonymous27? modified_at = null, int? modified_before = null, string? name = null, string? query = null, IEnumerable<Anonymous28>? types = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response381>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response381>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response382>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response382>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response383>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response383>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response384>> ThreeDriveFilesSearchLinksAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous29>? order_by = null, Anonymous30? order = null, IEnumerable<Anonymous31>? order_for = null, int? author_id = null, string? category = null, int? created_after = null, Anonymous32? created_at = null, int? created_before = null, Anonymous33? expires = null, Anonymous34? has_password = null, string? query = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response384>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response384>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response385>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response385>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response386>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response386>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response387>> ThreeDriveFilesSearchSharedWithMeAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous35>? order_by = null, Anonymous36? order = null, IEnumerable<Anonymous37>? order_for = null, int? author_id = null, string? category = null, Anonymous38? depth = null, int? directory_id = null, IEnumerable<string>? extensions = null, int? modified_after = null, Anonymous39? modified_at = null, int? modified_before = null, string? name = null, string? query = null, IEnumerable<Anonymous40>? types = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response387>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response387>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response388>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response388>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response389>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response389>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response390>> ThreeDriveFilesSearchMySharedAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous41>? order_by = null, Anonymous42? order = null, IEnumerable<Anonymous43>? order_for = null, int? author_id = null, string? category = null, Anonymous44? depth = null, int? directory_id = null, IEnumerable<string>? extensions = null, int? modified_after = null, Anonymous45? modified_at = null, int? modified_before = null, string? name = null, string? query = null, IEnumerable<Anonymous46>? types = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response390>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response390>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response391>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response391>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response392>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response392>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        /// Search Trash
        /// </summary>
        /// <remarks>
        /// Search trash with specific filters.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response393>> ThreeDriveFilesSearchTrashAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous47>? order_by = null, Anonymous48? order = null, IEnumerable<Anonymous49>? order_for = null, int? author_id = null, string? category = null, int? deleted_after = null, Deleted_at? deleted_at = null, int? deleted_before = null, int? deleted_by = null, string? query = null, IEnumerable<Anonymous50>? types = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response393>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response393>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response394>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response394>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response395>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response395>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response396>> ThreeDriveFilesDropboxesAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous51>? order_by = null, Anonymous52? order = null, IEnumerable<Anonymous53>? order_for = null, IEnumerable<Anonymous54>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response396>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response396>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response397>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response397>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response398>> ThreeDriveFilesFavoritesAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous55>? order_by = null, Anonymous56? order = null, IEnumerable<Anonymous57>? order_for = null, IEnumerable<Anonymous58>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response398>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response398>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response399>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response399>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response400>> ThreeDriveFilesLargestAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous59>? order_by = null, Anonymous60? order = null, IEnumerable<Anonymous61>? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response400>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response400>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response401>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response401>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response402>> ThreeDriveFilesLastModifiedAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous62>? order_by = null, Anonymous63? order = null, IEnumerable<Anonymous64>? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response402>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response402>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response403>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response403>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response404>> ThreeDriveFilesLinksAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous65>? order_by = null, Anonymous66? order = null, IEnumerable<Anonymous67>? order_for = null, IEnumerable<Anonymous68>? right = null, IEnumerable<Anonymous69>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response404>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response404>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response405>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response405>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response406>> ThreeDriveFilesMostVersionsAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous70>? order_by = null, Anonymous71? order = null, IEnumerable<Anonymous72>? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response406>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response406>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response407>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response407>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response408>> ThreeDriveFilesMySharedAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous73>? order_by = null, Anonymous74? order = null, IEnumerable<Anonymous75>? order_for = null, IEnumerable<Anonymous76>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response408>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response408>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response409>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response409>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response410>> ThreeDriveFilesSharedWithMeAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous77>? order_by = null, Anonymous78? order = null, IEnumerable<Anonymous79>? order_for = null, IEnumerable<Anonymous80>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response410>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response410>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response411>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response411>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response412>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response412>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response413>> ThreeDriveFilesTeamDirectoryAsync(int drive_id, string? with = null, Body51? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response413>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response413>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response414>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response414>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response415>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response415>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response416>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response416>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response417>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response417>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response418>> ThreeDriveFilesRecentsAsync(string drive_id, string? with = null, Type? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response418>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response418>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response419>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response419>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response420>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response420>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response421>> ThreeDriveFilesArchivesAsync(int drive_id, Body52? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 201)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response421>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response421>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response422>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response422>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response423>> ThreeDriveTrashGetAsync(int drive_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous81>? order_by = null, Anonymous82? order = null, IEnumerable<Anonymous83>? order_for = null, IEnumerable<Anonymous84>? type = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response423>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response423>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response424>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response424>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response425>> ThreeDriveTrashGetAsync(int drive_id, int file_id, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response425>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response425>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response426>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response426>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response427>> ThreeDriveTrashFilesAsync(int drive_id, int file_id, string? with = null, string? cursor = null, int? limit = null, IEnumerable<Anonymous85>? order_by = null, Anonymous86? order = null, IEnumerable<Anonymous87>? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response427>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response427>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response428>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response428>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response429>> ThreeDriveUploadAsync(int drive_id, int total_size, string? with = null, string? if_Match = null, string? client_token = null, Conflict? conflict = null, string? created_at = null, int? directory_id = null, string? directory_path = null, string? file_name = null, string? last_modified_at = null, string? symbolic_link = null, string? total_chunk_hash = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    if (if_Match != null)
                        request_.Headers.TryAddWithoutValidation("If-Match", ConvertToString(if_Match, CultureInfo.InvariantCulture));
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response429>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response429>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response430>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response430>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response431>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response431>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 404)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response432>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response432>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 409)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response433>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response433>("Conflict", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response434>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response434>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response435>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response435>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response436>> ThreeDriveUploadSessionStartAsync(int drive_id, string? with = null, string? if_Match = null, Body53? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    if (if_Match != null)
                        request_.Headers.TryAddWithoutValidation("If-Match", ConvertToString(if_Match, CultureInfo.InvariantCulture));
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response436>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response436>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response437>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response437>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response438>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response438>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 409)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response439>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response439>("Conflict", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response440>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response440>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response441>> ThreeDriveUploadSessionBatchStartAsync(int drive_id, string? with = null, Body54? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response441>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response441>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response442>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response442>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 429)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response443>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response443>("Response", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response444>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response444>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response445>> ThreeDriveUploadSessionChunkAsync(int drive_id, string session_token, int chunk_number, int chunk_size, string? chunk_hash = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response445>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response445>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 500)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response446>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response446>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response447>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response447>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response448>> ThreeDriveUploadSessionFinishAsync(int drive_id, string session_token, string? with = null, Body55? body = null, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(session_token);

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response448>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response448>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 400)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response449>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response449>("Bad Request", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 403)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response450>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response450>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response451>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response451>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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
        public virtual async Task<SwaggerResponse<Response452>> ThreeDriveUploadSessionBatchFinishAsync(int drive_id, string? with = null, Body56? body = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var json_ = JsonSerializer.SerializeToUtf8Bytes(body, _settings.Value);
                    var content_ = new ByteArrayContent(json_);
                    content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    var urlBuilder_ = new StringBuilder();
                    if (!string.IsNullOrEmpty(_baseUrl)) urlBuilder_.Append(_baseUrl);
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
                        var headers_ = new Dictionary<string, IEnumerable<string>>();
                        foreach (var item_ in response_.Headers)
                            headers_[item_.Key] = item_.Value;
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response452>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            return new SwaggerResponse<Response452>(status_, headers_, objectResponse_.Object);
                        }
                        else
                        if (status_ == 429)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response453>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response453>("Response", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        if (status_ == 503)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<Response454>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new NullResponseException(status_, objectResponse_.Text, headers_);
                            }
                            throw new ApiException<Response454>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                            throw new UnexpectedHttpCodeException(status_, responseData_, headers_);
                        }
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectResponseResult"/> class.
        /// </summary>
        /// <param name="responseObject">The response object.</param>
        /// <param name="responseText">The response text.</param>
        public struct ObjectResponseResult<T>(T responseObject, string responseText)
        {
            /// <summary>
            /// Gets the object.
            /// </summary>
            public T Object { get; } = responseObject;

            /// <summary>
            /// Gets the text.
            /// </summary>
            public string Text { get; } = responseText;
        }

        /// <summary>
        /// Gets or sets a value indicating whether read response as string.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Reads the object response async.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="headers">The headers.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task.</returns>
        protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
        {
            if (response == null || response.Content == null)
            {
                return new ObjectResponseResult<T>(default!, string.Empty);
            }

            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                try
                {
                    var typedBody = JsonSerializer.Deserialize<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody!, responseText);
                }
                catch (JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false))
                    {
                        var typedBody = await JsonSerializer.DeserializeAsync<T>(responseStream, JsonSerializerSettings, cancellationToken).ConfigureAwait(false);
                        return new ObjectResponseResult<T>(typedBody!, string.Empty);
                    }
                }
                catch (JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                }
            }
        }

        /// <summary>
        /// Converts the to string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="cultureInfo">The culture info.</param>
        /// <returns>A string.</returns>
        private string ConvertToString(object? value, CultureInfo cultureInfo)
        {
            if (value == null)
            {
                return "";
            }

            if (value is Enum)
            {
                var name = Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = System.Reflection.IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        var attribute = System.Reflection.CustomAttributeExtensions.GetCustomAttribute(field, typeof(System.Runtime.Serialization.EnumMemberAttribute))
                            as System.Runtime.Serialization.EnumMemberAttribute;
                        if (attribute != null)
                        {
                            return attribute.Value ?? name;
                        }
                    }

                    var converted = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                    return converted ?? string.Empty;
                }
            }
            else if (value is bool)
            {
                return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return Convert.ToBase64String((byte[])value);
            }
            else if (value is string[])
            {
                return string.Join(",", (string[])value);
            }
            else if (value.GetType().IsArray)
            {
                var valueArray = (Array)value;
                var valueTextArray = new string[valueArray.Length];
                for (var i = 0; i < valueArray.Length; i++)
                {
                    valueTextArray[i] = ConvertToString(valueArray.GetValue(i), cultureInfo);
                }
                return string.Join(",", valueTextArray);
            }

            var result = Convert.ToString(value, cultureInfo);
            return result ?? "";
        }
    }
}