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
namespace Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Journalentries {
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_token}\statements\{statement_summary_token}\journalentries
    /// </summary>
    public class JournalentriesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="JournalentriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JournalentriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/statements/{statement_summary_token}/journalentries{?count*,expand*,sort_by*,start_index*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="JournalentriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JournalentriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/statements/{statement_summary_token}/journalentries{?count*,expand*,sort_by*,start_index*}", rawUrl) {
        }
        /// <summary>
        /// Retrieve an array of journal entries on a credit account&apos;s statement summary.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="JournalEntriesPage"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JournalEntriesPage?> GetAsync(Action<RequestConfiguration<JournalentriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<JournalEntriesPage> GetAsync(Action<RequestConfiguration<JournalentriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<JournalEntriesPage>(requestInfo, JournalEntriesPage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve an array of journal entries on a credit account&apos;s statement summary.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<JournalentriesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<JournalentriesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="JournalentriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public JournalentriesRequestBuilder WithUrl(string rawUrl) {
            return new JournalentriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve an array of journal entries on a credit account&apos;s statement summary.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting&gt;&gt;.
        /// </summary>
        public class JournalentriesRequestBuilderGetQueryParameters {
            /// <summary>Specifies the number of journal entries to return.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Embeds the specified object into the response.</summary>
            [QueryParameter("expand")]
            public GetExpandQueryParameterType? Expand { get; set; }
            /// <summary>Field on which to sort.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.*NOTE:*You must sort using system field names such as `lastModifiedTime`, and not by the field names appearing in response bodies such as `last_modified_time`.</summary>
            [QueryParameter("sort_by")]
            public GetSort_byQueryParameterType? SortBy { get; set; }
            /// <summary>Specifies the sort order index from which to begin returning journal entries.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}