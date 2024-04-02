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
namespace Marqeta.Core.Sdk.Commandomodes.Item.Transitions {
    /// <summary>
    /// Builds and executes requests for operations under \commandomodes\{commandomode_token-id}\transitions
    /// </summary>
    public class TransitionsRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="TransitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TransitionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/commandomodes/{commandomode_token%2Did}/transitions{?count*,sort_by*,start_index*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="TransitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TransitionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/commandomodes/{commandomode_token%2Did}/transitions{?count*,sort_by*,start_index*}", rawUrl) {
        }
        /// <summary>
        /// Retrieve a list of Commando Mode transitions for a specific control set.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="CommandoModeTransitionListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CommandoModeTransitionListResponse?> GetAsync(Action<RequestConfiguration<TransitionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CommandoModeTransitionListResponse> GetAsync(Action<RequestConfiguration<TransitionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<CommandoModeTransitionListResponse>(requestInfo, CommandoModeTransitionListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a list of Commando Mode transitions for a specific control set.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TransitionsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<TransitionsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="TransitionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TransitionsRequestBuilder WithUrl(string rawUrl) {
            return new TransitionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve a list of Commando Mode transitions for a specific control set.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.
        /// </summary>
        public class TransitionsRequestBuilderGetQueryParameters {
            /// <summary>Number of Commando Mode control set transitions to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
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
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}