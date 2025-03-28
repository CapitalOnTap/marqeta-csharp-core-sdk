// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Businesses.Item;
using Marqeta.Core.Sdk.Businesses.Lookup;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Businesses
{
    /// <summary>
    /// Builds and executes requests for operations under \businesses
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BusinessesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The lookup property</summary>
        public global::Marqeta.Core.Sdk.Businesses.Lookup.LookupRequestBuilder Lookup
        {
            get => new global::Marqeta.Core.Sdk.Businesses.Lookup.LookupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.businesses.item collection</summary>
        /// <param name="position">Business token</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Businesses.Item.Parent_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Businesses.Item.Parent_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("parent_token%2Did", position);
                return new global::Marqeta.Core.Sdk.Businesses.Item.Parent_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Businesses.BusinessesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BusinessesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/businesses{?business_name_dba*,business_name_legal*,count*,fields*,search_type*,sort_by*,start_index*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Businesses.BusinessesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BusinessesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/businesses{?business_name_dba*,business_name_legal*,count*,fields*,search_type*,sort_by*,start_index*}", rawUrl)
        {
        }
        /// <summary>
        /// Lists all businesses
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.BusinessCardHolderListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.BusinessCardHolderListResponse?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Businesses.BusinessesRequestBuilder.BusinessesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.BusinessCardHolderListResponse> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Businesses.BusinessesRequestBuilder.BusinessesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.BusinessCardHolderListResponse>(requestInfo, global::Marqeta.Core.Sdk.Models.BusinessCardHolderListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a business
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Business_card_holder_response"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.Business_card_holder_response?> PostAsync(global::Marqeta.Core.Sdk.Models.Business_cardholder body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.Business_card_holder_response> PostAsync(global::Marqeta.Core.Sdk.Models.Business_cardholder body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.Business_card_holder_response>(requestInfo, global::Marqeta.Core.Sdk.Models.Business_card_holder_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Lists all businesses
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Businesses.BusinessesRequestBuilder.BusinessesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Businesses.BusinessesRequestBuilder.BusinessesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Creates a business
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Business_cardholder body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Business_cardholder body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Businesses.BusinessesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Businesses.BusinessesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Businesses.BusinessesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Lists all businesses
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class BusinessesRequestBuilderGetQueryParameters 
        {
            /// <summary>Business name DBA</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("business_name_dba")]
            public string? BusinessNameDba { get; set; }
#nullable restore
#else
            [QueryParameter("business_name_dba")]
            public string BusinessNameDba { get; set; }
#endif
            /// <summary>Business name legal</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("business_name_legal")]
            public string? BusinessNameLegal { get; set; }
#nullable restore
#else
            [QueryParameter("business_name_legal")]
            public string BusinessNameLegal { get; set; }
#endif
            /// <summary>Number of users to retrieve</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Comma-delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string Fields { get; set; }
#endif
            /// <summary>Search type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("search_type")]
            public string? SearchType { get; set; }
#nullable restore
#else
            [QueryParameter("search_type")]
            public string SearchType { get; set; }
#endif
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
