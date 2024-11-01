// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Rewardprograms.Item.Balances;
using Marqeta.Core.Sdk.Rewardprograms.Item.Entries;
using Marqeta.Core.Sdk.Rewardprograms.Item.Journalentries;
using Marqeta.Core.Sdk.Rewardprograms.Item.Redemptions;
using Marqeta.Core.Sdk.Rewardprograms.Item.Rulesconfigs;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Rewardprograms.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \rewardprograms\{token}
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class WithTokenItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The balances property</summary>
        public global::Marqeta.Core.Sdk.Rewardprograms.Item.Balances.BalancesRequestBuilder Balances
        {
            get => new global::Marqeta.Core.Sdk.Rewardprograms.Item.Balances.BalancesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The entries property</summary>
        public global::Marqeta.Core.Sdk.Rewardprograms.Item.Entries.EntriesRequestBuilder Entries
        {
            get => new global::Marqeta.Core.Sdk.Rewardprograms.Item.Entries.EntriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The journalentries property</summary>
        public global::Marqeta.Core.Sdk.Rewardprograms.Item.Journalentries.JournalentriesRequestBuilder Journalentries
        {
            get => new global::Marqeta.Core.Sdk.Rewardprograms.Item.Journalentries.JournalentriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The redemptions property</summary>
        public global::Marqeta.Core.Sdk.Rewardprograms.Item.Redemptions.RedemptionsRequestBuilder Redemptions
        {
            get => new global::Marqeta.Core.Sdk.Rewardprograms.Item.Redemptions.RedemptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The rulesconfigs property</summary>
        public global::Marqeta.Core.Sdk.Rewardprograms.Item.Rulesconfigs.RulesconfigsRequestBuilder Rulesconfigs
        {
            get => new global::Marqeta.Core.Sdk.Rewardprograms.Item.Rulesconfigs.RulesconfigsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Rewardprograms.Item.WithTokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rewardprograms/{token}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Rewardprograms.Item.WithTokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithTokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rewardprograms/{token}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a specific reward program.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.RewardProgramsResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.RewardProgramsResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.RewardProgramsResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.RewardProgramsResponse>(requestInfo, global::Marqeta.Core.Sdk.Models.RewardProgramsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Activate or deactivate a specific reward program.[CAUTION]This endpoint is available for banks only.Do not use this endpoint if you are a brand contributor.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.RewardProgramsResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.RewardProgramsResponse?> PutAsync(global::Marqeta.Core.Sdk.Models.PutRewardProgramsRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.RewardProgramsResponse> PutAsync(global::Marqeta.Core.Sdk.Models.PutRewardProgramsRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.RewardProgramsResponse>(requestInfo, global::Marqeta.Core.Sdk.Models.RewardProgramsResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a specific reward program.
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
        /// Activate or deactivate a specific reward program.[CAUTION]This endpoint is available for banks only.Do not use this endpoint if you are a brand contributor.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(global::Marqeta.Core.Sdk.Models.PutRewardProgramsRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(global::Marqeta.Core.Sdk.Models.PutRewardProgramsRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Rewardprograms.Item.WithTokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Rewardprograms.Item.WithTokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Rewardprograms.Item.WithTokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
