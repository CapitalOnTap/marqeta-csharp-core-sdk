// <auto-generated/>
using Marqeta.Core.Sdk.Credit.Rewardprograms.Item.Entries.Balance;
using Marqeta.Core.Sdk.Credit.Rewardprograms.Item.Entries.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Credit.Rewardprograms.Item.Entries {
    /// <summary>
    /// Builds and executes requests for operations under \credit\rewardprograms\{token}\entries
    /// </summary>
    public class EntriesRequestBuilder : BaseRequestBuilder {
        /// <summary>The balance property</summary>
        public BalanceRequestBuilder Balance { get =>
            new BalanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.credit.rewardprograms.item.entries.item collection</summary>
        /// <param name="position">Unique identifier of the reward entry to retrieve.</param>
        /// <returns>A <see cref="WithEntry_tokenItemRequestBuilder"/></returns>
        public WithEntry_tokenItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("entry_token", position);
            return new WithEntry_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="EntriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EntriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/credit/rewardprograms/{token}/entries{?count*,end_date*,sort_by*,start_date*,start_index*,status*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="EntriesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EntriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/credit/rewardprograms/{token}/entries{?count*,end_date*,sort_by*,start_date*,start_index*,status*}", rawUrl) {
        }
        /// <summary>
        /// Retrieve an array of reward entries on a specific reward program.The reward accrual service calculates values to a 4 point precision, however the retrieve reward balance endpoint returns pending and accrued balances to a 2 point precision
        /// </summary>
        /// <returns>A <see cref="RewardProgramsEntriesPage"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RewardProgramsEntriesPage?> GetAsync(Action<RequestConfiguration<EntriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RewardProgramsEntriesPage> GetAsync(Action<RequestConfiguration<EntriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RewardProgramsEntriesPage>(requestInfo, RewardProgramsEntriesPage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a reward entry on a specific reward program.Use this endpoint to manually create a reward entry if an existing reward is being disputed.
        /// </summary>
        /// <returns>A <see cref="RewardProgramsEntriesResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<RewardProgramsEntriesResponse?> PostAsync(CreateRewardProgramsEntriesRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<RewardProgramsEntriesResponse> PostAsync(CreateRewardProgramsEntriesRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<RewardProgramsEntriesResponse>(requestInfo, RewardProgramsEntriesResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve an array of reward entries on a specific reward program.The reward accrual service calculates values to a 4 point precision, however the retrieve reward balance endpoint returns pending and accrued balances to a 2 point precision
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EntriesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EntriesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a reward entry on a specific reward program.Use this endpoint to manually create a reward entry if an existing reward is being disputed.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CreateRewardProgramsEntriesRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CreateRewardProgramsEntriesRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/credit/rewardprograms/{token}/entries", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="EntriesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public EntriesRequestBuilder WithUrl(string rawUrl) {
            return new EntriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve an array of reward entries on a specific reward program.The reward accrual service calculates values to a 4 point precision, however the retrieve reward balance endpoint returns pending and accrued balances to a 2 point precision
        /// </summary>
        public class EntriesRequestBuilderGetQueryParameters {
            /// <summary>Number of resources to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>The ending date (or date-time) of a date range from which to return resources, in UTC.</summary>
            [QueryParameter("end_date")]
            public DateTimeOffset? EndDate { get; set; }
            /// <summary>Field on which to sort.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.*NOTE*:You must sort using system field names such as `createdTime`, and not by the field names appearing in response bodies such as `created_time`.</summary>
            [QueryParameter("sort_by")]
            public GetSort_byQueryParameterType? SortBy { get; set; }
            /// <summary>The starting date (or date-time) of a date range from which to return resources, in UTC.</summary>
            [QueryParameter("start_date")]
            public DateTimeOffset? StartDate { get; set; }
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public long? StartIndex { get; set; }
            /// <summary>Status of the reward entries in the returned array.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("status")]
            public RewardEntryStatus[]? Status { get; set; }
#nullable restore
#else
            [QueryParameter("status")]
            public RewardEntryStatus[] Status { get; set; }
#endif
        }
    }
}
