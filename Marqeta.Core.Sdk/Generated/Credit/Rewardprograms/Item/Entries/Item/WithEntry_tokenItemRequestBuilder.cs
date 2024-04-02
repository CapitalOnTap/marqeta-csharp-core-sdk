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
namespace Marqeta.Core.Sdk.Credit.Rewardprograms.Item.Entries.Item {
    /// <summary>
    /// Builds and executes requests for operations under \credit\rewardprograms\{token}\entries\{entry_token}
    /// </summary>
    public class WithEntry_tokenItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new <see cref="WithEntry_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEntry_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/credit/rewardprograms/{token}/entries/{entry_token}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithEntry_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithEntry_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/credit/rewardprograms/{token}/entries/{entry_token}", rawUrl) {
        }
        /// <summary>
        /// Retrieve a specific reward entry on a reward program.The reward accrual service calculates values to a 4 point precision, however the retrieve reward balance endpoint returns pending and accrued balances to a 2 point precision
        /// </summary>
        /// <returns>A <see cref="RewardProgramsEntriesResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RewardProgramsEntriesResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RewardProgramsEntriesResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RewardProgramsEntriesResponse>(requestInfo, RewardProgramsEntriesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a specific reward entry on a reward program.The reward accrual service calculates values to a 4 point precision, however the retrieve reward balance endpoint returns pending and accrued balances to a 2 point precision
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="WithEntry_tokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithEntry_tokenItemRequestBuilder WithUrl(string rawUrl) {
            return new WithEntry_tokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}