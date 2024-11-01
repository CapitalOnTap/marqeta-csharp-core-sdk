// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Fundingsources.Paymentcard.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Fundingsources.Paymentcard
{
    /// <summary>
    /// Builds and executes requests for operations under \fundingsources\paymentcard
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class PaymentcardRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Gets an item from the Marqeta.Core.Sdk.fundingsources.paymentcard.item collection</summary>
        /// <param name="position">Unique identifier of the funding source.Send a `GET` request to `/fundingsources/user/{user_token}` to retrieve existing funding source tokens for a user or to `/fundingsources/business/{business_token}` to retrieve existing funding source tokens for a business.</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Fundingsources.Paymentcard.Item.WithFunding_source_tokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Fundingsources.Paymentcard.Item.WithFunding_source_tokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("funding_source_token", position);
                return new global::Marqeta.Core.Sdk.Fundingsources.Paymentcard.Item.WithFunding_source_tokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Fundingsources.Paymentcard.PaymentcardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PaymentcardRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/paymentcard", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Fundingsources.Paymentcard.PaymentcardRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PaymentcardRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/fundingsources/paymentcard", rawUrl)
        {
        }
        /// <summary>
        /// Create a payment card funding source for an existing account holder.This endpoint returns the card type and the last four digits of the card, and then sets the `active_ field` to `true`.Marqeta retains only a tokenized representation of the card number.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Payment_card_response_model"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.Payment_card_response_model?> PostAsync(global::Marqeta.Core.Sdk.Models.Token_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.Payment_card_response_model> PostAsync(global::Marqeta.Core.Sdk.Models.Token_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.Payment_card_response_model>(requestInfo, global::Marqeta.Core.Sdk.Models.Payment_card_response_model.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create a payment card funding source for an existing account holder.This endpoint returns the card type and the last four digits of the card, and then sets the `active_ field` to `true`.Marqeta retains only a tokenized representation of the card number.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Token_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Token_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Fundingsources.Paymentcard.PaymentcardRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Fundingsources.Paymentcard.PaymentcardRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Fundingsources.Paymentcard.PaymentcardRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
