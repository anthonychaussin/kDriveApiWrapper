using kDriveApiWrapper.Models.Requests;

namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The client.
    /// </summary>

    public partial class Client : BaseClient
    {
        public Client(HttpClient httpClient) : base(httpClient)
        {
        }

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
        public virtual async Task<SwaggerResponse<Response>> DriveGetAsync(int account_id, string? with = null, bool? in_maintenance = null, IEnumerable<Item>? maintenance_reasons = null, IEnumerable<int>? tags = null, int? page = null, int? per_page = null, bool? total = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Get })
                {
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    // Operation Path: "2/drive"
                    urlBuilder_.Append("drive");
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
        public virtual async Task<SwaggerResponse<Response>> DriveUsersGetAsync(string? search = null, IEnumerable<int>? user_ids = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Get })
                {
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/users"
                    urlBuilder_.Append("drive/users");
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
        public virtual async Task<SwaggerResponse<Response>> DriveUsersDrivesAsync(int user_id, int account_id, string? with = null, IEnumerable<UserAdministrationLevel>? roles = null, IEnumerable<UserAccess>? status = null, int? page = null, int? per_page = null, bool? total = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Get })
                {
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/users/{user_id}/drives"
                    urlBuilder_.Append("drive/users/");
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
        /// Get user's preference
        /// </summary>
        /// <remarks>
        /// Get the user drive preference ex: notification, date-format, list order etc...
        /// </remarks>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DrivePreferencesGetAsync(string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Get })
                {
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/preferences"
                    urlBuilder_.Append("drive/preferences");
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
        /// Set user's preference
        /// </summary>
        /// <remarks>
        /// Update the user drive preference ex: notification, date-format, list order etc...
        /// </remarks>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DrivePreferencesPatchAsync(Body? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PATCH");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/preferences"
                    urlBuilder_.Append("drive/preferences");

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
        /// Get
        /// </summary>
        /// <remarks>
        /// Returns all rights related to categories on drive
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveCategoriesRightsGetAsync(int drive_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage() { Method = HttpMethod.Get })
                {
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/categories/rights"
                    urlBuilder_.Append("drive/");
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
        /// Update/Create
        /// </summary>
        /// <remarks>
        /// Update or Create rights for categories
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveCategoriesRightsPostAsync(int drive_id, Body2? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/categories/rights"
                    urlBuilder_.Append("drive/");
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
        /// Get All Categories
        /// </summary>
        /// <remarks>
        /// Return a list of all categories
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveCategoriesGetAsync(int drive_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/categories"
                    urlBuilder_.Append("drive/");
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
        /// Create Category
        /// </summary>
        /// <remarks>
        /// Creates a new category with name and color
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveCategoriesPostAsync(int drive_id, Body3? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/categories"
                    urlBuilder_.Append("drive/");
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
        /// Edit Category
        /// </summary>
        /// <remarks>
        /// Edits the name and color of a category by identifier
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <param name="category_id">Category Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveCategoriesPutAsync(int drive_id, int category_id, Body4? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/categories/{category_id}"
                    urlBuilder_.Append("drive/");
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
        /// Delete Category
        /// </summary>
        /// <remarks>
        /// Deletes a category by identifier
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <param name="category_id">Category Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveCategoriesDeleteAsync(int drive_id, int category_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/categories/{category_id}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCategoriesPostAsync(int drive_id, int file_id, int category_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/categories/{category_id}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCategoriesDeleteAsync(int drive_id, int file_id, int category_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/categories/{category_id}"
                    urlBuilder_.Append("drive/");
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
        /// Remove Categories on File
        /// </summary>
        /// <remarks>
        /// Removes all categories on a file
        /// </remarks>
        /// <param name="drive_id">Drive Identifier</param>
        /// <param name="file_id">File Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCategoriesDeleteAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/categories"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCategoriesAiFeedbackAsync(int drive_id, int file_id, int category_id, Body5? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/categories/{category_id}/ai-feedback"
                    urlBuilder_.Append("drive/");
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
        /// List user in drive
        /// </summary>
        /// <remarks>
        /// List of `Users` by drive identifier
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="with">*Optional* : Allows loading additional data about a resource, which may include related resources.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveAccountUserAsync(int drive_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/account/user"
                    urlBuilder_.Append("drive/");
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
        /// Get drive's settings
        /// </summary>
        /// <remarks>
        /// Get drive's settings
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveSettingsAsync(int drive_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/settings"
                    urlBuilder_.Append("drive/");
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
        /// Update IA settings
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveSettingsAiAsync(int drive_id, Body6? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/settings/ai"
                    urlBuilder_.Append("drive/");
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
        /// Update ShareLink settings
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveSettingsLinkAsync(int drive_id, Body7? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/settings/link"
                    urlBuilder_.Append("drive/");
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
        /// Update trash settings
        /// </summary>
        /// <remarks>
        /// Update the trash settings, including the retention period of trashed files
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveSettingsTrashAsync(int drive_id, Body8? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/settings/trash"
                    urlBuilder_.Append("drive/");
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
        /// Update Drive
        /// </summary>
        /// <remarks>
        /// Update Drive from a Drive identifier
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DrivePutAsync(int drive_id, Body9? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}"
                    urlBuilder_.Append("drive/");
                    urlBuilder_.Append(Uri.EscapeDataString(ConvertToString(drive_id, CultureInfo.InvariantCulture)));

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
        public virtual async Task<SwaggerResponse<Response>> DriveUsersGetAsync(int drive_id, string? with = null, string? search = null, IEnumerable<UserStatusType>? status = null, IEnumerable<DriveUserType>? types = null, IEnumerable<int>? user_ids = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/users"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveUsersPostAsync(int drive_id, string? with = null, Lang? lang = null, Requests.DriveUser? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/users"
                    urlBuilder_.Append("drive/");
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
        /// Get user
        /// </summary>
        /// <remarks>
        /// Returns a user resource. When no resource is found, the data is empty.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUsersGetAsync(int drive_id, int user_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}"
                    urlBuilder_.Append("drive/");
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
        /// Update user
        /// </summary>
        /// <remarks>
        /// Update an existing user resource
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUsersPutAsync(int drive_id, int user_id, Body11? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}"
                    urlBuilder_.Append("drive/");
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
        /// Delete user
        /// </summary>
        /// <remarks>
        /// Deletes a drive user resource. Also removes all access, share links and invitations associated with the user.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUsersDeleteAsync(int drive_id, int user_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}"
                    urlBuilder_.Append("drive/");
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
        /// Update user manager right
        /// </summary>
        /// <remarks>
        /// Update the role in the manager
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUsersManagerAsync(int drive_id, int user_id, Body12? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PATCH");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}/manager"
                    urlBuilder_.Append("drive/");
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
        /// Lock user
        /// </summary>
        /// <remarks>
        /// Sets status to locked, preventing access to drive.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUsersLockAsync(int drive_id, int user_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}/lock"
                    urlBuilder_.Append("drive/");
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
        /// Unlock user
        /// </summary>
        /// <remarks>
        /// Sets status to active, restoring access to drive.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="user_id">User Identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveUsersUnlockAsync(int drive_id, int user_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/users/{user_id}/unlock"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveActivitiesReportsGetAsync(int drive_id, string? with = null, IEnumerable<int>? users = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/activities/reports"
                    urlBuilder_.Append("drive/");
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
        /// Create report
        /// </summary>
        /// <remarks>
        /// Create a new report.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="lang">Override the language of the request, in most cases when an e-mail is triggered in the request.</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveActivitiesReportsPostAsync(int drive_id, Lang? lang = null, Body13? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/activities/reports"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveActivitiesReportsGetAsync(int drive_id, int report_id, string? with = null, int? page = null, int? per_page = null, bool? total = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/activities/reports/{report_id}"
                    urlBuilder_.Append("drive/");
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
        /// Delete report
        /// </summary>
        /// <remarks>
        /// Delete report.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="report_id">Report identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveActivitiesReportsDeleteAsync(int drive_id, int report_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/activities/reports/{report_id}"
                    urlBuilder_.Append("drive/");
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
        /// Export report
        /// </summary>
        /// <remarks>
        /// Download/Export report.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="report_id">Report identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> DriveActivitiesReportsExportAsync(int drive_id, int report_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/csv"));

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/activities/reports/{report_id}/export"
                    urlBuilder_.Append("drive/");
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
                        return await ProcessCsvResponse(client_, response_, cancellationToken);
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
        public virtual async Task<SwaggerResponse<Response>> DriveStatisticsSizesAsync(int drive_id, int from, int interval, IEnumerable<FileMetricType> metrics, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/statistics/sizes"
                    urlBuilder_.Append("drive/");
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
        /// Export : files size
        /// </summary>
        /// <remarks>
        /// Exports sizes statistics as csv file
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> DriveStatisticsSizesExportAsync(int drive_id, int from, int interval, IEnumerable<StatisticMetricSizeType> metrics, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/csv"));

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/statistics/sizes/export"
                    urlBuilder_.Append("drive/");
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
                        return await ProcessCsvResponse(client_, response_, cancellationToken);
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
        public virtual async Task<SwaggerResponse<Response>> DriveStatisticsActivitiesUsersAsync(int drive_id, int from, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/statistics/activities/users"
                    urlBuilder_.Append("drive/");
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
        /// Activities : Shared files
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveStatisticsActivitiesSharedFilesAsync(int drive_id, int from, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/statistics/activities/shared_files"
                    urlBuilder_.Append("drive/");
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
        /// Chart : Activities
        /// </summary>
        /// <remarks>
        /// Chart data of activities metrics over time
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveStatisticsActivitiesAsync(int drive_id, int from, int interval, Metric metric, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/statistics/activities"
                    urlBuilder_.Append("drive/");
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
        /// Export : Activities
        /// </summary>
        /// <remarks>
        /// Exports activities statistics
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<string>> DriveStatisticsActivitiesExportAsync(int drive_id, int from, int interval, ActivityMetricsType metric, int until, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/csv"));

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/statistics/activities/export"
                    urlBuilder_.Append("drive/");
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
                        return await ProcessCsvResponse(client_, response_, cancellationToken);
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
        public virtual async Task<SwaggerResponse<Response>> DriveStatisticsActivitiesLinksAsync(int drive_id, int from, int until, string? with = null, int? max_view = null, int? min_view = null, IEnumerable<SharelinkRightType>? rights = null, string? search = null, string? valid_until = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/statistics/activities/links"
                    urlBuilder_.Append("drive/");
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
        /// Export : ShareLinks Activities
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveStatisticsActivitiesLinksExportAsync(int drive_id, int from, int until, int? max_view = null, int? min_view = null, IEnumerable<SharelinkRightType>? rights = null, string? valid_until = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/statistics/activities/links/export"
                    urlBuilder_.Append("drive/");
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
        /// Update Preferences
        /// </summary>
        /// <remarks>
        /// Updates the connected user preference for a drive.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DrivePreferencesPutAsync(int drive_id, Body14? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/preferences"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveCancelAsync(int drive_id, Body19? body = null, CancellationToken cancellationToken = default)
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
                    

                    var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/cancel"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveAccessRequestsAsync(int drive_id, int request_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/access/requests/{request_id}"
                    urlBuilder_.Append("drive/");
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
        /// TrashOption
        /// </summary>
        /// <remarks>
        /// TrashOption a file, move it to the trash can.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}"
                    urlBuilder_.Append("drive/");
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
        /// Favorite file
        /// </summary>
        /// <remarks>
        /// Add a file in the favorites
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>Created</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesFavoritePostAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/favorite"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Stream>> DriveFilesDownloadAsync(int drive_id, int file_id, As? @as = null, string? x_kdrive_file_password = null, CancellationToken cancellationToken = default)
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

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/download"
                    urlBuilder_.Append("drive/");
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
                        return await ProcessFileResponse(client_, response_, cancellationToken);
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesRenameAsync(int drive_id, int file_id, Body20? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/rename"
                    urlBuilder_.Append("drive/");
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
        /// Get size
        /// </summary>
        /// <remarks>
        /// Get the size and storage_size of the File/Directory with children, up to $depth.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesSizesAsync(int drive_id, int file_id, DepthOption? depth = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/sizes"
                    urlBuilder_.Append("drive/");
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
        /// Hash
        /// </summary>
        /// <remarks>
        /// Get file hash.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesHashAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/hash"
                    urlBuilder_.Append("drive/");
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
        /// Copy to Drive
        /// </summary>
        /// <remarks>
        /// Copy source file in source drive to destination drive at destination folder.
        /// </remarks>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCopyToDriveAsync(string drive_id, string file_id, Body21? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/copy-to-drive"
                    urlBuilder_.Append("drive/");
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
        /// Get a Temporary URL
        /// </summary>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesTemporaryUrlAsync(int drive_id, int file_id, int? duration = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/temporary_url"
                    urlBuilder_.Append("drive/");
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
        /// Delete all
        /// </summary>
        /// <remarks>
        /// Delete all version for file.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesVersionsDeleteAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions"
                    urlBuilder_.Append("drive/");
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
        /// Update
        /// </summary>
        /// <remarks>
        /// Update current file version
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesVersionsCurrentAsync(int drive_id, int file_id, Body22? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions/current"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesVersionsGetAsync(int drive_id, int file_id, int version_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions/{version_id}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesVersionsPutAsync(int drive_id, int file_id, int version_id, Body23? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions/{version_id}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesVersionsDeleteAsync(int drive_id, int file_id, int version_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions/{version_id}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Stream>> DriveFilesVersionsDownloadAsync(int drive_id, int file_id, int version_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/octet-stream"));

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/versions/{version_id}/download"
                    urlBuilder_.Append("drive/");
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
                        return await ProcessFileResponse(client_, response_, cancellationToken);
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessRequestsGetAsync(int drive_id, int file_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/requests"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessRequestsPostAsync(int drive_id, int file_id, string? with = null, Body25? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/requests"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessGetAsync(int drive_id, int file_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessPostAsync(int drive_id, int file_id, string? with = null, Lang? lang = null, Body26? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessCheckAsync(int drive_id, int file_id, Body27? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/check"
                    urlBuilder_.Append("drive/");
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
        /// Invitation &gt; get access
        /// </summary>
        /// <remarks>
        /// Show invitation send and that has access to the File|Directory, pending and accepted invitation
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessInvitationsGetAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/invitations"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessInvitationsPostAsync(int drive_id, int file_id, string? with = null, Lang? lang = null, Body28? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/invitations"
                    urlBuilder_.Append("drive/");
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
        /// Check access
        /// </summary>
        /// <remarks>
        /// Check if an invitation exists or a drive invitation is currently pending
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessInvitationsCheckAsync(int drive_id, int file_id, Body29? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/invitations/check"
                    urlBuilder_.Append("drive/");
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
        /// Get access
        /// </summary>
        /// <remarks>
        /// Show team that has access to the File|Directory
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessTeamsGetAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/teams"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessTeamsPostAsync(int drive_id, int file_id, string? with = null, Lang? lang = null, Body30? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/teams"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessTeamsPutAsync(int drive_id, int file_id, int team_id, Body31? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/teams/{team_id}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessTeamsDeleteAsync(int drive_id, int file_id, int team_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/teams/{team_id}"
                    urlBuilder_.Append("drive/");
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
        /// get access
        /// </summary>
        /// <remarks>
        /// Show user that has access to the File|Directory
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessUsersGetAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/users"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessUsersPostAsync(int drive_id, int file_id, string? with = null, Lang? lang = null, Body32? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/users"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessUsersPutAsync(int drive_id, int file_id, int user_id, Body33? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/users/{user_id}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessUsersDeleteAsync(int drive_id, int file_id, int user_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/users/{user_id}"
                    urlBuilder_.Append("drive/");
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
        /// Force write access
        /// </summary>
        /// <remarks>
        /// Claim write access in a shared file
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesAccessForceAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/access/force"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesLinkGetAsync(int drive_id, int file_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/link"
                    urlBuilder_.Append("drive/");
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
        /// Update share-link
        /// </summary>
        /// <remarks>
        /// Update a share-link
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesLinkPutAsync(int drive_id, int file_id, Body34? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/link"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesLinkPostAsync(int drive_id, int file_id, string? with = null, Body35? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/link"
                    urlBuilder_.Append("drive/");
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
        /// Remove share-link
        /// </summary>
        /// <remarks>
        /// Delete a share link
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesLinkDeleteAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/link"
                    urlBuilder_.Append("drive/");
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
        /// Share link invite
        /// </summary>
        /// <remarks>
        /// Send an email with the share link, to allow an user to upload files.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesLinkInviteAsync(int drive_id, int file_id, Body36? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/link/invite"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesDropboxGetAsync(int drive_id, int file_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/dropbox"
                    urlBuilder_.Append("drive/");
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
        /// Update dropbox
        /// </summary>
        /// <remarks>
        /// Update and manage a dropbox.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesDropboxPutAsync(int drive_id, int file_id, Body37? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/dropbox"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesDropboxPostAsync(int drive_id, int file_id, Body38? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/dropbox"
                    urlBuilder_.Append("drive/");
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
        /// Delete dropbox
        /// </summary>
        /// <remarks>
        /// Delete a Dropbox Directory resource
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesDropboxDeleteAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/dropbox"
                    urlBuilder_.Append("drive/");
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
        /// Dropbox invite
        /// </summary>
        /// <remarks>
        /// Send an email with the dropbox external link, to allow an user to upload files.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesDropboxInviteAsync(int drive_id, int file_id, Body39? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/dropbox/invite"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCommentsGetAsync(int drive_id, int file_id, string? with = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCommentsPostAsync(int drive_id, int file_id, string? with = null, Body40? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCommentsGetAsync(int drive_id, int file_id, string comment_id, string? with = null, int? page = null, int? per_page = null, bool? total = null, string? order_by = null, Order? order = null, object? order_for = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCommentsPutAsync(int drive_id, int file_id, string comment_id, string? with = null, Body41? body = null, CancellationToken cancellationToken = default)
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
                    request_.Method = new HttpMethod("PUT");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCommentsPostAsync(int drive_id, int file_id, string comment_id, string? with = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}"
                    urlBuilder_.Append("drive/");
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
        /// Delete comment
        /// </summary>
        /// <remarks>
        /// Delete a comment from a file.
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCommentsDeleteAsync(int drive_id, int file_id, string comment_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}"
                    urlBuilder_.Append("drive/");
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
        /// Like comment
        /// </summary>
        /// <remarks>
        /// Add a like to the comment
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCommentsLikeAsync(int drive_id, int file_id, string comment_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}/like"
                    urlBuilder_.Append("drive/");
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
        /// Unlike comment
        /// </summary>
        /// <remarks>
        /// Remove a like from the Comment
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <param name="file_id">File identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesCommentsUnlikeAsync(int drive_id, int file_id, string comment_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Content = new StringContent(string.Empty, Encoding.UTF8, "application/json");
                    request_.Method = new HttpMethod("POST");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/{file_id}/comments/{comment_id}/unlike"
                    urlBuilder_.Append("drive/");
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
        /// Check file' existence
        /// </summary>
        /// <remarks>
        /// Check if some files ids still exists in the drive
        /// </remarks>
        /// <param name="drive_id">Drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveFilesExistsAsync(int drive_id, Body42? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/exists"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Stream>> DriveFilesArchivesAsync(int drive_id, string archive_uuid, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/zip"));

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/files/archives/{archive_uuid}"
                    urlBuilder_.Append("drive/");
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
                        return await ProcessFileResponse(client_, response_, cancellationToken);
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
        public virtual async Task<SwaggerResponse<Response>> DriveTrashDeleteAsync(int drive_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/trash"
                    urlBuilder_.Append("drive/");
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
        /// Count Directory/File in TrashOption
        /// </summary>
        /// <remarks>
        /// Count the number of Directory and File in trash
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveTrashCountGetAsync(int drive_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/trash/count"
                    urlBuilder_.Append("drive/");
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
        /// Remove file
        /// </summary>
        /// <remarks>
        /// Delete a file from trash (remove it completely)
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <param name="file_id">the file identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Response>> DriveTrashDeleteAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/trash/{file_id}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveTrashRestoreAsync(int drive_id, int file_id, Body43 body, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/trash/{file_id}/restore"
                    urlBuilder_.Append("drive/");
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
        /// Get thumbnail
        /// </summary>
        /// <remarks>
        /// Get thumbnail of trashed file
        /// </remarks>
        /// <param name="drive_id">the drive identifier</param>
        /// <param name="file_id">the file identifier</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<SwaggerResponse<Stream>> DriveTrashThumbnailAsync(int drive_id, int file_id, int? height = null, int? width = null, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("image/*"));

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/trash/{file_id}/thumbnail"
                    urlBuilder_.Append("drive/");
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
                        return await ProcessFileResponse(client_, response_, cancellationToken);
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
        public virtual async Task<SwaggerResponse<Response>> DriveTrashCountGetAsync(int drive_id, int file_id, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/trash/{file_id}/count"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> DriveUploadSessionAsync(int drive_id, int session_token, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("DELETE");
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/drive/{drive_id}/upload/session/{session_token}"
                    urlBuilder_.Append("drive/");
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
        public virtual async Task<SwaggerResponse<Response>> TwoAppShareArchiveAsync(int drive_id, int sharelink_uuid, Body44? body = null, CancellationToken cancellationToken = default)
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
                    

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/app/{drive_id}/share/{sharelink_uuid}/archive"
                    urlBuilder_.Append("app/");
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
        public virtual async Task<SwaggerResponse<Stream>> TwoAppShareArchiveDownloadAsync(int drive_id, string sharelink_uuid, string archive_uuid, CancellationToken cancellationToken = default)
        {
            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/zip"));

                   var urlBuilder_ = new StringBuilder($"{BaseUrl}2/");
                    
                    // Operation Path: "2/app/{drive_id}/share/{sharelink_uuid}/archive/{archive_uuid}/download"
                    urlBuilder_.Append("app/");
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
                        return await ProcessFileResponse(client_, response_, cancellationToken);
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