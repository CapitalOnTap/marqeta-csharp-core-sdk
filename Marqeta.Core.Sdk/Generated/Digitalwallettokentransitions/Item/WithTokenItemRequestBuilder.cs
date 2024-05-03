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
namespace Marqeta.Core.Sdk.Digitalwallettokentransitions.Item {
    /// <summary>
    /// Builds and executes requests for operations under \digitalwallettokentransitions\{token}
    /// </summary>
    public class WithTokenItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>
        /// Instantiates a new <see cref="WithTokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwallettokentransitions/{token}{?fields*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithTokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwallettokentransitions/{token}{?fields*}", rawUrl)
        {
        }
        /// <summary>
        /// Use this endpoint to retrieve a specific digital wallet token transition.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="Digital_wallet_token_transition_response"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Digital_wallet_token_transition_response?> GetAsync(Action<RequestConfiguration<WithTokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Digital_wallet_token_transition_response> GetAsync(Action<RequestConfiguration<WithTokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Digital_wallet_token_transition_response>(requestInfo, Digital_wallet_token_transition_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use this endpoint to retrieve a specific digital wallet token transition.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithTokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WithTokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
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
        public WithTokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithTokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Use this endpoint to retrieve a specific digital wallet token transition.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;.
        /// </summary>
        public class WithTokenItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Comma-delimited list of fields to return (`field_1,field_2`, and so on).Leave blank to return all fields.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string Fields { get; set; }
#endif
        }
    }
}
