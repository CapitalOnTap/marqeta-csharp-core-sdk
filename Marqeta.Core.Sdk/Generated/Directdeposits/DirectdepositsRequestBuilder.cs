// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Directdeposits.Accounts;
using Marqeta.Core.Sdk.Directdeposits.Item;
using Marqeta.Core.Sdk.Directdeposits.Transitions;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Directdeposits
{
    /// <summary>
    /// Builds and executes requests for operations under \directdeposits
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DirectdepositsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The accounts property</summary>
        public global::Marqeta.Core.Sdk.Directdeposits.Accounts.AccountsRequestBuilder Accounts
        {
            get => new global::Marqeta.Core.Sdk.Directdeposits.Accounts.AccountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transitions property</summary>
        public global::Marqeta.Core.Sdk.Directdeposits.Transitions.TransitionsRequestBuilder Transitions
        {
            get => new global::Marqeta.Core.Sdk.Directdeposits.Transitions.TransitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.directdeposits.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Directdeposits.Item.WithTokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Directdeposits.Item.WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new global::Marqeta.Core.Sdk.Directdeposits.Item.WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Directdeposits.DirectdepositsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectdepositsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directdeposits{?business_token*,count*,direct_deposit_state*,end_settlement_date*,reversed_after_grace_period*,sort_by*,start_index*,start_settlement_date*,user_token*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Directdeposits.DirectdepositsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectdepositsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directdeposits{?business_token*,count*,direct_deposit_state*,end_settlement_date*,reversed_after_grace_period*,sort_by*,start_index*,start_settlement_date*,user_token*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves a list of all direct deposit records for your program.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.DirectDepositListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.DirectDepositListResponse?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Directdeposits.DirectdepositsRequestBuilder.DirectdepositsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.DirectDepositListResponse> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Directdeposits.DirectdepositsRequestBuilder.DirectdepositsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.DirectDepositListResponse>(requestInfo, global::Marqeta.Core.Sdk.Models.DirectDepositListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves a list of all direct deposit records for your program.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Directdeposits.DirectdepositsRequestBuilder.DirectdepositsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Directdeposits.DirectdepositsRequestBuilder.DirectdepositsRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Directdeposits.DirectdepositsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Directdeposits.DirectdepositsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Directdeposits.DirectdepositsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves a list of all direct deposit records for your program.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DirectdepositsRequestBuilderGetQueryParameters 
        {
            /// <summary>Business token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("business_token")]
            public string? BusinessToken { get; set; }
#nullable restore
#else
            [QueryParameter("business_token")]
            public string BusinessToken { get; set; }
#endif
            /// <summary>The number of direct deposit records to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Comma-delimited list of direct deposit states to display e.g. PENDING | REVERSED | APPLIED | REJECTED </summary>
            [QueryParameter("direct_deposit_state")]
            public global::Marqeta.Core.Sdk.Directdeposits.GetDirect_deposit_stateQueryParameterType? DirectDepositState { get; set; }
            /// <summary>End Settlement Date</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("end_settlement_date")]
            public string? EndSettlementDate { get; set; }
#nullable restore
#else
            [QueryParameter("end_settlement_date")]
            public string EndSettlementDate { get; set; }
#endif
            /// <summary>Reversed after grace period</summary>
            [QueryParameter("reversed_after_grace_period")]
            public bool? ReversedAfterGracePeriod { get; set; }
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
            /// <summary>Start Settlement Date</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("start_settlement_date")]
            public string? StartSettlementDate { get; set; }
#nullable restore
#else
            [QueryParameter("start_settlement_date")]
            public string StartSettlementDate { get; set; }
#endif
            /// <summary>User token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("user_token")]
            public string? UserToken { get; set; }
#nullable restore
#else
            [QueryParameter("user_token")]
            public string UserToken { get; set; }
#endif
        }
    }
}
#pragma warning restore CS0618
