// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.SimulationsV2.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.SimulationsV2.Simulations.Cardtransactions.AccountFundingAuthorizationReversal
{
    /// <summary>
    /// Builds and executes requests for operations under \simulations\cardtransactions\account.funding.authorization.reversal
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class AccountFundingAuthorizationReversalRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.SimulationsV2.Simulations.Cardtransactions.AccountFundingAuthorizationReversal.AccountFundingAuthorizationReversalRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountFundingAuthorizationReversalRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/simulations/cardtransactions/account.funding.authorization.reversal", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.SimulationsV2.Simulations.Cardtransactions.AccountFundingAuthorizationReversal.AccountFundingAuthorizationReversalRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AccountFundingAuthorizationReversalRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/simulations/cardtransactions/account.funding.authorization.reversal", rawUrl)
        {
        }
        /// <summary>
        /// Use this endpoint to simulate `account.funding.authorization.reversal` transactions.See the full request body structure at &lt;&lt;/core-api/simulations-card-transactions#SimulationRequestBody, Request body&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.SimulationsV2.Models.CardTransactionResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.SimulationsV2.Models.Error">When receiving a 404 status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.SimulationsV2.Models.CardTransactionResponse?> PostAsync(global::Marqeta.Core.Sdk.SimulationsV2.Models.AccountFundingAuthorizationReversalEvent body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.SimulationsV2.Models.CardTransactionResponse> PostAsync(global::Marqeta.Core.Sdk.SimulationsV2.Models.AccountFundingAuthorizationReversalEvent body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "404", global::Marqeta.Core.Sdk.SimulationsV2.Models.Error.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.SimulationsV2.Models.CardTransactionResponse>(requestInfo, global::Marqeta.Core.Sdk.SimulationsV2.Models.CardTransactionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Use this endpoint to simulate `account.funding.authorization.reversal` transactions.See the full request body structure at &lt;&lt;/core-api/simulations-card-transactions#SimulationRequestBody, Request body&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.SimulationsV2.Models.AccountFundingAuthorizationReversalEvent body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.SimulationsV2.Models.AccountFundingAuthorizationReversalEvent body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.SimulationsV2.Simulations.Cardtransactions.AccountFundingAuthorizationReversal.AccountFundingAuthorizationReversalRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.SimulationsV2.Simulations.Cardtransactions.AccountFundingAuthorizationReversal.AccountFundingAuthorizationReversalRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.SimulationsV2.Simulations.Cardtransactions.AccountFundingAuthorizationReversal.AccountFundingAuthorizationReversalRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
