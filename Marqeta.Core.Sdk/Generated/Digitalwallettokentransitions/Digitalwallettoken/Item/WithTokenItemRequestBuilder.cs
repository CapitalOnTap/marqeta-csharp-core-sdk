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
namespace Marqeta.Core.Sdk.Digitalwallettokentransitions.Digitalwallettoken.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \digitalwallettokentransitions\digitalwallettoken\{token}
    /// </summary>
    public class WithTokenItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Digitalwallettokentransitions.Digitalwallettoken.Item.WithTokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwallettokentransitions/digitalwallettoken/{token}{?count*,fields*,sort_by*,start_index*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Digitalwallettokentransitions.Digitalwallettoken.Item.WithTokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/digitalwallettokentransitions/digitalwallettoken/{token}{?count*,fields*,sort_by*,start_index*}", rawUrl)
        {
        }
        /// <summary>
        /// Use this endpoint to return an array of all transitions for a particular digital wallet token.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;, &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;, and &lt;&lt;/core-api/sorting-and-pagination, sorting&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.DigitalWalletTokenTransitionListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.DigitalWalletTokenTransitionListResponse?> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Digitalwallettokentransitions.Digitalwallettoken.Item.WithTokenItemRequestBuilder.WithTokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.DigitalWalletTokenTransitionListResponse> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Digitalwallettokentransitions.Digitalwallettoken.Item.WithTokenItemRequestBuilder.WithTokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.DigitalWalletTokenTransitionListResponse>(requestInfo, Marqeta.Core.Sdk.Models.DigitalWalletTokenTransitionListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use this endpoint to return an array of all transitions for a particular digital wallet token.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;, &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;, and &lt;&lt;/core-api/sorting-and-pagination, sorting&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Digitalwallettokentransitions.Digitalwallettoken.Item.WithTokenItemRequestBuilder.WithTokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Digitalwallettokentransitions.Digitalwallettoken.Item.WithTokenItemRequestBuilder.WithTokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Marqeta.Core.Sdk.Digitalwallettokentransitions.Digitalwallettoken.Item.WithTokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Digitalwallettokentransitions.Digitalwallettoken.Item.WithTokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Digitalwallettokentransitions.Digitalwallettoken.Item.WithTokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Use this endpoint to return an array of all transitions for a particular digital wallet token.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt;, &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;, and &lt;&lt;/core-api/sorting-and-pagination, sorting&gt;&gt;.
        /// </summary>
        public class WithTokenItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Number of digital wallet transitions to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
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
            /// <summary>Field on which to sort.Use any field in the resource model, or one of the system fields `lastModifiedTime` or `createdTime`.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort_by")]
            public string? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sort_by")]
            public string SortBy { get; set; }
#endif
            /// <summary>The sort order index of the first digital wallet token in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}
