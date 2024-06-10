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
namespace Marqeta.Core.Sdk.Rewardprograms.Item.Balances
{
    /// <summary>
    /// Builds and executes requests for operations under \rewardprograms\{token}\balances
    /// </summary>
    public class BalancesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Rewardprograms.Item.Balances.BalancesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BalancesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rewardprograms/{token}/balances", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Rewardprograms.Item.Balances.BalancesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BalancesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rewardprograms/{token}/balances", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve the balances for a specific reward program.The reward accrual service calculates values to four-decimal precision, however the `/credit/rewardprograms/{token}/entries/balance` endpoint returns pending and accrued balances to two-decimal precision.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.RewardProgramsBalancesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.RewardProgramsBalancesResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.RewardProgramsBalancesResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.RewardProgramsBalancesResponse>(requestInfo, Marqeta.Core.Sdk.Models.RewardProgramsBalancesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the balances for a specific reward program.The reward accrual service calculates values to four-decimal precision, however the `/credit/rewardprograms/{token}/entries/balance` endpoint returns pending and accrued balances to two-decimal precision.
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
        /// <returns>A <see cref="Marqeta.Core.Sdk.Rewardprograms.Item.Balances.BalancesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Rewardprograms.Item.Balances.BalancesRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Rewardprograms.Item.Balances.BalancesRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
