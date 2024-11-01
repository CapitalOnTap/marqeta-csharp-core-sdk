// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Pins.Reveal
{
    /// <summary>
    /// Builds and executes requests for operations under \pins\reveal
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class RevealRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Pins.Reveal.RevealRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RevealRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pins/reveal", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Pins.Reveal.RevealRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RevealRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pins/reveal", rawUrl)
        {
        }
        /// <summary>
        /// Reveals the personal identification number (PIN) of an existing, active card.Be aware that while a cardholder can only set a four-digit PIN using the Marqeta Set PIN widget or `PUT /pins` API, you may see a four-, five-, or six-digit PIN in cases where your cardholders have set a new PIN at an automated teller machine.[WARNING]Only use this endpoint to access a PIN in order to reveal it to its cardholder.Do not use this endpoint for the purpose of storing a PIN at any location.Sending a request to this endpoint requires PCI DSS compliance.You must comply with PCI DSS data security requirements if you want to store, transmit, or process sensitive card data such as the cardholder&apos;s primary account number (PAN), personal identification number (PIN), and card expiration date.If you want to update a card&apos;s PIN instead, send a `PUT` request to the `/pins` endpoint.See &lt;&lt;/core-api/pins#putPins, Create or Update PIN&gt;&gt; on this page for details.Revealing a card&apos;s PIN is a two-step process.You must first create a new control token for the card by sending a `POST` request to `/pins/controltoken`, and then use that token to reveal the PIN.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(global::Marqeta.Core.Sdk.Models.Pin_reveal_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task PostAsync(global::Marqeta.Core.Sdk.Models.Pin_reveal_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Reveals the personal identification number (PIN) of an existing, active card.Be aware that while a cardholder can only set a four-digit PIN using the Marqeta Set PIN widget or `PUT /pins` API, you may see a four-, five-, or six-digit PIN in cases where your cardholders have set a new PIN at an automated teller machine.[WARNING]Only use this endpoint to access a PIN in order to reveal it to its cardholder.Do not use this endpoint for the purpose of storing a PIN at any location.Sending a request to this endpoint requires PCI DSS compliance.You must comply with PCI DSS data security requirements if you want to store, transmit, or process sensitive card data such as the cardholder&apos;s primary account number (PAN), personal identification number (PIN), and card expiration date.If you want to update a card&apos;s PIN instead, send a `PUT` request to the `/pins` endpoint.See &lt;&lt;/core-api/pins#putPins, Create or Update PIN&gt;&gt; on this page for details.Revealing a card&apos;s PIN is a two-step process.You must first create a new control token for the card by sending a `POST` request to `/pins/controltoken`, and then use that token to reveal the PIN.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Pin_reveal_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Pin_reveal_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Pins.Reveal.RevealRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Pins.Reveal.RevealRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Pins.Reveal.RevealRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
