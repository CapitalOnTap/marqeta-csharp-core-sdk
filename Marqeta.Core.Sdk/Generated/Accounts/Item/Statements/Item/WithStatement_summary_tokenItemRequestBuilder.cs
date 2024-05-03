// <auto-generated/>
using Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Files;
using Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Interestcharges;
using Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Journalentries;
using Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Ledgerentries;
using Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Paymentinfo;
using Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Paymentreminders;
using Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Rewards;
using Marqeta.Core.Sdk.Accounts.Item.Statements.Item.Yeartodate;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Accounts.Item.Statements.Item {
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_token}\statements\{statement_summary_token}
    /// </summary>
    public class WithStatement_summary_tokenItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The files property</summary>
        public FilesRequestBuilder Files
        {
            get => new FilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The interestcharges property</summary>
        public InterestchargesRequestBuilder Interestcharges
        {
            get => new InterestchargesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The journalentries property</summary>
        public JournalentriesRequestBuilder Journalentries
        {
            get => new JournalentriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ledgerentries property</summary>
        public LedgerentriesRequestBuilder Ledgerentries
        {
            get => new LedgerentriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The paymentinfo property</summary>
        public PaymentinfoRequestBuilder Paymentinfo
        {
            get => new PaymentinfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The paymentreminders property</summary>
        public PaymentremindersRequestBuilder Paymentreminders
        {
            get => new PaymentremindersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rewards property</summary>
        public RewardsRequestBuilder Rewards
        {
            get => new RewardsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The yeartodate property</summary>
        public YeartodateRequestBuilder Yeartodate
        {
            get => new YeartodateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithStatement_summary_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithStatement_summary_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/statements/{statement_summary_token}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithStatement_summary_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithStatement_summary_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/statements/{statement_summary_token}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a statement summary for a credit account.
        /// </summary>
        /// <returns>A <see cref="StatementSummary"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<StatementSummary?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<StatementSummary> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<StatementSummary>(requestInfo, StatementSummary.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a statement summary for a credit account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="WithStatement_summary_tokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithStatement_summary_tokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithStatement_summary_tokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
