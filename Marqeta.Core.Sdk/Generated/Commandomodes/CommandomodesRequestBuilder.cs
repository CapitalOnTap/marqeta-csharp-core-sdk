// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Commandomodes.Item;
using Marqeta.Core.Sdk.Commandomodes.Transitions;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Commandomodes
{
    /// <summary>
    /// Builds and executes requests for operations under \commandomodes
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class CommandomodesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The transitions property</summary>
        public global::Marqeta.Core.Sdk.Commandomodes.Transitions.TransitionsRequestBuilder Transitions
        {
            get => new global::Marqeta.Core.Sdk.Commandomodes.Transitions.TransitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.commandomodes.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Commandomodes.Item.Commandomode_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Commandomodes.Item.Commandomode_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("commandomode_token%2Did", position);
                return new global::Marqeta.Core.Sdk.Commandomodes.Item.Commandomode_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Commandomodes.CommandomodesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommandomodesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/commandomodes{?count*,sort_by*,start_index*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Commandomodes.CommandomodesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommandomodesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/commandomodes{?count*,sort_by*,start_index*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all commando mode control sets
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.CommandoModeListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.CommandoModeListResponse?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Commandomodes.CommandomodesRequestBuilder.CommandomodesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.CommandoModeListResponse> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Commandomodes.CommandomodesRequestBuilder.CommandomodesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.CommandoModeListResponse>(requestInfo, global::Marqeta.Core.Sdk.Models.CommandoModeListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all commando mode control sets
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Commandomodes.CommandomodesRequestBuilder.CommandomodesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Commandomodes.CommandomodesRequestBuilder.CommandomodesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Commandomodes.CommandomodesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Commandomodes.CommandomodesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Commandomodes.CommandomodesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all commando mode control sets
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class CommandomodesRequestBuilderGetQueryParameters 
        {
            /// <summary>Number of commando modes to retrieve</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Sort order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort_by")]
            public string? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sort_by")]
            public string SortBy { get; set; }
#endif
            /// <summary>Start index</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}
#pragma warning restore CS0618
