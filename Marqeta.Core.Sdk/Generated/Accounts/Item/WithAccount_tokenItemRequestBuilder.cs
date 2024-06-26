// <auto-generated/>
using Marqeta.Core.Sdk.Accounts.Item.Accounttransitions;
using Marqeta.Core.Sdk.Accounts.Item.Adjustments;
using Marqeta.Core.Sdk.Accounts.Item.Billingcycle;
using Marqeta.Core.Sdk.Accounts.Item.Cards;
using Marqeta.Core.Sdk.Accounts.Item.Creditbalancerefunds;
using Marqeta.Core.Sdk.Accounts.Item.Delinquencystate;
using Marqeta.Core.Sdk.Accounts.Item.Disputes;
using Marqeta.Core.Sdk.Accounts.Item.Documents;
using Marqeta.Core.Sdk.Accounts.Item.Journalentries;
using Marqeta.Core.Sdk.Accounts.Item.Ledgerentries;
using Marqeta.Core.Sdk.Accounts.Item.Payments;
using Marqeta.Core.Sdk.Accounts.Item.Paymentschedules;
using Marqeta.Core.Sdk.Accounts.Item.Periodicfeeschedules;
using Marqeta.Core.Sdk.Accounts.Item.Rewards;
using Marqeta.Core.Sdk.Accounts.Item.Statements;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Accounts.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_token}
    /// </summary>
    public class WithAccount_tokenItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The accounttransitions property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Accounttransitions.AccounttransitionsRequestBuilder Accounttransitions
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Accounttransitions.AccounttransitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The adjustments property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Adjustments.AdjustmentsRequestBuilder Adjustments
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Adjustments.AdjustmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The billingcycle property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Billingcycle.BillingcycleRequestBuilder Billingcycle
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Billingcycle.BillingcycleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The cards property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Cards.CardsRequestBuilder Cards
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Cards.CardsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The creditbalancerefunds property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Creditbalancerefunds.CreditbalancerefundsRequestBuilder Creditbalancerefunds
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Creditbalancerefunds.CreditbalancerefundsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The delinquencystate property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Delinquencystate.DelinquencystateRequestBuilder Delinquencystate
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Delinquencystate.DelinquencystateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The disputes property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder Disputes
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Disputes.DisputesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The documents property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Documents.DocumentsRequestBuilder Documents
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Documents.DocumentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The journalentries property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder Journalentries
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Journalentries.JournalentriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ledgerentries property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Ledgerentries.LedgerentriesRequestBuilder Ledgerentries
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Ledgerentries.LedgerentriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The payments property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Payments.PaymentsRequestBuilder Payments
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Payments.PaymentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The paymentschedules property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.PaymentschedulesRequestBuilder Paymentschedules
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.PaymentschedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The periodicfeeschedules property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Periodicfeeschedules.PeriodicfeeschedulesRequestBuilder Periodicfeeschedules
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Periodicfeeschedules.PeriodicfeeschedulesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rewards property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Rewards.RewardsRequestBuilder Rewards
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Rewards.RewardsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The statements property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Statements.StatementsRequestBuilder Statements
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Statements.StatementsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.WithAccount_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAccount_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}{?effective_fee_schedule_only*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.WithAccount_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithAccount_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}{?effective_fee_schedule_only*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a credit account.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.AccountResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.AccountResponse?> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.WithAccount_tokenItemRequestBuilder.WithAccount_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.AccountResponse> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.WithAccount_tokenItemRequestBuilder.WithAccount_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.AccountResponse>(requestInfo, Marqeta.Core.Sdk.Models.AccountResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update a credit account.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.AccountResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.AccountResponse?> PutAsync(Marqeta.Core.Sdk.Models.AccountUpdateReq body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.AccountResponse> PutAsync(Marqeta.Core.Sdk.Models.AccountUpdateReq body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.AccountResponse>(requestInfo, Marqeta.Core.Sdk.Models.AccountResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a credit account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.WithAccount_tokenItemRequestBuilder.WithAccount_tokenItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.WithAccount_tokenItemRequestBuilder.WithAccount_tokenItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update a credit account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Marqeta.Core.Sdk.Models.AccountUpdateReq body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Marqeta.Core.Sdk.Models.AccountUpdateReq body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PUT, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Accounts.Item.WithAccount_tokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Accounts.Item.WithAccount_tokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Accounts.Item.WithAccount_tokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve a credit account.
        /// </summary>
        public class WithAccount_tokenItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Display the effective fee schedule only.</summary>
            [QueryParameter("effective_fee_schedule_only")]
            public bool? EffectiveFeeScheduleOnly { get; set; }
        }
    }
}
