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
namespace Marqeta.Core.Sdk.Pins.Controltoken
{
    /// <summary>
    /// Builds and executes requests for operations under \pins\controltoken
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ControltokenRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Pins.Controltoken.ControltokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ControltokenRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pins/controltoken", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Pins.Controltoken.ControltokenRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ControltokenRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/pins/controltoken", rawUrl)
        {
        }
        /// <summary>
        /// Creates a control token necessary when creating or updating a card&apos;s personal identification number (PIN).Creating, updating, or revealing a card&apos;s PIN is a two-step process.You must first create the control token that is required to create the PIN, and then you create, update, or reveal the PIN itself.The lifespan of the control token in a production environment is either five minutes or one hour from creation, depending on the token type.If multiple tokens are requested for a single card, only the most recent one is valid.Once redeemed, a token cannot be reused.
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.Control_token_response"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.Control_token_response?> PostAsync(global::Marqeta.Core.Sdk.Models.Control_token_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.Control_token_response> PostAsync(global::Marqeta.Core.Sdk.Models.Control_token_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.Control_token_response>(requestInfo, global::Marqeta.Core.Sdk.Models.Control_token_response.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a control token necessary when creating or updating a card&apos;s personal identification number (PIN).Creating, updating, or revealing a card&apos;s PIN is a two-step process.You must first create the control token that is required to create the PIN, and then you create, update, or reveal the PIN itself.The lifespan of the control token in a production environment is either five minutes or one hour from creation, depending on the token type.If multiple tokens are requested for a single card, only the most recent one is valid.Once redeemed, a token cannot be reused.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Control_token_request body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.Control_token_request body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Pins.Controltoken.ControltokenRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Pins.Controltoken.ControltokenRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Pins.Controltoken.ControltokenRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
