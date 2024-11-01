// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Bundles.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Bundles
{
    /// <summary>
    /// Builds and executes requests for operations under \bundles
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BundlesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.bundles.item collection</summary>
        /// <param name="position">Unique identifier of the bundle to retrieve.Send a `GET` request to `/credit/bundles` to retrieve existing  tokens.</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Bundles.Item.WithTokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Bundles.Item.WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new global::Marqeta.Core.Sdk.Bundles.Item.WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Bundles.BundlesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BundlesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/bundles{?count*,sort_by*,start_index*,status*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Bundles.BundlesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BundlesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/bundles{?count*,sort_by*,start_index*,status*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve an array of bundles.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.BundleResponsePage"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.BundleResponsePage?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Bundles.BundlesRequestBuilder.BundlesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.BundleResponsePage> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Bundles.BundlesRequestBuilder.BundlesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.BundleResponsePage>(requestInfo, global::Marqeta.Core.Sdk.Models.BundleResponsePage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a bundle.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.BundleResponse"/></returns>
        /// <param name="body">Contains information on a bundle.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.BundleResponse?> PostAsync(global::Marqeta.Core.Sdk.Models.BundleCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.BundleResponse> PostAsync(global::Marqeta.Core.Sdk.Models.BundleCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.BundleResponse>(requestInfo, global::Marqeta.Core.Sdk.Models.BundleResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve an array of bundles.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Bundles.BundlesRequestBuilder.BundlesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Bundles.BundlesRequestBuilder.BundlesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a bundle.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Contains information on a bundle.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.BundleCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.BundleCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Bundles.BundlesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Bundles.BundlesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Bundles.BundlesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve an array of bundles.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt;.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class BundlesRequestBuilderGetQueryParameters 
        {
            /// <summary>Number of bundles resources to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Field on which to sort.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.*NOTE:*You must sort using system field names such as `lastModifiedTime`, not by the field names appearing in response bodies: for example, `last_modified_time`.</summary>
            [QueryParameter("sort_by")]
            public global::Marqeta.Core.Sdk.Bundles.GetSort_byQueryParameterType? SortBy { get; set; }
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
            /// <summary>An array of statuses by which to filter bundles.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("status")]
            public global::Marqeta.Core.Sdk.Models.BundleResourceStatus[]? Status { get; set; }
#nullable restore
#else
            [QueryParameter("status")]
            public global::Marqeta.Core.Sdk.Models.BundleResourceStatus[] Status { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
