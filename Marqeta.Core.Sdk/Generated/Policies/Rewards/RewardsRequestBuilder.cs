// <auto-generated/>
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Policies.Rewards.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Policies.Rewards {
    /// <summary>
    /// Builds and executes requests for operations under \policies\rewards
    /// </summary>
    public class RewardsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.policies.rewards.item collection</summary>
        /// <param name="position">Unique identifier of the reward policy to retrieve.Send a `GET` request to `/policies/rewards` to retrieve existing reward policy tokens.</param>
        /// <returns>A <see cref="WithTokenItemRequestBuilder"/></returns>
        public WithTokenItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("token", position);
            return new WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="RewardsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RewardsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/policies/rewards{?count*,sort_by*,start_index*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="RewardsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RewardsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/policies/rewards{?count*,sort_by*,start_index*}", rawUrl) {
        }
        /// <summary>
        /// Retrieve an array of reward policies.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="PolicyRewardPage"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PolicyRewardPage?> GetAsync(Action<RequestConfiguration<RewardsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PolicyRewardPage> GetAsync(Action<RequestConfiguration<RewardsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PolicyRewardPage>(requestInfo, PolicyRewardPage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a new reward policy.
        /// </summary>
        /// <returns>A <see cref="PolicyRewardResponse"/></returns>
        /// <param name="body">Request details for a reward policy.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PolicyRewardResponse?> PostAsync(PolicyRewardReq body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PolicyRewardResponse> PostAsync(PolicyRewardReq body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PolicyRewardResponse>(requestInfo, PolicyRewardResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve an array of reward policies.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt;.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RewardsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<RewardsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create a new reward policy.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Request details for a reward policy.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(PolicyRewardReq body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(PolicyRewardReq body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/policies/rewards", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="RewardsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public RewardsRequestBuilder WithUrl(string rawUrl) {
            return new RewardsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve an array of reward policies.This endpoint supports &lt;&lt;/core-api/sorting-and-pagination, sorting and pagination&gt;&gt;.
        /// </summary>
        public class RewardsRequestBuilderGetQueryParameters {
            /// <summary>Number of reward policy resources to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Field on which to sort.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.*NOTE:*You must sort using system field names such as `lastModifiedTime`, and not by the field names appearing in response bodies such as `last_modified_time`.</summary>
            [QueryParameter("sort_by")]
            public GetSort_byQueryParameterType? SortBy { get; set; }
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}
