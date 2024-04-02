// <auto-generated/>
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Users.Auth.Clientaccesstoken.Item {
    /// <summary>
    /// Builds and executes requests for operations under \users\auth\clientaccesstoken\{token}
    /// </summary>
    public class WithTokenItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="WithTokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/auth/clientaccesstoken/{token}{?application_token*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithTokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/auth/clientaccesstoken/{token}{?application_token*}", rawUrl) {
        }
        /// <summary>
        /// To retrieve application and card information using a client access token, send a `GET` request to the `/users/auth/clientaccesstoken/{token}` endpoint.
        /// </summary>
        /// <returns>A <see cref="Client_access_token_response"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Client_access_token_response?> GetAsync(Action<RequestConfiguration<WithTokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Client_access_token_response> GetAsync(Action<RequestConfiguration<WithTokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Client_access_token_response>(requestInfo, Client_access_token_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// To retrieve application and card information using a client access token, send a `GET` request to the `/users/auth/clientaccesstoken/{token}` endpoint.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithTokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithTokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithTokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithTokenItemRequestBuilder WithUrl(string rawUrl) {
            return new WithTokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// To retrieve application and card information using a client access token, send a `GET` request to the `/users/auth/clientaccesstoken/{token}` endpoint.
        /// </summary>
        public class WithTokenItemRequestBuilderGetQueryParameters {
            /// <summary>Unique identifier of the `application` object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("application_token")]
            public string? ApplicationToken { get; set; }
#nullable restore
#else
            [QueryParameter("application_token")]
            public string ApplicationToken { get; set; }
#endif
        }
    }
}