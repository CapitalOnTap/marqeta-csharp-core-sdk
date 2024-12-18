// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_token}\statements\{statement_summary_token}\ledgerentries
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class LedgerentriesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.LedgerentriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LedgerentriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/statements/{statement_summary_token}/ledgerentries{?expand*,sort_by*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.LedgerentriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public LedgerentriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/statements/{statement_summary_token}/ledgerentries{?expand*,sort_by*}", rawUrl)
        {
        }
        /// <summary>
        /// [IMPORTANT]This feature is being deprecated and replaced by statement journal entries.To list statement journal entries, see &lt;&lt;/core-api/credit-account-journal-entries#listStatementJournalEntries, List account statement journal entries&gt;&gt;.Retrieve an array of ledger entries on a credit account&apos;s statement summary.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting&gt;&gt;.
        /// </summary>
        /// <returns>A List&lt;global::Marqeta.Core.Sdk.Models.LedgerEntry&gt;</returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<global::Marqeta.Core.Sdk.Models.LedgerEntry>?> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.LedgerentriesRequestBuilder.LedgerentriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<List<global::Marqeta.Core.Sdk.Models.LedgerEntry>> GetAsync(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.LedgerentriesRequestBuilder.LedgerentriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<global::Marqeta.Core.Sdk.Models.LedgerEntry>(requestInfo, global::Marqeta.Core.Sdk.Models.LedgerEntry.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
            return collectionResult?.AsList();
        }
        /// <summary>
        /// [IMPORTANT]This feature is being deprecated and replaced by statement journal entries.To list statement journal entries, see &lt;&lt;/core-api/credit-account-journal-entries#listStatementJournalEntries, List account statement journal entries&gt;&gt;.Retrieve an array of ledger entries on a credit account&apos;s statement summary.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.LedgerentriesRequestBuilder.LedgerentriesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.LedgerentriesRequestBuilder.LedgerentriesRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.LedgerentriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.LedgerentriesRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.LedgerentriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// [IMPORTANT]This feature is being deprecated and replaced by statement journal entries.To list statement journal entries, see &lt;&lt;/core-api/credit-account-journal-entries#listStatementJournalEntries, List account statement journal entries&gt;&gt;.Retrieve an array of ledger entries on a credit account&apos;s statement summary.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting&gt;&gt;.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class LedgerentriesRequestBuilderGetQueryParameters 
        {
            /// <summary>Embeds the specified object into the response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.GetExpandQueryParameterType[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.GetExpandQueryParameterType[] Expand { get; set; }
#endif
            /// <summary>Field on which to sort.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.*NOTE:*You must sort using system field names such as `lastModifiedTime`, and not by the field names appearing in response bodies such as `last_modified_time`.</summary>
            [QueryParameter("sort_by")]
            public global::Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries.GetSort_byQueryParameterType? SortBy { get; set; }
        }
    }
}
#pragma warning restore CS0618
