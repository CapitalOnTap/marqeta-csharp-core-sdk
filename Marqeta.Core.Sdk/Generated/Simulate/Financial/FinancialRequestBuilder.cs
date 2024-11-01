// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Simulate.Financial.Advice;
using Marqeta.Core.Sdk.Simulate.Financial.Balanceinquiry;
using Marqeta.Core.Sdk.Simulate.Financial.Originalcredit;
using Marqeta.Core.Sdk.Simulate.Financial.Withdrawal;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Simulate.Financial
{
    /// <summary>
    /// Builds and executes requests for operations under \simulate\financial
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class FinancialRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The advice property</summary>
        public global::Marqeta.Core.Sdk.Simulate.Financial.Advice.AdviceRequestBuilder Advice
        {
            get => new global::Marqeta.Core.Sdk.Simulate.Financial.Advice.AdviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The balanceinquiry property</summary>
        public global::Marqeta.Core.Sdk.Simulate.Financial.Balanceinquiry.BalanceinquiryRequestBuilder Balanceinquiry
        {
            get => new global::Marqeta.Core.Sdk.Simulate.Financial.Balanceinquiry.BalanceinquiryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The originalcredit property</summary>
        public global::Marqeta.Core.Sdk.Simulate.Financial.Originalcredit.OriginalcreditRequestBuilder Originalcredit
        {
            get => new global::Marqeta.Core.Sdk.Simulate.Financial.Originalcredit.OriginalcreditRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The withdrawal property</summary>
        public global::Marqeta.Core.Sdk.Simulate.Financial.Withdrawal.WithdrawalRequestBuilder Withdrawal
        {
            get => new global::Marqeta.Core.Sdk.Simulate.Financial.Withdrawal.WithdrawalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Simulate.Financial.FinancialRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FinancialRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/simulate/financial", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Simulate.Financial.FinancialRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FinancialRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/simulate/financial", rawUrl)
        {
        }
        /// <summary>
        /// Simulates a financial request (PIN debit) transaction with optional cash back
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Simulation_response_model"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.Simulation_response_model?> PostAsync(global::Marqeta.Core.Sdk.Models.Financial_request_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.Simulation_response_model> PostAsync(global::Marqeta.Core.Sdk.Models.Financial_request_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.Simulation_response_model>(requestInfo, global::Marqeta.Core.Sdk.Models.Simulation_response_model.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Simulates a financial request (PIN debit) transaction with optional cash back
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Financial_request_model body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Financial_request_model body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Simulate.Financial.FinancialRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Simulate.Financial.FinancialRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Simulate.Financial.FinancialRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
