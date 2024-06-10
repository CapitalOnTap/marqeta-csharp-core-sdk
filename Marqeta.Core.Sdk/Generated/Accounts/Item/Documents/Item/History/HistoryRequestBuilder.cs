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
namespace Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_token}\documents\{document_type}\history
    /// </summary>
    public class HistoryRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History.HistoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HistoryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/documents/{document_type}/history{?count*,sort_by*,start_index*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History.HistoryRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public HistoryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/documents/{document_type}/history{?count*,sort_by*,start_index*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve the history of a specific type of document on a credit account.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.AccountDocumentsPage"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.AccountDocumentsPage?> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History.HistoryRequestBuilder.HistoryRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.AccountDocumentsPage> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History.HistoryRequestBuilder.HistoryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.AccountDocumentsPage>(requestInfo, Marqeta.Core.Sdk.Models.AccountDocumentsPage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the history of a specific type of document on a credit account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History.HistoryRequestBuilder.HistoryRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History.HistoryRequestBuilder.HistoryRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History.HistoryRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History.HistoryRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History.HistoryRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve the history of a specific type of document on a credit account.
        /// </summary>
        public class HistoryRequestBuilderGetQueryParameters 
        {
            /// <summary>Number of account document resources to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Field on which to sort.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.*NOTE:*You must sort using system field names such as `effectiveDate`, and not by the field names appearing in response bodies such as `effective_date`.</summary>
            [QueryParameter("sort_by")]
            public Marqeta.Core.Sdk.Accounts.Item.Documents.Item.History.GetSort_byQueryParameterType? SortBy { get; set; }
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}
