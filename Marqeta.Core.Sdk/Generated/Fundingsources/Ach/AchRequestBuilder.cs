// <auto-generated/>
using Marqeta.Core.Sdk.Fundingsources.Ach.Item;
using Marqeta.Core.Sdk.Fundingsources.Ach.Partner;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Fundingsources.Ach {
    /// <summary>
    /// Builds and executes requests for operations under \fundingsources\ach
    /// </summary>
    public class AchRequestBuilder : BaseRequestBuilder {
        /// <summary>The partner property</summary>
        public PartnerRequestBuilder Partner { get =>
            new PartnerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.fundingsources.ach.item collection</summary>
        /// <param name="position">Unique identifier of the funding source.Send a `GET` request to `/fundingsources/user/{user_token}` to retrieve existing funding source tokens for a user or to `/fundingsources/business/{business_token}` to retrieve existing funding source tokens for a business.</param>
        /// <returns>A <see cref="WithFunding_source_tokenItemRequestBuilder"/></returns>
        public WithFunding_source_tokenItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("funding_source_token", position);
            return new WithFunding_source_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new <see cref="AchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/ach", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new <see cref="AchRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/ach", rawUrl) {
        }
        /// <summary>
        /// Create an ACH funding source for an existing account holder.Specify the account holder of the funding source by passing a user or business token.When adding an ACH funding source, a small amount is deposited in the bank account as a test.The test deposit should be reflected in the account after two to three business days.You must then make an API call to verify the deposit amount in order to activate the ACH account.See &lt;&lt;/core-api/account-holder-funding-sources#putFundingsourcesAchFundingsourcetoken, Verify or Update ACH Funding Source&gt;&gt; on this page for more information.The response body returns details about the account, including the verification status.Possible ACH verification status values include `ACH_VERIFIED`, `ACH_FAILED`, and `VERIFICATION_PENDING`.
        /// </summary>
        /// <returns>A <see cref="Ach_response_model"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Ach_response_model?> PostAsync(Ach_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Ach_response_model> PostAsync(Ach_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Ach_response_model>(requestInfo, Ach_response_model.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create an ACH funding source for an existing account holder.Specify the account holder of the funding source by passing a user or business token.When adding an ACH funding source, a small amount is deposited in the bank account as a test.The test deposit should be reflected in the account after two to three business days.You must then make an API call to verify the deposit amount in order to activate the ACH account.See &lt;&lt;/core-api/account-holder-funding-sources#putFundingsourcesAchFundingsourcetoken, Verify or Update ACH Funding Source&gt;&gt; on this page for more information.The response body returns details about the account, including the verification status.Possible ACH verification status values include `ACH_VERIFIED`, `ACH_FAILED`, and `VERIFICATION_PENDING`.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Ach_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Ach_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        /// <returns>A <see cref="AchRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AchRequestBuilder WithUrl(string rawUrl) {
            return new AchRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
