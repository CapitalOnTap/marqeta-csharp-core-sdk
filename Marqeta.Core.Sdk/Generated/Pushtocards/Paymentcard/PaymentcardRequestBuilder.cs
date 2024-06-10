// <auto-generated/>
using Marqeta.Core.Sdk.Models;
using Marqeta.Core.Sdk.Pushtocards.Paymentcard.Item;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Pushtocards.Paymentcard
{
    /// <summary>
    /// Builds and executes requests for operations under \pushtocards\paymentcard
    /// </summary>
    public class PaymentcardRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.pushtocards.paymentcard.item collection</summary>
        /// <param name="position">Push-to-card token</param>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Pushtocards.Paymentcard.Item.WithTokenItemRequestBuilder"/></returns>
        public Marqeta.Core.Sdk.Pushtocards.Paymentcard.Item.WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new Marqeta.Core.Sdk.Pushtocards.Paymentcard.Item.WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PaymentcardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pushtocards/paymentcard?user_token={user_token}{&count*,fields*,sort_by*,start_index*}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PaymentcardRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pushtocards/paymentcard?user_token={user_token}{&count*,fields*,sort_by*,start_index*}", rawUrl)
        {
        }
        /// <summary>
        /// Returns all push-to-card payment card details
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.PushToCardListResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.PushToCardListResponse?> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder.PaymentcardRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.PushToCardListResponse> GetAsync(Action<RequestConfiguration<Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder.PaymentcardRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.PushToCardListResponse>(requestInfo, Marqeta.Core.Sdk.Models.PushToCardListResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Adds an external card to which funds will be pushed
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Models.Push_to_card_response"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Marqeta.Core.Sdk.Models.Push_to_card_response?> PostAsync(Marqeta.Core.Sdk.Models.Push_to_card_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Marqeta.Core.Sdk.Models.Push_to_card_response> PostAsync(Marqeta.Core.Sdk.Models.Push_to_card_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Marqeta.Core.Sdk.Models.Push_to_card_response>(requestInfo, Marqeta.Core.Sdk.Models.Push_to_card_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns all push-to-card payment card details
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder.PaymentcardRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder.PaymentcardRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Adds an external card to which funds will be pushed
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Marqeta.Core.Sdk.Models.Push_to_card_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Marqeta.Core.Sdk.Models.Push_to_card_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, "{+baseurl}/pushtocards/paymentcard", PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder WithUrl(string rawUrl)
        {
            return new Marqeta.Core.Sdk.Pushtocards.Paymentcard.PaymentcardRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns all push-to-card payment card details
        /// </summary>
        public class PaymentcardRequestBuilderGetQueryParameters 
        {
            /// <summary>Number of push-to-card payment cards to retrieve</summary>
            [QueryParameter("count")]
            public int? Count { get; set; }
            /// <summary>Comma-delimited list of fields to return (e.g. field_1,field_2,..). Leave blank to return all fields.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("fields")]
            public string? Fields { get; set; }
#nullable restore
#else
            [QueryParameter("fields")]
            public string Fields { get; set; }
#endif
            /// <summary>Sort order</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("sort_by")]
            public string? SortBy { get; set; }
#nullable restore
#else
            [QueryParameter("sort_by")]
            public string SortBy { get; set; }
#endif
            /// <summary>Start index</summary>
            [QueryParameter("start_index")]
            public int? StartIndex { get; set; }
            /// <summary>User token</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("user_token")]
            public string? UserToken { get; set; }
#nullable restore
#else
            [QueryParameter("user_token")]
            public string UserToken { get; set; }
#endif
        }
    }
}
