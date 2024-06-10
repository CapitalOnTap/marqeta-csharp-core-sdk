// <auto-generated/>
using Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions
{
    /// <summary>
    /// Builds and executes requests for operations under \accounts\{account_token}\paymentschedules\{payment_schedule_token}\transitions
    /// </summary>
    public class TransitionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.accounts.item.paymentschedules.item.transitions.item collection</summary>
        /// <param name="position">Unique identifier of the payment schedule transition you want to retrieve.Send a `GET` request to `/credit/accounts/{account_token}/paymentschedules/{payment_schedule_token}/transitions` to retrieve existing payment schedule transition tokens.</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.Item.WithTokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.Item.WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.Item.WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TransitionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/paymentschedules/{payment_schedule_token}/transitions{?count*,sort_by*,start_index*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TransitionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/accounts/{account_token}/paymentschedules/{payment_schedule_token}/transitions{?count*,sort_by*,start_index*}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieve an array of payment schedule transitions on a specific credit account.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.PaymentScheduleTransitionPage"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.PaymentScheduleTransitionPage?> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder.TransitionsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.PaymentScheduleTransitionPage> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder.TransitionsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.PaymentScheduleTransitionPage>(requestInfo, Marqeta.Core.Sdk.Models.PaymentScheduleTransitionPage.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Transition a payment schedule to a new status.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.PaymentScheduleTransitionResponse"/></returns>
        /// <param name="body">Details to create a payment schedule transition</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.PaymentScheduleTransitionResponse?> PostAsync(Marqeta.Core.Sdk.Models.PaymentScheduleTransitionCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.PaymentScheduleTransitionResponse> PostAsync(Marqeta.Core.Sdk.Models.PaymentScheduleTransitionCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.PaymentScheduleTransitionResponse>(requestInfo, Marqeta.Core.Sdk.Models.PaymentScheduleTransitionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve an array of payment schedule transitions on a specific credit account.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder.TransitionsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder.TransitionsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Transition a payment schedule to a new status.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">Details to create a payment schedule transition</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Marqeta.Core.Sdk.Models.PaymentScheduleTransitionCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Marqeta.Core.Sdk.Models.PaymentScheduleTransitionCreateReq body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.TransitionsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieve an array of payment schedule transitions on a specific credit account.
        /// </summary>
        public class TransitionsRequestBuilderGetQueryParameters 
        {
            /// <summary>Number of payment schedule resources to retrieve.</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Field on which to sort.Prefix the field name with a hyphen (`-`) to sort in descending order.Omit the hyphen to sort in ascending order.*NOTE:*You must sort using system field names such as `createdTime`, and not by the field names appearing in response bodies such as `created_time`.</summary>
            [QueryParameter("sort_by")]
            public Marqeta.Core.Sdk.Accounts.Item.Paymentschedules.Item.Transitions.GetSort_byQueryParameterType? SortBy { get; set; }
            /// <summary>Sort order index of the first resource in the returned array.</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
        }
    }
}
