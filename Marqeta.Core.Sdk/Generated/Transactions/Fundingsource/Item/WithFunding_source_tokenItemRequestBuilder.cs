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
namespace Marqeta.Core.Sdk.Transactions.Fundingsource.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \transactions\fundingsource\{funding_source_token}
    /// </summary>
    public class WithFunding_source_tokenItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFunding_source_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/transactions/fundingsource/{funding_source_token}{?count*,end_date*,fields*,polarity*,sort_by*,start_date*,start_index*,type*,verbose*,version*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFunding_source_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/transactions/fundingsource/{funding_source_token}{?count*,end_date*,fields*,polarity*,sort_by*,start_date*,start_index*,type*,verbose*,version*}", rawUrl)
        {
        }
        /// <summary>
        /// List transactions for a specific funding source.By default, this endpoint returns transactions conducted within the last 30 days.To return transactions older than 30 days, you must include the `start_date` and `end_date` query parameters in your request.By default, `GET /transactions/fundingsource/{funding_source_token}` returns transactions having either `PENDING` or `COMPLETION` states.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.TransactionModelListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.TransactionModelListResponse?> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder.WithFunding_source_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.TransactionModelListResponse> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder.WithFunding_source_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.TransactionModelListResponse>(requestInfo, Marqeta.Core.Sdk.Models.TransactionModelListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List transactions for a specific funding source.By default, this endpoint returns transactions conducted within the last 30 days.To return transactions older than 30 days, you must include the `start_date` and `end_date` query parameters in your request.By default, `GET /transactions/fundingsource/{funding_source_token}` returns transactions having either `PENDING` or `COMPLETION` states.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder.WithFunding_source_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder.WithFunding_source_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Transactions.Fundingsource.Item.WithFunding_source_tokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List transactions for a specific funding source.By default, this endpoint returns transactions conducted within the last 30 days.To return transactions older than 30 days, you must include the `start_date` and `end_date` query parameters in your request.By default, `GET /transactions/fundingsource/{funding_source_token}` returns transactions having either `PENDING` or `COMPLETION` states.This endpoint supports &lt;&lt;/core-api/field-filtering, field filtering&gt;&gt; and &lt;&lt;/core-api/sorting-and-pagination, pagination&gt;&gt;.
        /// </summary>
        public class WithFunding_source_tokenItemRequestBuilderGetQueryParameters 
        {
            /// <summary>The number of transactions to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>The ending date (or date-time) of a date range from which to return transactions.To return transactions for a single day, enter the same date in both the `end_date` and `start_date` fields.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("end_date")]
            public string? EndDate { get; set; }
#nullable restore
#else
            [QueryParameter("end_date")]
            public string EndDate { get; set; }
#endif
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
            /// <summary>Specifies whether to return credit or debit transactions.</summary>
            [QueryParameter("polarity")]
            public Marqeta.Core.Sdk.Transactions.Fundingsource.Item.GetPolarityQueryParameterType? Polarity { get; set; }
            /// <summary>Field on which to sort.Use any field in the resource model, or one of the system fields `lastModifiedTime` or `createdTime`.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.</summary>
            [QueryParameter("sort_by")]
            public Marqeta.Core.Sdk.Transactions.Fundingsource.Item.GetSort_byQueryParameterType? SortBy { get; set; }
            /// <summary>The starting date (or date-time) of a date range from which to return transactions.To return transactions for a single day, enter the same date in both the `start_date` and `end_date` fields.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("start_date")]
            public string? StartDate { get; set; }
#nullable restore
#else
            [QueryParameter("start_date")]
            public string StartDate { get; set; }
#endif
            /// <summary>The sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
            /// <summary>Comma-delimited list of transaction types to include.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("type")]
            public string? Type { get; set; }
#nullable restore
#else
            [QueryParameter("type")]
            public string Type { get; set; }
#endif
            /// <summary>If `true`, the query returns additional information for diagnostic purposes.</summary>
            [QueryParameter("verbose")]
            public bool? Verbose { get; set; }
            /// <summary>Specifies the API version for the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("version")]
            public string? Version { get; set; }
#nullable restore
#else
            [QueryParameter("version")]
            public string Version { get; set; }
#endif
        }
    }
}
