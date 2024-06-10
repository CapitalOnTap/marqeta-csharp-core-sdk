// <auto-generated/>
using Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_token}\paymentschedules\{payment_schedule_token}
    /// </summary>
    public class WithPayment_schedule_tokenItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The transitions property</summary>
        public Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder Transitions
        {
            get => new Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.WithPayment_schedule_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPayment_schedule_tokenItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/paymentschedules/{payment_schedule_token}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.WithPayment_schedule_tokenItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPayment_schedule_tokenItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/paymentschedules/{payment_schedule_token}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve a single payment schedule on a specific credit account.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.PaymentScheduleResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.PaymentScheduleResponse?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.PaymentScheduleResponse> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.PaymentScheduleResponse>(requestInfo, Marqeta.Core.Sdk.Models.PaymentScheduleResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve a single payment schedule on a specific credit account.
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
        /// <returns>A <see cref="Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.WithPayment_schedule_tokenItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.WithPayment_schedule_tokenItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.WithPayment_schedule_tokenItemRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
