// <auto-generated/>
using Marqeta.Core.Sdk.Accounts.Item.Disputes.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Accounts.Item.Disputes
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_token}\disputes
    /// </summary>
    public class DisputesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.accounts.item.disputes.item collection</summary>
        /// <param name="position">Unique identifier of the dispute to retrieve.Send a `GET` request to `/credit/accounts/{account_token}/disputes` to retrieve existing dispute tokens.</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Accounts.Item.Disputes.Item.WithDispute_tokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Accounts.Item.Disputes.Item.WithDispute_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("dispute_token", position);
                return new Marqeta.Core.Sdk.Accounts.Item.Disputes.Item.WithDispute_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DisputesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/disputes{?count*,sort_by*,start_index*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DisputesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/disputes{?count*,sort_by*,start_index*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve an array of disputes on a credit account.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.DisputeResponsePage"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.DisputeResponsePage?> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder.DisputesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.DisputeResponsePage> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder.DisputesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.DisputeResponsePage>(requestInfo, Marqeta.Core.Sdk.Models.DisputeResponsePage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a dispute of a journal entry on a credit account.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.DisputeResponse"/></returns>
        /// <param name="body">Information about a transaction dispute creation request.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.DisputeResponse?> PostAsync(Marqeta.Core.Sdk.Models.DisputeCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.DisputeResponse> PostAsync(Marqeta.Core.Sdk.Models.DisputeCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.DisputeResponse>(requestInfo, Marqeta.Core.Sdk.Models.DisputeResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve an array of disputes on a credit account.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder.DisputesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder.DisputesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a dispute of a journal entry on a credit account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Information about a transaction dispute creation request.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Marqeta.Core.Sdk.Models.DisputeCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Marqeta.Core.Sdk.Models.DisputeCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve an array of disputes on a credit account.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt;.
        /// </summary>
        public class DisputesRequestBuilderGetQueryParameters 
        {
            /// <summary>Number of disputes resources to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Field on which to sort.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.*NOTE:*You must sort using system field names such as `lastModifiedTime`, and not by the field names appearing in response bodies such as `last_modified_time`.</summary>
            [QueryParameter("sort_by")]
            public Marqeta.Core.Sdk.Accounts.Item.Disputes.GetSort_byQueryParameterType? SortBy { get; set; }
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}
