namespace kDriveApiWrapper.Models
{
    /// <summary>
    /// The client.
    /// </summary>

    public partial class BaseClient
    {
        private readonly IRequestContext _requestContext;
        private string _baseUrl = "/";
        internal HttpClient _httpClient;
        private static Lazy<JsonSerializerOptions> _settings = new(CreateSerializerSettings, true);

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseClient"/> class.
        /// </summary>
        /// <param name="httpClient">The http client.</param>
        public BaseClient(HttpClient httpClient)
        {
            BaseUrl = "https://api.infomaniak.com";
            _httpClient = httpClient;
        }

        /// <summary>
        /// Creates the serializer settings.
        /// </summary>
        /// <returns>A JsonSerializerOptions.</returns>
        internal static JsonSerializerOptions CreateSerializerSettings()
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
        internal partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url);

        /// <summary>
        /// Prepares the request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="url">The url.</param>
        internal partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url)
        {
            if(request.Method == HttpMethod.Get)
            {
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));
            }
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _requestContext.GetBearerTokenOrTriggerUnauthException());
        }

        internal partial void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _requestContext.GetBearerTokenOrTriggerUnauthException());
        }

        /// <summary>
        /// Prepares the request.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="request">The request.</param>
        /// <param name="urlBuilder">The url builder.</param>
        internal partial void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder);

        /// <summary>
        /// Processes the response.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="response">The response.</param>
        internal partial Task<SwaggerResponse<Response>> ProcessResponse(HttpClient client, HttpResponseMessage response, CancellationToken cancellationToken);
        internal partial Task<SwaggerResponse<string>> ProcessCsvResponse(HttpClient client, HttpResponseMessage response, CancellationToken cancellationToken);
        /// <summary>
        /// Processes the file response.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="response">The response.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task.</returns>
        internal partial Task<SwaggerResponse<Stream>> ProcessFileResponse(HttpClient client, HttpResponseMessage response, CancellationToken cancellationToken);

        /// <summary>
        /// Processes the response.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="response">The response.</param>
        /// <returns>A Dictionary.</returns>
        internal partial async Task<SwaggerResponse<Response>> ProcessResponse(HttpClient client, HttpResponseMessage response, CancellationToken cancellationToken)
        {
            return await GetObjectResponse(response, response.Headers.ToDictionary(), cancellationToken);
        }

        internal partial async Task<SwaggerResponse<string>> ProcessCsvResponse(HttpClient client, HttpResponseMessage response, CancellationToken cancellationToken)
        {
            return await GetObjectResponse(response, response.Headers.ToDictionary(), cancellationToken);
        }

        internal partial async Task<SwaggerResponse<Stream>> ProcessFileResponse(HttpClient client, HttpResponseMessage response, CancellationToken cancellationToken)
        {
            return await GetObjectResponse(response, response.Headers.ToDictionary(), cancellationToken);
        }

        /// <summary>
        /// Gets the object response.
        /// </summary>
        /// <param name="response_">The response_.</param>
        /// <param name="headers_">The headers_.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A Task.</returns>
        private async Task<SwaggerResponse<Response>> GetObjectResponse(HttpResponseMessage response_, Dictionary<String, IEnumerable<String>> headers_, CancellationToken cancellationToken)
        {
            var status_ = (int)response_.StatusCode;
            var objectResponse_ = await ReadObjectResponseAsync<Response>(response_, headers_, cancellationToken).ConfigureAwait(false);
            CheckNullResponse(status_, objectResponse_, headers_);

            switch (status_)
            {
                case 200:
                case 201:
                    {
                        return new SwaggerResponse<Response>(status_, headers_, objectResponse_.Object);
                    }

                case 400:
                    {
                        throw new ApiException<Response>("Cannot get a temporary url for a directory", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }

                case 403:
                    {
                        throw new ApiException<Response>("Forbidden", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }

                case 404:
                    {
                        throw new ApiException<Response>("Not Found", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }

                case 409:
                    {
                        throw new ApiException<Response>("Conflict", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }

                case 417:
                case 429:
                    {
                        throw new ApiException<Response>("Response", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }

                case 500:
                    {
                        throw new ApiException<Response>("Internal Server Error", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
                    }

                case 503:
                    {
                        throw new ApiException<Response>("Service Unavailable", status_, objectResponse_.Text, headers_, objectResponse_.Object, null);
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
        internal static void CheckNullResponse<T>(Int32 status_, ObjectResponseResult<T> objectResponse_, Dictionary<String, IEnumerable<String>> headers_)
        {
            if (objectResponse_.Object == null)
            {
                throw new NullResponseException(status_, objectResponse_.Text, headers_);
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
        internal virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
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
        internal string ConvertToString(object? value, CultureInfo cultureInfo)
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

        /// <summary>
        /// Gets the headers.
        /// </summary>
        /// <param name="response_">The response_.</param>
        /// <returns>A Dictionary.</returns>
        internal static Dictionary<String, IEnumerable<String>> GetHeaders(HttpResponseMessage response_)
        {
            var headers_ = new Dictionary<string, IEnumerable<string>>();
            foreach (var item_ in response_.Headers)
                headers_[item_.Key] = item_.Value;
            if (response_.Content != null && response_.Content.Headers != null)
            {
                foreach (var item_ in response_.Content.Headers)
                    headers_[item_.Key] = item_.Value;
            }

            return headers_;
        }
    }
}