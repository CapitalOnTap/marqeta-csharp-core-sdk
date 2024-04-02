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
namespace Marqeta.Core.Sdk.Credit.Rewardprograms.Item.Redemptions.Balance {
    /// <summary>
    /// Builds and executes requests for operations under \credit\rewardprograms\{token}\redemptions\balance
    /// </summary>
    public class BalanceRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="BalanceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BalanceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/credit/rewardprograms/{token}/redemptions/balance{?end_date*,start_date*,type*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="BalanceRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BalanceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/credit/rewardprograms/{token}/redemptions/balance{?end_date*,start_date*,type*}", rawUrl) {
        }
        /// <summary>
        /// Retrieve the balance for reward redemptions within a specified date range.
        /// </summary>
        /// <returns>A <see cref="RedemptionsBalanceResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RedemptionsBalanceResponse?> GetAsync(Action<RequestConfiguration<BalanceRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RedemptionsBalanceResponse> GetAsync(Action<RequestConfiguration<BalanceRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RedemptionsBalanceResponse>(requestInfo, RedemptionsBalanceResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the balance for reward redemptions within a specified date range.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BalanceRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BalanceRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="BalanceRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public BalanceRequestBuilder WithUrl(string rawUrl) {
            return new BalanceRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve the balance for reward redemptions within a specified date range.
        /// </summary>
        public class BalanceRequestBuilderGetQueryParameters {
            /// <summary>The ending date (or date-time) of a date range from which to return resources, in UTC.</summary>
            [QueryParameter("end_date")]
            public DateTimeOffset? EndDate { get; set; }
            /// <summary>The starting date (or date-time) of a date range from which to return resources, in UTC.</summary>
            [QueryParameter("start_date")]
            public DateTimeOffset? StartDate { get; set; }
            /// <summary>Type of reward redemptions in the returned array.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("type")]
            public RedemptionType[]? Type { get; set; }
#nullable restore
#else
            [QueryParameter("type")]
            public RedemptionType[] Type { get; set; }
#endif
        }
    }
}