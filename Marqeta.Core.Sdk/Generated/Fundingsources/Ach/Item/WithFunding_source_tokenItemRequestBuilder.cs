// <auto-generated/>
using Marqeta.Core.Sdk.Fundingsources.Ach.Item.Verificationamounts;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Fundingsources.Ach.Item {
    /// <summary>
    /// Builds and executes requests for operations under \fundingsources\ach\{funding_source_token}
    /// </summary>
    public class WithFunding_source_tokenItemRequestBuilder : BaseRequestBuilder 
    {
        /// <summary>The verificationamounts property</summary>
        public VerificationamountsRequestBuilder Verificationamounts
        {
            get => new VerificationamountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="WithFunding_source_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFunding_source_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/ach/{funding_source_token}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="WithFunding_source_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithFunding_source_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/ach/{funding_source_token}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a specific ACH funding source.The response body returns details about the account, including the verification status.Possible ACH verification status values are: `ACH_FAILED`, `ACH_VERIFIED`, and `VERIFICATION_PENDING`.
        /// </summary>
        /// <returns>A <see cref="Ach_response_model"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Ach_response_model?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Ach_response_model> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Ach_response_model>(requestInfo, Ach_response_model.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Verify or update an ACH funding source.If you are verifying the ACH source, include the verification amounts in the body of the request.ACH verification will fail if the verification amounts are not entered in the correct order.`verify_amount1` must match the first deposit amount, and `verify_amount2` must match the second.If you are updating the ACH source, include the `active` field instead.The `active` field is the only field you can update.
        /// </summary>
        /// <returns>A <see cref="Ach_response_model"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Ach_response_model?> PutAsync(Ach_verification_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Ach_response_model> PutAsync(Ach_verification_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                {"XXX", ApiError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Ach_response_model>(requestInfo, Ach_response_model.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a specific ACH funding source.The response body returns details about the account, including the verification status.Possible ACH verification status values are: `ACH_FAILED`, `ACH_VERIFIED`, and `VERIFICATION_PENDING`.
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
        /// Verify or update an ACH funding source.If you are verifying the ACH source, include the verification amounts in the body of the request.ACH verification will fail if the verification amounts are not entered in the correct order.`verify_amount1` must match the first deposit amount, and `verify_amount2` must match the second.If you are updating the ACH source, include the `active` field instead.The `active` field is the only field you can update.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(Ach_verification_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(Ach_verification_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="WithFunding_source_tokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WithFunding_source_tokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new WithFunding_source_tokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
