// <auto-generated/>
#pragma warning disable CS0618
using Marqeta.Core.Sdk.Businesstransitions.Business;
using Marqeta.Core.Sdk.Businesstransitions.Item;
using Marqeta.Core.Sdk.Models;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Marqeta.Core.Sdk.Businesstransitions
{
    /// <summary>
    /// Builds and executes requests for operations under \businesstransitions
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class BusinesstransitionsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The business property</summary>
        public global::Marqeta.Core.Sdk.Businesstransitions.Business.BusinessRequestBuilder Business
        {
            get => new global::Marqeta.Core.Sdk.Businesstransitions.Business.BusinessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Marqeta.Core.Sdk.businesstransitions.item collection</summary>
        /// <param name="position">Transition token</param>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Businesstransitions.Item.WithTokenItemRequestBuilder"/></returns>
        public global::Marqeta.Core.Sdk.Businesstransitions.Item.WithTokenItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("token", position);
                return new global::Marqeta.Core.Sdk.Businesstransitions.Item.WithTokenItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Businesstransitions.BusinesstransitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BusinesstransitionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/businesstransitions", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Marqeta.Core.Sdk.Businesstransitions.BusinesstransitionsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BusinesstransitionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/businesstransitions", rawUrl)
        {
        }
        /// <summary>
        /// Creates a business transition
        /// </summary>
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Models.BusinessTransitionResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::Marqeta.Core.Sdk.Models.ApiError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::Marqeta.Core.Sdk.Models.BusinessTransitionResponse?> PostAsync(global::Marqeta.Core.Sdk.Models.BusinessTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::Marqeta.Core.Sdk.Models.BusinessTransitionResponse> PostAsync(global::Marqeta.Core.Sdk.Models.BusinessTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::Marqeta.Core.Sdk.Models.ApiError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::Marqeta.Core.Sdk.Models.BusinessTransitionResponse>(requestInfo, global::Marqeta.Core.Sdk.Models.BusinessTransitionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a business transition
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.BusinessTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::Marqeta.Core.Sdk.Models.BusinessTransitionRequest body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::Marqeta.Core.Sdk.Businesstransitions.BusinesstransitionsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::Marqeta.Core.Sdk.Businesstransitions.BusinesstransitionsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::Marqeta.Core.Sdk.Businesstransitions.BusinesstransitionsRequestBuilder(rawUrl, RequestAdapter);
        }
    }
}
#pragma warning restore CS0618
